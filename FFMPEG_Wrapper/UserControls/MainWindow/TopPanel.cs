using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls.MainWindow
{
    public partial class TopPanel : UserControl
    {
        public TopPanel()
        {
            InitializeComponent();
        }
        public void SetLabel(string text)
        {
            panelLabel.Text = text;
            programLabel.Text = $"FFMPEG Wrapper 3000";
        }
    }
}
