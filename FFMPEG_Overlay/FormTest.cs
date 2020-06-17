using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FFMPEG_Overlay
{

    public partial class MainWindow : Form
    {

        //public TextBox ConsoleTextBox { get { return consoleText; } }
       // public Label FrameText { get { return frameText; } }
       // public ProgressBar ProgressBar { get { return progressBar; } }
        //public enum Codec { H264, H265, VP9 };
        // public enum Preset { ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };

        public static MainWindow instance;

        VideoProcessor.Codec selectedCodec;
        VideoProcessor.Preset selectedPreset;

        bool saveFolderSet = false;
        bool concat = false;
        float bitRate = 0;


        string outputPath = String.Empty;
        //List<string> inputPaths = new List<string>();

        string tempFolder;
        string fileListPath;
        string workingFolder;

        public static string ffmpegPath;



        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            Start();

        }
        void Start()
        {
            comboBoxCodec.DataSource = Enum.GetValues(typeof(VideoProcessor.Codec));
            comboBoxPreset.DataSource = Enum.GetValues(typeof(VideoProcessor.Preset));


            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            bitRate = (float)numericBitrate.Value / 1024f;
            label4.Text = $"{bitRate} Mb/s";

            CreateTempFolders();
            UpdateStatus();
        }

        //FFMPEG path + (some temp folders?)
        void CreateTempFolders()
        {
            workingFolder = AppDomain.CurrentDomain.BaseDirectory;
            tempFolder = workingFolder + @"\temp";
            //string tempPath = workingFolder + @"\temp";
            if (!Directory.Exists(tempFolder))
                Directory.CreateDirectory(tempFolder);

            fileListPath = tempFolder + @"\files.txt";
            File.WriteAllText(fileListPath, "");

            if (XMLSerializer.Exist("ffmpeg"))
                ffmpegPath = XMLSerializer.Load<string>("ffmpeg");

            if (File.Exists(ffmpegPath))
            {
                if (!ffmpegPath.Contains("ffmpeg"))
                {
                    labelffmpegpath.Text = "Укажите путь к ffmpeg.exe";
                    labelffmpegpath.ForeColor = Color.Red;
                }
                else
                {
                    labelffmpegpath.Text = ffmpegPath;
                    labelffmpegpath.ForeColor = Color.Green;
                }
            }
            else
            {
                labelffmpegpath.Text = "Укажите путь к ffmpeg.exe";
                labelffmpegpath.ForeColor = Color.Red;
            }

        }




        //on concat toggle value changed
        private void CheckBoxConcat_CheckedChanged(object sender, EventArgs e)
        {
            concat = checkBoxConcat.Checked;
            comboBoxCodec.Enabled = !concat;
            comboBoxPreset.Enabled = !concat;
            numericBitrate.Enabled = !concat;
        }

        //on click on out path
        private void LabelPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFolderSet)
                Process.Start(labelPath.Text);
        }

        // on chnage bitrateField
        private void NumericBitrate_ValueChanged(object sender, EventArgs e)
        {
            bitRate = (float)numericBitrate.Value / 1024;
            label4.Text = $"{bitRate} Mb/s";
        }

        //start all workers
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            bool foundCyrrilic = false;
            foreach (var item in fileList.CheckedItems)
            {
                if (Regex.IsMatch(item.ToString(), @"\p{IsCyrillic}"))
                {
                    // there is at least one cyrillic character in the string
                    MessageBox.Show($"FFMPEG (или же мой кривой код) не работает с кириллицей - поправь путь к файлу: {item.ToString()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foundCyrrilic = true;
                }
            }
            if (foundCyrrilic)
                return;


            if (fileList.CheckedItems.Count < 1)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
            {
                MessageBox.Show($"Не выбраны файлы для обработки (должна стоять галочка)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!saveFolderSet)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
            {
                MessageBox.Show($"Не выбрана папка для вывода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //todo: make some certain method to check if we have it
            if (ffmpegPath == null)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
            {
                MessageBox.Show($"Не указан путь к ffmpeg.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Lock(true);

            //if concat...
            if (false)
            {

                //write files to list
                string result = String.Empty;
                //   for (int i = 0; i < inputPaths.Count; i++)
                //   result += $"file \'{inputPaths[i]}\' \n";
                result = result.Remove(result.LastIndexOf('\n'));
                File.WriteAllText(fileListPath, result);


                //form resulting fileName
                string resName = String.Empty;
                // for (int i = 0; i < inputPaths.Count; i++)
                {
                    //   string[] splitName = inputPaths[i].Split('\\');
                    // string originalName = splitName[splitName.Length - 1];
                    ////  originalName = originalName.Split('.')[0];
                    //  resName += $"_{originalName}";
                }


                string command = $"-safe 0 -f concat -i {fileListPath} -c copy \"{outputPath}\\{resName}_merged.mkv\"";


                Process converter = new Process();
                converter.StartInfo.FileName = ffmpegPath;
                // converter.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffmpeg.exe";

                converter.StartInfo.Arguments = $"{command}";
                converter.StartInfo.UseShellExecute = false;
                converter.StartInfo.RedirectStandardOutput = true;
                converter.StartInfo.RedirectStandardError = true;
                converter.StartInfo.CreateNoWindow = true;
                converter.EnableRaisingEvents = true;
                // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //* Set your output and error (asynchronous) handlers
                converter.StartInfo.RedirectStandardInput = true;
                // converter.OutputDataReceived += new DataReceivedEventHandler(VideoContainer.OutputHandler);
                // converter.ErrorDataReceived += new DataReceivedEventHandler(VideoContainer.OutputHandler);
                //* Start process and handlers
                converter.Start();
                converter.BeginOutputReadLine();
                converter.BeginErrorReadLine();

                converter.StandardInput.WriteLine("Y");
                converter.StandardInput.WriteLine("Y");
                converter.StandardInput.WriteLine("Y");
                //converter.Exited += Converter_Exited;

                // threads++;
                UpdateStatus();
            }
            else
            {

                try
                {
                    for (int i = 0; i < fileList.CheckedItems.Count; i++)
                    {
                        string[] splitName = fileList.CheckedItems[i].ToString().Split('\\');
                        string originalName = splitName[splitName.Length - 1];
                        originalName = originalName.Split('.')[0];

                        VideoProcessor videoProcessor = new VideoProcessor(fileList.CheckedItems[i].ToString(), outputPath, $"{originalName}_compressed", selectedCodec, selectedPreset, VideoProcessor.OutExtension.MKV, bitRate);

                        videoProcessor.onProcessExit += Converter_Exited;

                        videoProcessor.StartProcessing();

                        //threads++;
                        // UpdateThreads();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong: {ex.Message}", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //callback for exited worker
        private void Converter_Exited(object sender, EventArgs e)
        {

        }

        //update video processors' statuses and lock ui if have workers
        void UpdateStatus()
        {

            // Log(threads.ToString());
            // if (threads <= 0)
            {
                //  labelStatus.Text = "No tasks running... Waiting for command...";
                //   labelStatus.ForeColor = Color.Green;
                //   Lock(false);
            }
            // else
            {
                //    labelStatus.Text = $"Running {threads} tasks...";
                //    labelStatus.ForeColor = Color.Red;
                //    Lock(true);
            }
        }

        //Lock/Unlock UI while processing
        void Lock(bool val)
        {
            openFileButton.Enabled = !val;
            buttonStart.Enabled = !val;

            comboBoxCodec.Enabled = !val;
            comboBoxPreset.Enabled = !val;

            checkBoxConcat.Enabled = !val;
            numericBitrate.Enabled = !val;


        }

        //assign codec value from comboBox
        private void ComboBoxCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBoxCodec.SelectedValue.ToString(), out selectedCodec);
        }

        //assign codec preset from comboBox
        private void ComboBoxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBoxPreset.SelectedValue.ToString(), out selectedPreset);
        }

        //open file dialog to open ffmpeg
        private void selectFFMPEGClick(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;

            fileSelect.Filter = "ffmpeg.exe |*.exe;";
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                if (fileSelect.FileName.Contains("ffmpeg.exe"))
                {
                    labelffmpegpath.Text = fileSelect.FileName;
                    labelffmpegpath.ForeColor = Color.Green;
                    ffmpegPath = fileSelect.FileName;
                    XMLSerializer.Save("ffmpeg", ffmpegPath);
                }
                else
                {
                    labelffmpegpath.Text = "Укажите путь к ffmpeg.exe";
                    labelffmpegpath.ForeColor = Color.Red;
                }
            }
        }

        private void SaveToButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFile = new FolderBrowserDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputPath = saveFile.SelectedPath;
                labelPath.Text = outputPath;
                saveFolderSet = true;
            }
        }

        private void OpenFilesClick(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileList.Items.Count > 0)
                fileList.Items.RemoveAt(fileList.SelectedIndex);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }



}
