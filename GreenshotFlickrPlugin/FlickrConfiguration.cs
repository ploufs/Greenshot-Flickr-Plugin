﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2011  Francis  Noel
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
using System.Windows.Forms;

using GreenshotPlugin.Controls;
using GreenshotPlugin.Core;

namespace GreenshotFlickrPlugin {
	/// <summary>
	/// Description of ImgurConfiguration.
	/// </summary>
	[IniSection("Flickr", Description = "Greenshot Flickr Plugin configuration")]
	public class FlickrConfiguration : IniSection {
		[IniProperty("flickrToken", Description = "Token.", DefaultValue = "")]
		public string flickrToken;

		[IniProperty("flickrIsPublic", Description = "IsPublic.", DefaultValue = "true")]
		public bool IsPublic;

		[IniProperty("flickrIsFamily", Description = "IsFamily.", DefaultValue = "true")]
		public bool IsFamily;

		[IniProperty("flickrIsFriend", Description = "IsFriend.", DefaultValue = "true")]
		public bool IsFriend;

		[IniProperty("SafetyLevel", Description = "Safety level", DefaultValue = "None")]
		public FlickrNet.SafetyLevel SafetyLevel;

		[IniProperty("HiddenFromSearch", Description = "Hidden from search", DefaultValue = "None")]
		public FlickrNet.HiddenFromSearch HiddenFromSearch;

		[IniProperty("PictureDisplaySize", Description = "Default picture display size", DefaultValue = "WebUrl")]
		public PictureDisplaySize PictureDisplaySize;
	   
		[IniProperty("UploadFormat", Description="What file type to use for uploading", DefaultValue="png")]
		public OutputFormat UploadFormat;

		[IniProperty("UploadJpegQuality", Description="JPEG file save quality in %.", DefaultValue="80")]
		public int UploadJpegQuality;

		[IniProperty("AfterUploadOpenHistory", Description = "After upload open history.", DefaultValue = "true")]
		public bool AfterUploadOpenHistory;

		[IniProperty("AfterUploadLinkToClipBoard", Description = "After upload send flickr link to clipboard.", DefaultValue = "true")]
		public bool AfterUploadLinkToClipBoard;

		[IniProperty("FlickrUploadHistory", Description = "Flickr upload history (FlickrUploadHistory.hash=deleteHash)")]
		public Dictionary<string, string> flickrUploadHistory;
		
		// Not stored, only run-time!
		public Dictionary<string, FlickrInfo> runtimeFlickrHistory = new Dictionary<string, FlickrInfo>();

		/// <summary>
		/// Supply values we can't put as defaults
		/// </summary>
		/// <param name="property">The property to return a default for</param>
		/// <returns>object with the default value for the supplied property</returns>
		public override object GetDefault(string property) {
			switch(property) {
				case "flickrUploadHistory":
					return new Dictionary<string, string>();
			}
			return null;
		}
			/// <summary>
		/// A form for token
		/// </summary>
		/// <returns>bool true if OK was pressed, false if cancel</returns>
		public bool ShowConfigDialog() {
			SettingsForm settingsForm;
			ILanguage lang = Language.GetInstance();

			BackgroundForm backgroundForm = BackgroundForm.ShowAndWait(FlickrPlugin.Attributes.Name, lang.GetString(LangKey.communication_wait));
			try {
				settingsForm = new SettingsForm(this);
			} finally {
				backgroundForm.CloseDialog();
			}
			settingsForm.AuthToken = this.flickrToken;
			settingsForm.IsFamily = this.IsFamily;
			settingsForm.IsPublic = this.IsPublic;
			settingsForm.IsFriend = this.IsFriend;
			settingsForm.UploadFormat = this.UploadFormat.ToString();
			settingsForm.SafetyLevel = this.SafetyLevel.ToString();
			settingsForm.HiddenFromSearch = this.HiddenFromSearch.ToString();
			settingsForm.DefaultSize = this.PictureDisplaySize.ToString();
			settingsForm.AfterUploadOpenHistory = this.AfterUploadOpenHistory;
			settingsForm.AfterUploadLinkToClipBoard  = this.AfterUploadLinkToClipBoard;
			DialogResult result = settingsForm.ShowDialog();
			if (result == DialogResult.OK)
			{

				this.flickrToken = settingsForm.AuthToken;
				this.IsFamily=settingsForm.IsFamily;
				this.IsPublic=settingsForm.IsPublic;
				this.IsFriend=settingsForm.IsFriend;
				this.SafetyLevel = (FlickrNet.SafetyLevel)Enum.Parse(typeof(FlickrNet.SafetyLevel), settingsForm.SafetyLevel);
				this.HiddenFromSearch = (FlickrNet.HiddenFromSearch)Enum.Parse(typeof(FlickrNet.HiddenFromSearch), settingsForm.HiddenFromSearch);
				this.UploadFormat = (OutputFormat)Enum.Parse(typeof(OutputFormat), settingsForm.UploadFormat.ToLower());
				this.PictureDisplaySize = (PictureDisplaySize)Enum.Parse(typeof(PictureDisplaySize), settingsForm.DefaultSize);

				this.AfterUploadOpenHistory=settingsForm.AfterUploadOpenHistory;
				this.AfterUploadLinkToClipBoard=settingsForm.AfterUploadLinkToClipBoard;
				IniConfig.Save();
				return true;
			}
			return false;
		}
	}
}
