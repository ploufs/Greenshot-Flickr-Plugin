/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2011  Francis Noel
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on Sourceforge: http://sourceforge.net/projects/greenshot/
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using FlickrNet;
using GreenshotPlugin.Core;
using IniFile;

namespace GreenshotFlickrPlugin {
	/// <summary>
	/// Description of ImgurUtils.
	/// </summary>
	public class FlickrUtils {
		private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(typeof(FlickrUtils));
		public static string Flickr_API_KEY = "390bea54b8ef045716dd34680d6e21ba";
		public static string Flickr_SHARED_SECRET = "fed4691539f0784c";
		private static FlickrConfiguration config = IniConfig.GetIniSection<FlickrConfiguration>();

		private FlickrUtils() {
		}

		public static void LoadHistory() {
			if (config.runtimeFlickrHistory == null) {
				return;
			}
			if (config.flickrUploadHistory == null)
			{
				return;
			}

			if (config.runtimeFlickrHistory.Count == config.flickrUploadHistory.Count) {
				return;
			}
			// Load the flickr history
			List<string> hashes = new List<string>();
			foreach (string hash in config.flickrUploadHistory.Keys)
			{
				hashes.Add(hash);
			}
			
			bool saveNeeded = false;

			foreach(string hash in hashes) {
				if (config.runtimeFlickrHistory.ContainsKey(hash)) {
					// Already loaded
					continue;
				}
				try {
					FlickrInfo imgurInfo = FlickrUtils.RetrieveFlickrInfo(hash);
					if (imgurInfo != null) {
						FlickrUtils.RetrieveFlickrThumbnail(imgurInfo);
						config.runtimeFlickrHistory.Add(hash, imgurInfo);
					} else {
						LOG.DebugFormat("Deleting not found Flickr {0} from config.", hash);
						config.flickrUploadHistory.Remove(hash);
						saveNeeded = true;
					}
				} catch (Exception e) {
					LOG.Error("Problem loading Flickr history for hash " + hash, e);
				}
			}
			if (saveNeeded) {
				// Save needed changes
				IniConfig.Save();
			}
		}

		/// <summary>
		/// Do the actual upload to Flickr
		/// For more details on the available parameters, see: http://flickrnet.codeplex.com
		/// </summary>
		/// <param name="imageData">byte[] with image data</param>
		/// <returns>FlickrResponse</returns>
		public static FlickrInfo UploadToFlickr(byte[] imageData, string title, string filename)
		{
			
			Flickr flickr = new Flickr(Flickr_API_KEY, Flickr_SHARED_SECRET,config.flickrToken);

			// build the data stream
			Stream data = new MemoryStream(imageData);

			string uploadID = flickr.UploadPicture(data, filename, title, string.Empty, "GreenShot", config.IsPublic, config.IsFamily, config.IsFriend, ContentType.Screenshot, config.SafetyLevel, config.HiddenFromSearch);

			flickr = null;

			return RetrieveFlickrInfo(uploadID);
		}

		public static Image CreateThumbnail(Image image, int thumbWidth, int thumbHeight) {
			int srcWidth=image.Width;
			int srcHeight=image.Height; 
			Bitmap bmp = new Bitmap(thumbWidth, thumbHeight);  
			using (Graphics gr = System.Drawing.Graphics.FromImage(bmp)) {
				gr.SmoothingMode = SmoothingMode.HighQuality  ; 
				gr.CompositingQuality = CompositingQuality.HighQuality; 
				gr.InterpolationMode = InterpolationMode.High; 
				System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, thumbWidth, thumbHeight);
				gr.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);  
			}
			return bmp;
		}

		public static void RetrieveFlickrThumbnail(FlickrInfo imgurInfo) {
			LOG.InfoFormat("Retrieving Flickr image for {0} with url {1}", imgurInfo.ID, imgurInfo);
			HttpWebRequest webRequest = (HttpWebRequest)NetworkHelper.CreatedWebRequest(imgurInfo.SquareThumbnailUrl);
			webRequest.Method = "GET";
			webRequest.ServicePoint.Expect100Continue = false;

			using (WebResponse response = webRequest.GetResponse()) {
				Stream responseStream = response.GetResponseStream();
				imgurInfo.Image = Image.FromStream(responseStream);
			}
			return;
		}

		public static FlickrInfo RetrieveFlickrInfo(string id)
		{

			LOG.InfoFormat("Retrieving flickr info for {0}", id);

			FlickrInfo flickrInfo = new FlickrInfo();

			Flickr flickr = new Flickr(Flickr_API_KEY, Flickr_SHARED_SECRET, config.flickrToken);
			PhotoInfo photoInfo = flickr.PhotosGetInfo(id);
			flickrInfo.ID = id;
			flickrInfo.Title = photoInfo.Title;
			flickrInfo.Timestamp = photoInfo.DatePosted;
			flickrInfo.Description = photoInfo.Description;
			flickrInfo.LargeUrl = photoInfo.LargeUrl;
			flickrInfo.MediumUrl = photoInfo.MediumUrl;
			flickrInfo.OriginalUrl = photoInfo.OriginalUrl;
			flickrInfo.SquareThumbnailUrl = photoInfo.SquareThumbnailUrl;
			flickrInfo.WebUrl = photoInfo.WebUrl;
			
			flickr = null;
			return flickrInfo;
		}

		public static void DeleteFlickrImage(FlickrInfo flickrInfo)
		{
			// Make sure we remove it from the history, if no error occured
			config.runtimeFlickrHistory.Remove(flickrInfo.ID);
			config.flickrUploadHistory.Remove(flickrInfo.ID);

			Flickr flickr = new Flickr(Flickr_API_KEY, Flickr_SHARED_SECRET, config.flickrToken);
			flickr.PhotosDelete(flickrInfo.ID);
			flickr = null;

			flickrInfo.Image = null;
		}
	}
}
