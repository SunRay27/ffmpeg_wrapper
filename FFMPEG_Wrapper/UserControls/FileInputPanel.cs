using FFMPEG_Wrapper.Forms.MainWindow;
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
        ".MP4", ".MKV", ".AVI", ".MPEG", ".FLV", ".WMV"
        };

        static bool IsMediaFile(string path)
        {
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        public FileInputPanel()
        {
            InitializeComponent();
            ShowDropPanel(true);
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            ShowDropPanel(false);

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);


            //check files for duplication
            List<string> filePaths = new List<string>(files);

            for (int i = 0; i < FileManager.Instance.CurrentFiles.Count; i++)
            {
                for (int j = 0; j < filePaths.Count; j++)
                {
                    if (filePaths[j] == FileManager.Instance.CurrentFiles[i].filePath)
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
            /*
            string debugOutput = "";
            foreach (var file in files)
            {
                debugOutput += file + "\n";
            }

            MessageBox.Show(debugOutput);
            */
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
                ShowDropPanel(true);
            }
            else
                dropPanel_DragLeave(this, null);
        }

        private void dropPanel_DragLeave(object sender, System.EventArgs e)
        {
            ShowDropPanel(false);
        }

        void ShowDropPanel(bool newVal)
        {
            fileTable.Visible = !newVal;
            fileTable.Enabled = !newVal;
        }

        private void fileTable_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (fileTable.Controls.Count == 0)
                ShowDropPanel(true);
        }
    }
}
