using FFMPEG_Wrapper.UserControls.About;
using FFMPEG_Wrapper.UserControls.MainWindow;
using FFMPEG_Wrapper.UserControls.Output;
using FFMPEG_Wrapper.UserControls.Settings;
using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls
{
    public partial class LeftPanel : UserControl
    {
        public LeftPanel()
        {
            InitializeComponent();
        }

        Button activeButton;
        TopPanel topPanel;
        

        EditPanel editPanel;
        FileInputPanel fileInputPanel;
        AboutPanel aboutPanel;
        SettingsPanel settingsPanel;

        OutputPanel outputPanel;

        List<UserControl> userControls = new List<UserControl>();
        public void Init(EditPanel editPanel, FileInputPanel fileInputPanel, AboutPanel aboutPanel, SettingsPanel settingsPanel, OutputPanel outputPanel, TopPanel topPanel)
        {
            this.topPanel = topPanel;

            this.editPanel = editPanel;
            this.fileInputPanel = fileInputPanel;
            this.aboutPanel = aboutPanel;
            this.settingsPanel = settingsPanel;
            this.outputPanel = outputPanel;


            userControls.Add(editPanel);
            userControls.Add(fileInputPanel);
            userControls.Add(aboutPanel);
            userControls.Add(settingsPanel);

            userControls.Add(outputPanel);

            //temp measure
            //DeactivateAllUserControls();
            buttonAbout_Click(buttonAbout, null);
        }
        bool MoveSelector(Button from)
        {
            if (from == activeButton)
                return false;
            else
            {
                activeButton = from;
                selector.Location = new Point(selector.Location.X, activeButton.Location.Y);
                topPanel.SetLabel(activeButton.Text);
                return true;
            }
        }
        void UpdateSelector()
        {
            if(activeButton != null)
            {
                selector.Location = new Point(selector.Location.X, activeButton.Location.Y);
            }
        }

        void SetActiveUserControl(UserControl userControl,bool newValue)
        {
            userControl.Visible = newValue;
            userControl.Enabled = newValue;
        }
        void DeactivateAllUserControls()
        {
            foreach (var item in userControls)
            {
                item.Enabled = false;
                item.Visible = false;
            }
        }


        private void buttonInput_Click(object sender, EventArgs e)
        {
            if(MoveSelector((Button)sender))
            {
                DeactivateAllUserControls();
                SetActiveUserControl(fileInputPanel, true);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (MoveSelector((Button)sender))
            {
                DeactivateAllUserControls();
                SetActiveUserControl(editPanel, true);
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            if (MoveSelector((Button)sender))
            {
                DeactivateAllUserControls();
                SetActiveUserControl(outputPanel, true);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (MoveSelector((Button)sender))
            {
                DeactivateAllUserControls();
                SetActiveUserControl(settingsPanel, true);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (MoveSelector((Button)sender))
            {
                DeactivateAllUserControls();
                SetActiveUserControl(aboutPanel, true);
            }
        }

        private void LeftPanel_Resize(object sender, EventArgs e)
        {
            UpdateSelector();
        }
    }
}
