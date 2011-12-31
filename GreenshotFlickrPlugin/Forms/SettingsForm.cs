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
using System.Windows.Forms;

using GreenshotFlickrPlugin.Forms;
using GreenshotPlugin.Core;
using FlickrNet;

namespace GreenshotFlickrPlugin {
	/// <summary>
	/// Description of PasswordRequestForm.
	/// </summary>
	public partial class SettingsForm : Form {
		private ILanguage lang = Language.GetInstance();
		private string flickrFrob = string.Empty;

		public SettingsForm(FlickrConfiguration config) {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeTexts();
			
			combobox_uploadimageformat.Items.Clear();
			foreach(OutputFormat format in Enum.GetValues(typeof(OutputFormat))) {
				combobox_uploadimageformat.Items.Add(format.ToString());
			}

			combobox_hiddenFromSearch.Items.Clear();
			foreach (FlickrNet.HiddenFromSearch hidden in Enum.GetValues(typeof(FlickrNet.HiddenFromSearch)))
			{
				combobox_hiddenFromSearch.Items.Add(hidden.ToString());
			}

			combobox_safetyLevel.Items.Clear();
			foreach (FlickrNet.SafetyLevel safetyLevel in Enum.GetValues(typeof(FlickrNet.SafetyLevel)))
			{
				combobox_safetyLevel.Items.Add(safetyLevel.ToString());
			}

			comboBox_DefaultSize.Items.Clear();
			foreach (PictureDisplaySize displaySize in Enum.GetValues(typeof(PictureDisplaySize)))
			{
				comboBox_DefaultSize.Items.Add(displaySize.ToString());
			}

			FlickrUtils.LoadHistory();

			if (config.runtimeFlickrHistory.Count > 0) {
				historyButton.Enabled = true;
			} else {
				historyButton.Enabled = false;
			}
		}
				
		private void InitializeTexts() {
			this.label_AuthToken.Text = lang.GetString(LangKey.label_AuthToken);
			this.buttonOK.Text = lang.GetString(LangKey.OK);
			this.buttonAuthenticate.Text = lang.GetString(LangKey.buttonAuthenticate);
			this.buttonCancel.Text = lang.GetString(LangKey.CANCEL);
			this.Text = lang.GetString(LangKey.settings_title);
			this.label_upload_format.Text = lang.GetString(LangKey.label_upload_format);
			this.label_HiddenFromSearch.Text = lang.GetString(LangKey.label_HiddenFromSearch);
			this.label_SafetyLevel.Text = lang.GetString(LangKey.label_SafetyLevel);
			this.label_DefaultSize.Text = lang.GetString(LangKey.label_DefaultSize);
			this.label_AfterUpload.Text = lang.GetString(LangKey.label_AfterUpload);
			this.checkboxAfterUploadOpenHistory.Text = lang.GetString(LangKey.label_AfterUploadOpenHistory);
			this.checkboxAfterUploadLinkToClipBoard.Text = lang.GetString(LangKey.label_AfterUploadLinkToClipBoard);
		}

		public bool AfterUploadOpenHistory {
			get { return checkboxAfterUploadOpenHistory.Checked; }
			set { checkboxAfterUploadOpenHistory.Checked = value; }
		}
		public bool AfterUploadLinkToClipBoard
		{
			get { return checkboxAfterUploadLinkToClipBoard.Checked; }
			set { checkboxAfterUploadLinkToClipBoard.Checked = value; }
		}


		public string AuthToken {
			get {return textBoxAuthToken.Text;}
			set {textBoxAuthToken.Text = value;}
		}

		public string HiddenFromSearch
		{
			get { return combobox_hiddenFromSearch.Text; }
			set { combobox_hiddenFromSearch.Text = value; }
		}

		public string SafetyLevel
		{
			get { return combobox_safetyLevel.Text; }
			set { combobox_safetyLevel.Text = value; }
		}

		public string UploadFormat {
			get {return combobox_uploadimageformat.Text;}
			set {combobox_uploadimageformat.Text = value;}
		}

		public string DefaultSize
		{
			get { return comboBox_DefaultSize.Text; }
			set { comboBox_DefaultSize.Text = value; }
		}

		public bool IsFriend {
			get { return this.checkBoxFriend.Checked; }
			set { this.checkBoxFriend.Checked=value; }
		}

		public bool IsFamily
		{
			get { return this.checkBoxFamily.Checked; }
			set { this.checkBoxFamily.Checked = value; }
		}

		public bool IsPublic
		{
			get { return this.checkBoxPublic.Checked; }
			set { this.checkBoxPublic.Checked = value; }
		}

		void ButtonOKClick(object sender, EventArgs e) {

			if (!string.IsNullOrEmpty(flickrFrob))
			{
				Flickr flickr = new Flickr(FlickrUtils.Flickr_API_KEY, FlickrUtils.Flickr_SHARED_SECRET);

				try
				{
					Auth auth = flickr.AuthGetToken(flickrFrob);

					textBoxAuthToken.Text = auth.Token;
					this.DialogResult = DialogResult.OK;
				}
				catch (FlickrException ex)
				{
					MessageBox.Show("Authentication failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		void ButtonCancelClick(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
		
		void ButtonHistoryClick(object sender, EventArgs e) {
			FlickrHistory.ShowHistory();
		}

		private void buttonAuthenticate_Click(object sender, EventArgs e)
		{
			Flickr flickr = new Flickr(FlickrUtils.Flickr_API_KEY, FlickrUtils.Flickr_SHARED_SECRET);

			if (string.IsNullOrEmpty(flickrFrob))
			{
				flickrFrob = flickr.AuthGetFrob();
				string url = flickr.AuthCalcUrl(flickrFrob, AuthLevel.Write);
				System.Diagnostics.Process.Start(url);
			}
			else
			{
				flickrFrob = string.Empty;
				Auth auth = flickr.AuthGetToken(flickrFrob);
				textBoxAuthToken.Text = auth.Token;
			}
		}
	}
}
