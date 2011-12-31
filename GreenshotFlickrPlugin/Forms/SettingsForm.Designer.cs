/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2011  Thomas Braun, Jens Klingen, Robin Krom
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
namespace GreenshotFlickrPlugin {
	partial class SettingsForm {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label_AuthToken = new System.Windows.Forms.Label();
            this.textBoxAuthToken = new System.Windows.Forms.TextBox();
            this.combobox_uploadimageformat = new System.Windows.Forms.ComboBox();
            this.label_upload_format = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.buttonAuthenticate = new System.Windows.Forms.Button();
            this.checkBoxPublic = new System.Windows.Forms.CheckBox();
            this.checkBoxFamily = new System.Windows.Forms.CheckBox();
            this.checkBoxFriend = new System.Windows.Forms.CheckBox();
            this.label_HiddenFromSearch = new System.Windows.Forms.Label();
            this.combobox_hiddenFromSearch = new System.Windows.Forms.ComboBox();
            this.label_SafetyLevel = new System.Windows.Forms.Label();
            this.combobox_safetyLevel = new System.Windows.Forms.ComboBox();
            this.label_DefaultSize = new System.Windows.Forms.Label();
            this.comboBox_DefaultSize = new System.Windows.Forms.ComboBox();
            this.label_AfterUpload = new System.Windows.Forms.Label();
            this.checkboxAfterUploadOpenHistory = new System.Windows.Forms.CheckBox();
            this.checkboxAfterUploadLinkToClipBoard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(267, 217);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(348, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // label_AuthToken
            // 
            this.label_AuthToken.Location = new System.Drawing.Point(11, 21);
            this.label_AuthToken.Name = "label_AuthToken";
            this.label_AuthToken.Size = new System.Drawing.Size(84, 20);
            this.label_AuthToken.TabIndex = 0;
            this.label_AuthToken.Text = "Auth Token";
            // 
            // textBoxAuthToken
            // 
            this.textBoxAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthToken.Location = new System.Drawing.Point(116, 19);
            this.textBoxAuthToken.Name = "textBoxAuthToken";
            this.textBoxAuthToken.ReadOnly = true;
            this.textBoxAuthToken.Size = new System.Drawing.Size(229, 20);
            this.textBoxAuthToken.TabIndex = 1;
            // 
            // combobox_uploadimageformat
            // 
            this.combobox_uploadimageformat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_uploadimageformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_uploadimageformat.FormattingEnabled = true;
            this.combobox_uploadimageformat.Location = new System.Drawing.Point(116, 47);
            this.combobox_uploadimageformat.Name = "combobox_uploadimageformat";
            this.combobox_uploadimageformat.Size = new System.Drawing.Size(309, 21);
            this.combobox_uploadimageformat.TabIndex = 4;
            // 
            // label_upload_format
            // 
            this.label_upload_format.Location = new System.Drawing.Point(11, 50);
            this.label_upload_format.Name = "label_upload_format";
            this.label_upload_format.Size = new System.Drawing.Size(84, 20);
            this.label_upload_format.TabIndex = 3;
            this.label_upload_format.Text = "Upload format";
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.historyButton.Location = new System.Drawing.Point(13, 217);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(75, 23);
            this.historyButton.TabIndex = 17;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.ButtonHistoryClick);
            // 
            // buttonAuthenticate
            // 
            this.buttonAuthenticate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuthenticate.Location = new System.Drawing.Point(351, 18);
            this.buttonAuthenticate.Name = "buttonAuthenticate";
            this.buttonAuthenticate.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthenticate.TabIndex = 2;
            this.buttonAuthenticate.Text = "Authenticate";
            this.buttonAuthenticate.UseVisualStyleBackColor = true;
            this.buttonAuthenticate.Click += new System.EventHandler(this.buttonAuthenticate_Click);
            // 
            // checkBoxPublic
            // 
            this.checkBoxPublic.AutoSize = true;
            this.checkBoxPublic.Location = new System.Drawing.Point(117, 158);
            this.checkBoxPublic.Name = "checkBoxPublic";
            this.checkBoxPublic.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPublic.TabIndex = 11;
            this.checkBoxPublic.Text = "Public";
            this.checkBoxPublic.UseVisualStyleBackColor = true;
            // 
            // checkBoxFamily
            // 
            this.checkBoxFamily.AutoSize = true;
            this.checkBoxFamily.Location = new System.Drawing.Point(178, 158);
            this.checkBoxFamily.Name = "checkBoxFamily";
            this.checkBoxFamily.Size = new System.Drawing.Size(55, 17);
            this.checkBoxFamily.TabIndex = 12;
            this.checkBoxFamily.Text = "Family";
            this.checkBoxFamily.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriend
            // 
            this.checkBoxFriend.AutoSize = true;
            this.checkBoxFriend.Location = new System.Drawing.Point(239, 158);
            this.checkBoxFriend.Name = "checkBoxFriend";
            this.checkBoxFriend.Size = new System.Drawing.Size(55, 17);
            this.checkBoxFriend.TabIndex = 13;
            this.checkBoxFriend.Text = "Friend";
            this.checkBoxFriend.UseVisualStyleBackColor = true;
            // 
            // label_HiddenFromSearch
            // 
            this.label_HiddenFromSearch.Location = new System.Drawing.Point(11, 76);
            this.label_HiddenFromSearch.Name = "label_HiddenFromSearch";
            this.label_HiddenFromSearch.Size = new System.Drawing.Size(104, 20);
            this.label_HiddenFromSearch.TabIndex = 5;
            this.label_HiddenFromSearch.Text = "Hidden from search";
            // 
            // combobox_hiddenFromSearch
            // 
            this.combobox_hiddenFromSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_hiddenFromSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_hiddenFromSearch.FormattingEnabled = true;
            this.combobox_hiddenFromSearch.Location = new System.Drawing.Point(116, 74);
            this.combobox_hiddenFromSearch.Name = "combobox_hiddenFromSearch";
            this.combobox_hiddenFromSearch.Size = new System.Drawing.Size(309, 21);
            this.combobox_hiddenFromSearch.TabIndex = 6;
            // 
            // label_SafetyLevel
            // 
            this.label_SafetyLevel.Location = new System.Drawing.Point(11, 104);
            this.label_SafetyLevel.Name = "label_SafetyLevel";
            this.label_SafetyLevel.Size = new System.Drawing.Size(84, 21);
            this.label_SafetyLevel.TabIndex = 7;
            this.label_SafetyLevel.Text = "Safety level";
            // 
            // combobox_safetyLevel
            // 
            this.combobox_safetyLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_safetyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_safetyLevel.FormattingEnabled = true;
            this.combobox_safetyLevel.Location = new System.Drawing.Point(116, 101);
            this.combobox_safetyLevel.Name = "combobox_safetyLevel";
            this.combobox_safetyLevel.Size = new System.Drawing.Size(309, 21);
            this.combobox_safetyLevel.TabIndex = 8;
            // 
            // label_DefaultSize
            // 
            this.label_DefaultSize.Location = new System.Drawing.Point(11, 131);
            this.label_DefaultSize.Name = "label_DefaultSize";
            this.label_DefaultSize.Size = new System.Drawing.Size(84, 21);
            this.label_DefaultSize.TabIndex = 9;
            this.label_DefaultSize.Text = "Default size";
            // 
            // comboBox_DefaultSize
            // 
            this.comboBox_DefaultSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_DefaultSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DefaultSize.FormattingEnabled = true;
            this.comboBox_DefaultSize.Location = new System.Drawing.Point(117, 126);
            this.comboBox_DefaultSize.Name = "comboBox_DefaultSize";
            this.comboBox_DefaultSize.Size = new System.Drawing.Size(309, 21);
            this.comboBox_DefaultSize.TabIndex = 10;
            // 
            // label_AfterUpload
            // 
            this.label_AfterUpload.Location = new System.Drawing.Point(12, 187);
            this.label_AfterUpload.Name = "label_AfterUpload";
            this.label_AfterUpload.Size = new System.Drawing.Size(84, 21);
            this.label_AfterUpload.TabIndex = 14;
            this.label_AfterUpload.Text = "After upload";
            // 
            // checkboxAfterUploadOpenHistory
            // 
            this.checkboxAfterUploadOpenHistory.AutoSize = true;
            this.checkboxAfterUploadOpenHistory.Location = new System.Drawing.Point(117, 186);
            this.checkboxAfterUploadOpenHistory.Name = "checkboxAfterUploadOpenHistory";
            this.checkboxAfterUploadOpenHistory.Size = new System.Drawing.Size(85, 17);
            this.checkboxAfterUploadOpenHistory.TabIndex = 15;
            this.checkboxAfterUploadOpenHistory.Text = "Open history";
            this.checkboxAfterUploadOpenHistory.UseVisualStyleBackColor = true;
            // 
            // checkboxAfterUploadLinkToClipBoard
            // 
            this.checkboxAfterUploadLinkToClipBoard.AutoSize = true;
            this.checkboxAfterUploadLinkToClipBoard.Location = new System.Drawing.Point(208, 186);
            this.checkboxAfterUploadLinkToClipBoard.Name = "checkboxAfterUploadLinkToClipBoard";
            this.checkboxAfterUploadLinkToClipBoard.Size = new System.Drawing.Size(104, 17);
            this.checkboxAfterUploadLinkToClipBoard.TabIndex = 16;
            this.checkboxAfterUploadLinkToClipBoard.Text = "Link to clipboard";
            this.checkboxAfterUploadLinkToClipBoard.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(432, 249);
            this.Controls.Add(this.checkboxAfterUploadLinkToClipBoard);
            this.Controls.Add(this.checkboxAfterUploadOpenHistory);
            this.Controls.Add(this.label_AfterUpload);
            this.Controls.Add(this.label_DefaultSize);
            this.Controls.Add(this.comboBox_DefaultSize);
            this.Controls.Add(this.label_SafetyLevel);
            this.Controls.Add(this.combobox_safetyLevel);
            this.Controls.Add(this.label_HiddenFromSearch);
            this.Controls.Add(this.combobox_hiddenFromSearch);
            this.Controls.Add(this.checkBoxFriend);
            this.Controls.Add(this.checkBoxFamily);
            this.Controls.Add(this.checkBoxPublic);
            this.Controls.Add(this.buttonAuthenticate);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.label_upload_format);
            this.Controls.Add(this.combobox_uploadimageformat);
            this.Controls.Add(this.label_AuthToken);
            this.Controls.Add(this.textBoxAuthToken);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Flickr settings";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button historyButton;
		private System.Windows.Forms.ComboBox combobox_uploadimageformat;
		private System.Windows.Forms.Label label_upload_format;
		private System.Windows.Forms.TextBox textBoxAuthToken;
		private System.Windows.Forms.Label label_AuthToken;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAuthenticate;
        private System.Windows.Forms.CheckBox checkBoxPublic;
        private System.Windows.Forms.CheckBox checkBoxFamily;
        private System.Windows.Forms.CheckBox checkBoxFriend;
        private System.Windows.Forms.Label label_HiddenFromSearch;
        private System.Windows.Forms.ComboBox combobox_hiddenFromSearch;
        private System.Windows.Forms.Label label_SafetyLevel;
        private System.Windows.Forms.ComboBox combobox_safetyLevel;
        private System.Windows.Forms.Label label_DefaultSize;
        private System.Windows.Forms.ComboBox comboBox_DefaultSize;
        private System.Windows.Forms.Label label_AfterUpload;
        private System.Windows.Forms.CheckBox checkboxAfterUploadOpenHistory;
        private System.Windows.Forms.CheckBox checkboxAfterUploadLinkToClipBoard;
	}
}
