/*
 * Created by SharpDevelop.
 * User: Robin
 * Date: 05.06.2011
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GreenshotFlickrPlugin.Forms
{
	partial class FlickrHistory
	{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlickrHistory));
            this.listview_Flickr_uploads = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Open_webUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_open_squareThumbnailUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_open_mediumUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_open_largeUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_open_originalUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLinksToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_WebUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SquareThumbnailUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_mediumUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_largeUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_originalUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Flickr = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.finishedButton = new System.Windows.Forms.Button();
            this.clipboardButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flickr)).BeginInit();
            this.SuspendLayout();
            // 
            // listview_Flickr_uploads
            // 
            this.listview_Flickr_uploads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_Flickr_uploads.ContextMenuStrip = this.contextMenuStrip1;
            this.listview_Flickr_uploads.FullRowSelect = true;
            this.listview_Flickr_uploads.Location = new System.Drawing.Point(13, 5);
            this.listview_Flickr_uploads.Name = "listview_Flickr_uploads";
            this.listview_Flickr_uploads.Size = new System.Drawing.Size(557, 300);
            this.listview_Flickr_uploads.TabIndex = 0;
            this.listview_Flickr_uploads.UseCompatibleStateImageBehavior = false;
            this.listview_Flickr_uploads.View = System.Windows.Forms.View.Details;
            this.listview_Flickr_uploads.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listview_imgur_uploads_ColumnClick);
            this.listview_Flickr_uploads.SelectedIndexChanged += new System.EventHandler(this.Listview_flickr_uploadsSelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open,
            this.copyLinksToClipboardToolStripMenuItem,
            this.ToolStripMenuItem_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 92);
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open_webUrl,
            this.ToolStripMenuItem_open_squareThumbnailUrl,
            this.ToolStripMenuItem_open_mediumUrl,
            this.ToolStripMenuItem_open_largeUrl,
            this.ToolStripMenuItem_open_originalUrl});
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(204, 22);
            this.ToolStripMenuItem_Open.Text = "Open";
            // 
            // ToolStripMenuItem_Open_webUrl
            // 
            this.ToolStripMenuItem_Open_webUrl.Name = "ToolStripMenuItem_Open_webUrl";
            this.ToolStripMenuItem_Open_webUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_Open_webUrl.Text = "Web url";
            this.ToolStripMenuItem_Open_webUrl.Click += new System.EventHandler(this.ToolStripMenuItem_Open_webUrl_Click);
            // 
            // ToolStripMenuItem_open_squareThumbnailUrl
            // 
            this.ToolStripMenuItem_open_squareThumbnailUrl.Name = "ToolStripMenuItem_open_squareThumbnailUrl";
            this.ToolStripMenuItem_open_squareThumbnailUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_open_squareThumbnailUrl.Text = "Square thumbnail url";
            this.ToolStripMenuItem_open_squareThumbnailUrl.Click += new System.EventHandler(this.ToolStripMenuItem_open_squareThumbnailUrl_Click);
            // 
            // ToolStripMenuItem_open_mediumUrl
            // 
            this.ToolStripMenuItem_open_mediumUrl.Name = "ToolStripMenuItem_open_mediumUrl";
            this.ToolStripMenuItem_open_mediumUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_open_mediumUrl.Text = "Medium url";
            this.ToolStripMenuItem_open_mediumUrl.Click += new System.EventHandler(this.ToolStripMenuItem_open_mediumUrl_Click);
            // 
            // ToolStripMenuItem_open_largeUrl
            // 
            this.ToolStripMenuItem_open_largeUrl.Name = "ToolStripMenuItem_open_largeUrl";
            this.ToolStripMenuItem_open_largeUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_open_largeUrl.Text = "Large url";
            this.ToolStripMenuItem_open_largeUrl.Click += new System.EventHandler(this.ToolStripMenuItem_open_largeUrl_Click);
            // 
            // ToolStripMenuItem_open_originalUrl
            // 
            this.ToolStripMenuItem_open_originalUrl.Name = "ToolStripMenuItem_open_originalUrl";
            this.ToolStripMenuItem_open_originalUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_open_originalUrl.Text = "Original url";
            this.ToolStripMenuItem_open_originalUrl.Click += new System.EventHandler(this.ToolStripMenuItem_open_originalUrl_Click);
            // 
            // copyLinksToClipboardToolStripMenuItem
            // 
            this.copyLinksToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_WebUrl,
            this.ToolStripMenuItem_SquareThumbnailUrl,
            this.ToolStripMenuItem_mediumUrl,
            this.ToolStripMenuItem_largeUrl,
            this.ToolStripMenuItem_originalUrl});
            this.copyLinksToClipboardToolStripMenuItem.Name = "copyLinksToClipboardToolStripMenuItem";
            this.copyLinksToClipboardToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.copyLinksToClipboardToolStripMenuItem.Text = "Copy link(s) to clipboard";
            // 
            // ToolStripMenuItem_WebUrl
            // 
            this.ToolStripMenuItem_WebUrl.Name = "ToolStripMenuItem_WebUrl";
            this.ToolStripMenuItem_WebUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_WebUrl.Text = "Web url";
            this.ToolStripMenuItem_WebUrl.Click += new System.EventHandler(this.ToolStripMenuItem_WebUrl_Click);
            // 
            // ToolStripMenuItem_SquareThumbnailUrl
            // 
            this.ToolStripMenuItem_SquareThumbnailUrl.Name = "ToolStripMenuItem_SquareThumbnailUrl";
            this.ToolStripMenuItem_SquareThumbnailUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_SquareThumbnailUrl.Text = "Square thumbnail url";
            this.ToolStripMenuItem_SquareThumbnailUrl.Click += new System.EventHandler(this.ToolStripMenuItem_SquareThumbnailUrl_Click);
            // 
            // ToolStripMenuItem_mediumUrl
            // 
            this.ToolStripMenuItem_mediumUrl.Name = "ToolStripMenuItem_mediumUrl";
            this.ToolStripMenuItem_mediumUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_mediumUrl.Text = "Medium url";
            this.ToolStripMenuItem_mediumUrl.Click += new System.EventHandler(this.ToolStripMenuItem_mediumUrl_Click);
            // 
            // ToolStripMenuItem_largeUrl
            // 
            this.ToolStripMenuItem_largeUrl.Name = "ToolStripMenuItem_largeUrl";
            this.ToolStripMenuItem_largeUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_largeUrl.Text = "Large url";
            this.ToolStripMenuItem_largeUrl.Click += new System.EventHandler(this.ToolStripMenuItem_largeUrl_Click);
            // 
            // ToolStripMenuItem_originalUrl
            // 
            this.ToolStripMenuItem_originalUrl.Name = "ToolStripMenuItem_originalUrl";
            this.ToolStripMenuItem_originalUrl.Size = new System.Drawing.Size(185, 22);
            this.ToolStripMenuItem_originalUrl.Text = "Original url";
            this.ToolStripMenuItem_originalUrl.Click += new System.EventHandler(this.ToolStripMenuItem_originalUrl_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(204, 22);
            this.ToolStripMenuItem_Delete.Text = "&Delete";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // pictureBox_Flickr
            // 
            this.pictureBox_Flickr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Flickr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Flickr.Location = new System.Drawing.Point(13, 316);
            this.pictureBox_Flickr.Name = "pictureBox_Flickr";
            this.pictureBox_Flickr.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_Flickr.TabIndex = 1;
            this.pictureBox_Flickr.TabStop = false;
            this.pictureBox_Flickr.Click += new System.EventHandler(this.pictureBox_Flickr_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(109, 316);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.AutoSize = true;
            this.openButton.Location = new System.Drawing.Point(109, 349);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "&Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // finishedButton
            // 
            this.finishedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishedButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.finishedButton.Location = new System.Drawing.Point(495, 381);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(75, 23);
            this.finishedButton.TabIndex = 4;
            this.finishedButton.Text = "Finished";
            this.finishedButton.UseVisualStyleBackColor = true;
            this.finishedButton.Click += new System.EventHandler(this.FinishedButtonClick);
            // 
            // clipboardButton
            // 
            this.clipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clipboardButton.AutoSize = true;
            this.clipboardButton.Location = new System.Drawing.Point(109, 381);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(129, 23);
            this.clipboardButton.TabIndex = 5;
            this.clipboardButton.Text = "&Copy link(s) to clipboard";
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.ClipboardButtonClick);
            // 
            // FlickrHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 416);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.finishedButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pictureBox_Flickr);
            this.Controls.Add(this.listview_Flickr_uploads);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlickrHistory";
            this.Text = "Flickr history";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImgurHistoryFormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flickr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button clipboardButton;
		private System.Windows.Forms.Button finishedButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.PictureBox pictureBox_Flickr;
        private System.Windows.Forms.ListView listview_Flickr_uploads;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyLinksToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_WebUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SquareThumbnailUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_largeUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_originalUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_mediumUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open_webUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open_squareThumbnailUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open_mediumUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open_largeUrl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open_originalUrl;
	}
}
