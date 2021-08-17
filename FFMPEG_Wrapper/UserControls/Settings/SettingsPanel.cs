using FFMPEG_Wrapper.Forms.MainWindow;
using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls.Settings
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();


            
        }

        protected override void OnLoad(EventArgs e)
        {
            DisplayPaths();
        }
        void DisplayPaths()
        {
            if(Config.Instance.FFMPEGPathValid)
            {
                ffmpegPathLabel.Text = Config.Instance.FFMPEGPath;
                ffmpegPathLabel.ForeColor = Color.White;
            }
            else
            {
                ffmpegPathLabel.Text = "???";
                ffmpegPathLabel.ForeColor = Constants.ThemeColor;
            }

            if (Config.Instance.FFPROBEPathValid)
            {
                ffprobePathLabel.Text = Config.Instance.FFPROBEPath;
                ffprobePathLabel.ForeColor = Color.White;
            }
            else
            {
                ffprobePathLabel.Text = "???";
                ffprobePathLabel.ForeColor = Constants.ThemeColor;
            }

           
        }
        private void selectffmpegButton_Click(object sender, EventArgs e)
        {
            bool result = Config.Instance.RequestFFMPEG();
            DisplayPaths();
        }

        private void selectffprobeButton_Click(object sender, EventArgs e)
        {
            bool result = Config.Instance.RequestFFPROBE();
            DisplayPaths();
        }
    }
}
