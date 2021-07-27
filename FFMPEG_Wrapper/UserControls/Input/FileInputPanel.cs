using FFMPEG_Wrapper.Forms.MainWindow;
using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls
{
    public partial class FileInputPanel : UserControl
    {
        //TODO: move this shit out of here!!!!
        static string[] mediaExtensions = {
        ".MP4", ".MKV", ".AVI", ".MPEG", ".FLV", ".WMV", ".MOV"
        };

        static bool IsMediaFile(string path)
        {
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        public FileInputPanel()
        {
            InitializeComponent();

            

            ShowFileTablePanel(true);

            dropPanel.BorderColor = buttonBrowse.BackColor = Constants.ThemeColor;
            
        }



        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            WriteFiles(new List<string>(files));

        }
        public void WriteFiles(List<string> filePaths)
        {
            //so we have some files in panel, show panel with videos
            ShowFileTablePanel(false);

            // check for duplication
            for (int i = 0; i < FileManager.Instance.CurrentFiles.Count; i++)
            {
                for (int j = 0; j < filePaths.Count; j++)
                {
                    if (filePaths[j] == FileManager.Instance.CurrentFiles[i].GetFilePath())
                    {
                        filePaths.RemoveAt(j);
                        i = 0;
                        break;
                    }
                }
            }

            // create templates
            List<InputVideoTemplate> templates = new List<InputVideoTemplate>();
            foreach (var item in filePaths)
            {
                InputVideoTemplate newTemplate = new InputVideoTemplate();
                newTemplate.Parent = fileTable;
                templates.Add(newTemplate);
            }


            FileManager.Instance.ProcessInputFiles(filePaths, templates);
        }
        public void RequestInputFiles()
        {

            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = true;
            fileSelect.Filter = "Video files (*.mp4, *.mkv, *.avi *.mpeg *.flv *.wmv *.mov) | *.mp4; *.mkv; *.avi; *.mpeg; *.flv; *.wmv; *.mov";

            //inputPaths = new List<string>();
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                List<string> filePaths = new List<string>(fileSelect.FileNames);
                WriteFiles(filePaths);
            }

        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {


            //get all drop files to string
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> names = new List<string>(files);

            //check if there are wrong input files
            bool wrongFile = false;
            for (int i = 0; i < names.Count; i++)
                if (!IsMediaFile(names[i]))
                    wrongFile = true;

            //open input box or prevent drop
            if (!wrongFile)
            {
                e.Effect = DragDropEffects.Copy;
                ShowFileTablePanel(true);
            }
            else
                dropPanel_DragLeave(this, null);
        }

        private void dropPanel_DragLeave(object sender, System.EventArgs e)
        {
            if (fileTable.Controls.Count != 0)
                ShowFileTablePanel(false);
        }

        void ShowFileTablePanel(bool newVal)
        {
            fileTable.Visible = !newVal;
            fileTable.Enabled = !newVal;
        }

        private void fileTable_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (fileTable.Controls.Count == 0)
                ShowFileTablePanel(true);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            RequestInputFiles();
        }
    }
}
