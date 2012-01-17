/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2011-2012  Francis Noel
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
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Greenshot.Plugin;
using GreenshotFlickrPlugin.Forms;
using GreenshotPlugin.Controls;
using GreenshotPlugin.Core;
using IniFile;

namespace GreenshotFlickrPlugin
{
    /// <summary>
    /// This is the Flickr base code
    /// </summary>
    public class FlickrPlugin : IGreenshotPlugin
    {
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(typeof(FlickrPlugin));
        private static FlickrConfiguration config;
        public static PluginAttribute Attributes;
        private ILanguage lang = Language.GetInstance();
        private IGreenshotHost host;
        private ComponentResourceManager resources;

        public FlickrPlugin()
        {
        }

        public IEnumerable<IDestination> Destinations()
        {
            yield return new FlickrDestination(this);
        }


        public IEnumerable<IProcessor> Processors()
        {
            yield break;
        }

        /// <summary>
        /// Implementation of the IGreenshotPlugin.Initialize
        /// </summary>
        /// <param name="host">Use the IGreenshotPluginHost interface to register events</param>
        /// <param name="pluginAttribute">My own attributes</param>
        public virtual bool Initialize(IGreenshotHost pluginHost, PluginAttribute myAttributes)
        {
            this.host = (IGreenshotHost)pluginHost;
            Attributes = myAttributes;


            // Register configuration (don't need the configuration itself)
            config = IniConfig.GetIniSection<FlickrConfiguration>();
            resources = new ComponentResourceManager(typeof(FlickrPlugin));

            ToolStripMenuItem itemPlugInRoot = new ToolStripMenuItem();
            itemPlugInRoot.Text = "Flickr";
            itemPlugInRoot.Tag = host;
            itemPlugInRoot.Image = (Image)resources.GetObject("flickr");

            ToolStripMenuItem itemPlugInHistory = new ToolStripMenuItem();
            itemPlugInHistory.Text = lang.GetString(LangKey.History);
            itemPlugInHistory.Tag = host;
            itemPlugInHistory.Click += new System.EventHandler(HistoryMenuClick);
            itemPlugInRoot.DropDownItems.Add(itemPlugInHistory);

            ToolStripMenuItem itemPlugInConfig = new ToolStripMenuItem();
            itemPlugInConfig.Text = lang.GetString(LangKey.Configure);
            itemPlugInConfig.Tag = host;
            itemPlugInConfig.Click += new System.EventHandler(ConfigMenuClick);
            itemPlugInRoot.DropDownItems.Add(itemPlugInConfig);

            PluginUtils.AddToContextMenu(host, itemPlugInRoot);

            return true;
        }

        public virtual void Shutdown()
        {
            LOG.Debug("Flickr Plugin shutdown.");
        }

        /// <summary>
        /// Implementation of the IPlugin.Configure
        /// </summary>
        public virtual void Configure()
        {
            config.ShowConfigDialog();
        }

        /// <summary>
        /// This will be called when Greenshot is shutting down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Closing(object sender, FormClosingEventArgs e)
        {
            LOG.Debug("Application closing, de-registering Flickr Plugin!");
            Shutdown();
        }


        public void HistoryMenuClick(object sender, EventArgs eventArgs)
        {
            FlickrUtils.LoadHistory();
            FlickrHistory.ShowHistory();
        }

        public void ConfigMenuClick(object sender, EventArgs eventArgs)
        {
            config.ShowConfigDialog();
        }

        public bool Upload(ICaptureDetails captureDetails, Image image)
        {
            if (string.IsNullOrEmpty(config.flickrToken))
            {
                MessageBox.Show(lang.GetString(LangKey.TokenNotSet), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    BackgroundForm backgroundForm = BackgroundForm.ShowAndWait(Attributes.Name, lang.GetString(LangKey.communication_wait));

                    host.SaveToStream(image, stream, config.UploadFormat, config.UploadJpegQuality);
                    byte[] buffer = stream.GetBuffer();
                    try
                    {
                        string filename = Path.GetFileName(host.GetFilename(config.UploadFormat, captureDetails));
                        FlickrInfo flickrInfo = FlickrUtils.UploadToFlickr(buffer, captureDetails.Title, filename);

                        if (config.flickrUploadHistory == null)
                        {
                            config.flickrUploadHistory = new Dictionary<string, string>();
                        }

                        if (flickrInfo.ID != null)
                        {
                            LOG.InfoFormat("Storing Flickr upload for id {0}", flickrInfo.ID);

                            config.flickrUploadHistory.Add(flickrInfo.ID, flickrInfo.ID);
                            config.runtimeFlickrHistory.Add(flickrInfo.ID, flickrInfo);
                        }

                        flickrInfo.Image = FlickrUtils.CreateThumbnail(image, 90, 90);
                        // Make sure the configuration is save, so we don't lose the deleteHash
                        IniConfig.Save();
                        // Make sure the history is loaded, will be done only once
                        FlickrUtils.LoadHistory();

                        // Show
                        if (config.AfterUploadOpenHistory)
                        {
                            FlickrHistory.ShowHistory();
                        }

                        if (config.AfterUploadLinkToClipBoard)
                        {
                            Clipboard.SetText(flickrInfo.LinkUrl(config.PictureDisplaySize));
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(lang.GetString(LangKey.upload_failure) + " " + e.Message);
                        return false;
                    }
                    finally
                    {
                        backgroundForm.CloseDialog();
                    }
                }
            }
        }
    }
}
