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
using System.Drawing;
using System.Xml;

namespace GreenshotFlickrPlugin
{
	/// <summary>
	/// Description of ImgurInfo.
	/// </summary>
	public class FlickrInfo : IDisposable {
		private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(typeof(FlickrInfo));


		private string id;
		public string ID
		{
			get { return this.id; }
			set { this.id = value; }
		}

		private string title;
		public string Title {
			get {return title;}
			set {title = value;}
		}

		private DateTime timestamp;
		public DateTime Timestamp {
			get {return timestamp;}
			set {timestamp = value;}
		}

		private Image image;
		public Image Image
		{
			get { return image; }
			set
			{
				if (image != null)
				{
					image.Dispose();
				}
				image = value;
			}
		}

		private string squareThumbnailUrl;
		public string SquareThumbnailUrl
		{
			get{return this.squareThumbnailUrl;}
			set{this.squareThumbnailUrl = value;}
		}

		private string largeUrl;
		public string LargeUrl
		{
			get { return this.largeUrl; }
			set { this.largeUrl = value; }
		}

		private string originalUrl;
		public string OriginalUrl
		{
			get { return this.originalUrl; }
			set { this.originalUrl = value; }
		}

		private string mediumUrl;
		public string MediumUrl
		{
			get { return this.mediumUrl; }
			set { this.mediumUrl = value; }
		}

		private string description;
		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}

		private string webUrl;
		public string WebUrl
		{
			get { return this.webUrl; }
			set { this.webUrl = value; }
		}


		public string LinkUrl(PictureDisplaySize pictureDisplaySize)
		{
			string linkUrl = string.Empty;
			switch (pictureDisplaySize)
			{
				case PictureDisplaySize.WebUrl:
					linkUrl = this.WebUrl;
					break;
				case PictureDisplaySize.Large:
					linkUrl = this.LargeUrl;
					break;
				case PictureDisplaySize.Medium:
					linkUrl = this.MediumUrl;
					break;
				case PictureDisplaySize.OriginalUrl:
					linkUrl = this.OriginalUrl;
					break;
				case PictureDisplaySize.SquareThumbnailUrl:
					linkUrl = this.SquareThumbnailUrl;
					break;
				default:
					linkUrl = this.WebUrl;
					break;
			}
			if (string.IsNullOrEmpty(linkUrl))
			{
				linkUrl = this.WebUrl;
			}

			return linkUrl;
		}

		public FlickrInfo() {
		}

		/// <summary>
		/// The public accessible Dispose
		/// Will call the GarbageCollector to SuppressFinalize, preventing being cleaned twice
		/// </summary>
		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// This Dispose is called from the Dispose and the Destructor.
		/// When disposing==true all non-managed resources should be freed too!
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing) {
			if (disposing)
			{
				if (image != null)
				{
					image.Dispose();
				}
			}
			image = null;
		}
	}
}
