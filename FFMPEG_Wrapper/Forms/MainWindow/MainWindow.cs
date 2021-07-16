using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace FFMPEG_Wrapper
{

    public partial class MainWindow : Form
    {


        //Config config;


        VideoProcessor.VideoCodec selectedCodec;
        VideoProcessor.AudioCodec selectedACodec;
        VideoProcessor.Preset selectedPreset;
        VideoProcessor.OutExtension selectedExtension;

        bool concat = false;
        float bitRate = 0;



        string tempFolder;
        string fileListPath;
        string workingFolder;




        public MainWindow()
        {
            InitializeComponent();
            Start();

        }
        void Start()
        {

            /* UI REBUILD
            comboBoxCodec.DataSource = Enum.GetValues(typeof(VideoProcessor.VideoCodec));
            comboBoxACodec.DataSource = Enum.GetValues(typeof(VideoProcessor.AudioCodec));
            comboBoxPreset.DataSource = Enum.GetValues(typeof(VideoProcessor.Preset));
            comboExtention.DataSource = Enum.GetValues(typeof(VideoProcessor.OutExtension));
            */

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            Thread.CurrentThread.CurrentCulture = customCulture;

            FileManager manager = new FileManager();

            //not first start...
            if (XMLSerializer.Exist(Config.ConfigFileName))
            {
                Config config = XMLSerializer.Load<Config>(Config.ConfigFileName);
            }
            else
            {
                Config config = new Config();
                config.Init();
            }

            /* UI REBUILD
           bitRate = (float)numericBitrate.Value / 1024f;
           label4.Text = $"{bitRate} Mb/s";
            */
            
        }

        //FFMPEG path + (some temp folders?)




        //on concat toggle value changed
        private void CheckBoxConcat_CheckedChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           concat = checkBoxConcat.Checked;
           comboBoxCodec.Enabled = !concat;
           comboBoxPreset.Enabled = !concat;
           numericBitrate.Enabled = !concat;
            */
        }

        //on click on out path
        private void LabelPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* UI REBUILD
           if (config.SaveFolderValid)
               Process.Start(labelPath.Text);
            */
        }

        // on chnage bitrateField
        private void NumericBitrate_ValueChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           bitRate = (float)numericBitrate.Value / 1024;
           label4.Text = $"{bitRate} Mb/s";
            */
        }

        //start all workers
        private void ButtonStart_Click(object sender, EventArgs e)
        {

            /* UI REBUILD
           if (fileList.CheckedItems.Count < 1)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не выбраны файлы для обработки (должна стоять галочка)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           if (!config.SaveFolderValid)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не выбрана папка для вывода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           //todo: make some certain method to check if we have it
           if (!config.FFMPEGPathValid)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не указан путь к ffmpeg.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }






           for (int i = 0; i < fileList.CheckedItems.Count; i++)
           {
               string[] splitName = fileList.CheckedItems[i].ToString().Split('\\');
               string originalName = splitName[splitName.Length - 1];
               originalName = originalName.Split('.')[0];

               VideoProcessor videoProcessor = new VideoProcessor
                   (
                   fileList.CheckedItems[i].ToString(),
                   config.SaveFolder,
                   $"{textPrefix.Text}{originalName}{textPostfix.Text}",
                   selectedCodec,
                   selectedACodec,
                   selectedPreset,
                   selectedExtension,
                   bitRate,
                   config.FFMPEGPath,
                   GetTargetWidth(),
                   GetTargetHeight(),
                   checkHFlip.Checked,
                   checkVFlip.Checked
                   );

               videoProcessor.onProcessExit += Converter_Exited;

               videoProcessor.StartProcessing();

               //threads++;
               // UpdateThreads();

           }

           */

        }

        //callback for exited converter
        private void Converter_Exited(object sender, EventArgs e)
        {
            ShowMessage("converter finished callback");
        }

        //Lock/Unlock UI while processing
        void Lock(bool val)
        {
            /* UI REBUILD
           //openFileButton.Enabled = !val;
           buttonStart.Enabled = !val;

           comboBoxCodec.Enabled = !val;
           comboBoxPreset.Enabled = !val;

           checkBoxConcat.Enabled = !val;
           numericBitrate.Enabled = !val;

           */
        }

        //assign codec value from comboBox
        private void ComboBoxCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           Enum.TryParse(comboBoxCodec.SelectedValue.ToString(), out selectedCodec);
            */
        }

        //assign codec preset from comboBox
        private void ComboBoxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           Enum.TryParse(comboBoxPreset.SelectedValue.ToString(), out selectedPreset);
            */
        }



        private void SaveToButtonClick(object sender, EventArgs e)
        {
            /* UI REBUILD
           bool requestResult = config.RequestSaveFolder();
           if(requestResult)
           labelPath.Text = config.SaveFolder;
            */
        }

        private void OpenFilesClick(object sender, EventArgs e)
        {
            /* UI REBUILD
           OpenFileDialog fileSelect = new OpenFileDialog();
           fileSelect.Multiselect = true;

           //inputPaths = new List<string>();
           if (fileSelect.ShowDialog() == DialogResult.OK)
           {
               string result = String.Empty;

               for (int i = 0; i < fileSelect.FileNames.Length; i++)
               {
                   result += fileSelect.FileNames[i] + "\n";
                   fileList.Items.Add(fileSelect.FileNames[i]);
                   //inputPaths.Add(fileSelect.FileNames[i]);
               }
               // load paths to textBox
               // fileList.Items.Add(result);
               //textBoxFiles.Text = result;
           }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        { /* UI REBUILD
            if (fileList.Items.Count > 0 && fileList.SelectedIndex >= 0)
                fileList.Items.RemoveAt(fileList.SelectedIndex);
            */
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxACodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           Enum.TryParse(comboBoxACodec.SelectedValue.ToString(), out selectedACodec);
            */
        }

        private void comboExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           Enum.TryParse(comboExtention.SelectedValue.ToString(), out selectedExtension);
            */
        }

        private void checkWidth_CheckedChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           numericWidth.Enabled = checkWidth.Checked;
            */
        }

        private void checkHeight_CheckedChanged(object sender, EventArgs e)
        {
            /* UI REBUILD
           numericHeight.Enabled = checkHeight.Checked;
            */
        }

        int GetTargetHeight()
        {
            /* UI REBUILD
           if (checkHeight.Checked)
               return (int)numericHeight.Value;
           else
               return -2;
            */
            return -2;
        }
        int GetTargetWidth()
        {
            /* UI REBUILD
           if (checkWidth.Checked)
               return (int)numericWidth.Value;
           else
               return -2;
            */
            return -2;
        }
        //open file dialog to open ffmpeg
        private void selectFFMPEGButton_Click(object sender, EventArgs e)
        {
            bool resquestResult = Config.Instance.RequestFFMPEG();
            /* UI REBUILD
            selectFFMPEGButton.Enabled = !resquestResult;
            */
        }

        void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "debug message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }




}
