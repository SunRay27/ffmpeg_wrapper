using FFMPEG_Wrapper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace FFMPEG_Wrapper.Forms.Worker
{
    public partial class VideoProcessLabel : UserControl
    {
        string filePath;
        string folderPath;

        public enum VideoRecodeStatus { Finished, Error, Aborted, InProgress, Waiting }
        public VideoProcessLabel()
        {
            InitializeComponent();
        }
        public void Start(string filename, string fileSavePath, string saveFolderPath)
        {
            filePath = fileSavePath;
            folderPath = saveFolderPath;
            videoLabel.Text = filename;
            UpdateStatus(VideoRecodeStatus.Waiting);
        }

        public void UpdateStatus(VideoRecodeStatus status)
        {
            switch (status)
            {
                case VideoRecodeStatus.Finished:
                    statusLabel.Text = "Finished";
                    statusPicture.BackgroundImage = Resources.ok_32px;
                    openVideoPic.Visible = true;
                    OpenFolderPic.Visible = true;
                    break;
                case VideoRecodeStatus.Error:
                    statusLabel.Text = "Error";
                    statusPicture.BackgroundImage = Resources.error_32px;
                    openVideoPic.Visible = false;
                    OpenFolderPic.Visible = true;
                    break;
                case VideoRecodeStatus.Aborted:
                    statusLabel.Text = "Aborted";
                    statusPicture.BackgroundImage = Resources.error_32px;
                    openVideoPic.Visible = false;
                    OpenFolderPic.Visible = false;
                    break;
                case VideoRecodeStatus.InProgress:
                    statusLabel.Text = "In progress";
                    statusPicture.BackgroundImage = Resources.progress_indicator_32px;
                    openVideoPic.Visible = false;
                    OpenFolderPic.Visible = false;

                    break;
                case VideoRecodeStatus.Waiting:
                    statusLabel.Text = "Waiting";
                    statusPicture.BackgroundImage = null;
                    openVideoPic.Visible = false;
                    OpenFolderPic.Visible = false;

                    break;
                default:
                    break;
            }
            statusPicture.Refresh();
        }

        private void openVideoPic_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
                Process.Start(filePath);
        }

        private void OpenFolderPic_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderPath))
                Process.Start(folderPath);
        }
    }
}
