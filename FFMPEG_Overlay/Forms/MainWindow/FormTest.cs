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

        [Serializable]
        public class GlobalSettings
        {
            
            public string saveFolder = string.Empty;
            public string ffmpegPath = string.Empty;

            public bool IsSaveFolderValid()
            {
                return Directory.Exists(saveFolder);
            }
            public bool IsFFMPEGPathValid()
            {
                bool result = false;

                if (ffmpegPath.Contains("ffmpeg.exe"))
                {
                    try
                    {
                    Process process = new Process();

                    process.StartInfo.FileName = ffmpegPath;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.Start();

                    string message = process.StandardError.ReadToEnd();

                    if (message.Contains("ffmpeg version"))
                        result = true;

                    if(!process.HasExited)
                        process.Kill();
                    }
                    catch
                    { }
                }


                return result;
            }
        }

        public class ConvertSettings
        {

        }

        GlobalSettings globalSettings = new GlobalSettings();
        ConvertSettings convertSettings;


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
            comboBoxCodec.DataSource = Enum.GetValues(typeof(VideoProcessor.VideoCodec));
            comboBoxACodec.DataSource = Enum.GetValues(typeof(VideoProcessor.AudioCodec));
            comboBoxPreset.DataSource = Enum.GetValues(typeof(VideoProcessor.Preset));
            comboExtention.DataSource = Enum.GetValues(typeof(VideoProcessor.OutExtension));


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
            
            if (!Directory.Exists(tempFolder))
                Directory.CreateDirectory(tempFolder);

            fileListPath = tempFolder + @"\files.txt";
            File.WriteAllText(fileListPath, "");

            if (XMLSerializer.Exist("settings"))
                globalSettings = XMLSerializer.Load<GlobalSettings>("settings");

            if(globalSettings.IsFFMPEGPathValid())
            {
                //labelffmpegpath.Text = globalSettings.ffmpegPath;
                //labelffmpegpath.ForeColor = Color.Green;
                selectFFMPEGButton.Enabled = false;
            }
            else
            {
                //labelffmpegpath.Text = "Укажите путь к ffmpeg.exe";
                //labelffmpegpath.ForeColor = Color.Red;
            }
            if (globalSettings.IsSaveFolderValid())
            {
                labelPath.Text = globalSettings.saveFolder;
            }
            else
            {
                labelPath.Text = "No output directory set...";
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
            if (globalSettings.IsSaveFolderValid())
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


            if (fileList.CheckedItems.Count < 1)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
            {
                MessageBox.Show($"Не выбраны файлы для обработки (должна стоять галочка)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!globalSettings.IsSaveFolderValid())// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
            {
                MessageBox.Show($"Не выбрана папка для вывода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //todo: make some certain method to check if we have it
            if (!globalSettings.IsFFMPEGPathValid())// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
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


                string command = $"-safe 0 -f concat -i {fileListPath} -c copy \"{globalSettings.saveFolder}\\{resName}_merged.mkv\"";


                Process converter = new Process();
                converter.StartInfo.FileName =globalSettings.ffmpegPath;
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

                
                
                    for (int i = 0; i < fileList.CheckedItems.Count; i++)
                    {
                        string[] splitName = fileList.CheckedItems[i].ToString().Split('\\');
                        string originalName = splitName[splitName.Length - 1];
                        originalName = originalName.Split('.')[0];

                        VideoProcessor videoProcessor = new VideoProcessor
                            (
                            fileList.CheckedItems[i].ToString(),
                            globalSettings.saveFolder,
                            $"{textPrefix.Text}{originalName}{textPostfix.Text}",
                            selectedCodec,
                            selectedACodec,
                            selectedPreset,
                            selectedExtension,
                            bitRate,
                            globalSettings.ffmpegPath,
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
            //openFileButton.Enabled = !val;
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

        

        private void SaveToButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFile = new FolderBrowserDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                globalSettings.saveFolder = saveFile.SelectedPath;

                if (globalSettings.IsSaveFolderValid())
                {
                    labelPath.Text = globalSettings.saveFolder;

                    XMLSerializer.Save("settings", globalSettings);
                }
                else
                {
                    globalSettings.saveFolder = String.Empty;
                    labelPath.Text = "No output directory set...";
                    var Result = MessageBox.Show($"Некорректный путь - содержит кириллицу", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (Result == DialogResult.Retry)
                    {
                        SaveToButtonClick(this, null);
                    }

                }

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
            if (fileList.Items.Count > 0 && fileList.SelectedIndex >= 0)
                fileList.Items.RemoveAt(fileList.SelectedIndex);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxACodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBoxACodec.SelectedValue.ToString(), out selectedACodec);
        }

        private void comboExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboExtention.SelectedValue.ToString(), out selectedExtension);
        }

        private void checkWidth_CheckedChanged(object sender, EventArgs e)
        {
            numericWidth.Enabled = checkWidth.Checked;
        }

        private void checkHeight_CheckedChanged(object sender, EventArgs e)
        {
            numericHeight.Enabled = checkHeight.Checked;
        }

        int GetTargetHeight()
        {
            if (checkHeight.Checked)
                return (int)numericHeight.Value;
            else
                return -2;
        }
        int GetTargetWidth()
        {
            if (checkWidth.Checked)
                return (int)numericWidth.Value;
            else
                return -2;
        }
        //open file dialog to open ffmpeg
        private void selectFFMPEGButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;

            fileSelect.Filter = "ffmpeg.exe |*.exe;";
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                globalSettings.ffmpegPath = fileSelect.FileName;
                if (globalSettings.IsFFMPEGPathValid())
                {
                    // labelffmpegpath.Text = fileSelect.FileName;
                    // labelffmpegpath.ForeColor = Color.Green;

                    XMLSerializer.Save("settings", globalSettings);
                    selectFFMPEGButton.Enabled = false;
                }
                else
                {
                    // labelffmpegpath.Text = "Укажите путь к ffmpeg.exe";
                    //labelffmpegpath.ForeColor = Color.Red;
                    globalSettings.ffmpegPath = string.Empty;


                    var Result = MessageBox.Show($"Файл не прошёл проверку: может это не ffmpeg?", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (Result == DialogResult.Retry)
                    {
                        selectFFMPEGButton_Click(this, null);
                    }
                }
            }
        }
    }



}
