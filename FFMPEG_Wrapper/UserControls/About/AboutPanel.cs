using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls.About
{
    public partial class AboutPanel : UserControl
    {
        public AboutPanel()
        {
            InitializeComponent();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            programVersionLabel.Text = $"FFMPEGWrapper3000 ver. { Assembly.GetEntryAssembly().GetName().Version} by Yaroslav Chernii 2021";

        }
    }
}
