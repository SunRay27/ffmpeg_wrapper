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

namespace FFMPEG_Overlay
{
    public class Helper
    {
        public static Form1 form;
        public int totalSeconds;
        public int currentSeconds;
        public void OutputHandler(object sender, DataReceivedEventArgs args)
        {
            // string input = args.Data;
            if (args == null || args.Data == null)
                return;

            string res = args.Data;
            if (args.Data.Contains("Duration:") && args.Data.Contains("start:") && args.Data.Contains("bitrate:"))
            {
                string[] values = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1].Split('.')[0].Split(':');
                int hours = int.Parse(values[0]);
                int minutes = int.Parse(values[1]);
                int seconds = int.Parse(values[2]);
                totalSeconds = seconds + minutes * 60 + hours * 3600;
            }

            if (res.Contains("frame") && res.Contains("fps") && res.Contains("size") && res.Contains("time"))
            {
                int startIndex = res.IndexOf("time=");
                string[] time = res.Substring(startIndex + 5).Split(' ')[0].Split('.')[0].Split(':');

                int hours = int.Parse(time[0]);
                int minutes = int.Parse(time[1]);
                int seconds = int.Parse(time[2]);

                currentSeconds = seconds + minutes * 60 + hours * 3600;

            }

            form.Invoke(new Action(() =>
            {
                form.UpdateProgressBar();
            }));


        }
        public void FFProbeOutputHandler(object sender, DataReceivedEventArgs args)
        {
            if (args == null || args.Data == null)
               return;

            string res = args.Data;
            if (args.Data.Contains("Duration:") && args.Data.Contains("start:") && args.Data.Contains("bitrate:"))
            {
                string[] values = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1].Split('.')[0].Split(':');
                int hours = int.Parse(values[0]);
                int minutes = int.Parse(values[1]);
                int seconds = int.Parse(values[2]);
                totalSeconds = seconds + minutes * 60 + hours * 3600;

                form.Invoke(new Action(() =>
                {
                    form.UpdateProgressBar();
                     form.Log("Got totalSeconds from ffprobe");
                }
));
            }

            //totalSeconds = 0;


        }
        public void OutputHandlerConcat(object sender, DataReceivedEventArgs args)
        {
            // string input = args.Data;
            if (args == null || args.Data == null)
                return;


            string res = args.Data;

            if (res.Contains("frame") && res.Contains("fps") && res.Contains("size") && res.Contains("time"))
            {
                int startIndex = res.IndexOf("time=");
                string[] time = res.Substring(startIndex + 5).Split(' ')[0].Split('.')[0].Split(':');

                int hours = int.Parse(time[0]);
                int minutes = int.Parse(time[1]);
                int seconds = int.Parse(time[2]);

                currentSeconds = seconds + minutes * 60 + hours * 3600;
                form.Invoke(new Action(() =>
                {
                    form.UpdateProgressBar();
                    form.Log("Got current from ffmpeg");
                }
));

            }




        }
    }
    public partial class Form1 : Form
    {
        public enum Codec { H264, H265, VP9 };
        public enum Preset { ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };

        List<Helper> helpers = new List<Helper>();

        bool saveFileSet = false;
        bool concat = false;
        float bitRate = 0;

        string codec = String.Empty;
        string preset = string.Empty;

        string outputPath = String.Empty;
        List<string> inputPaths = new List<string>();

        string fileListPath;

        public Form1()
        {
            InitializeComponent();

            comboBoxCodec.DataSource = Enum.GetValues(typeof(Codec));
            comboBoxPreset.DataSource = Enum.GetValues(typeof(Preset));


            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Helper.form = this;

            progressBar.Minimum = 0;
            progressBar.Maximum = 1000;

            bitRate = (float)numericBitrate.Value / 1024;
            label4.Text = $"{bitRate} Mb/s";

            CheckFolders();
        }
        void CheckFolders()
        {
            string tempPath = AppDomain.CurrentDomain.BaseDirectory + @"\temp";
            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);

            fileListPath = tempPath + @"\files.txt";
            File.WriteAllText(fileListPath,"");
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = true;

            inputPaths = new List<string>();
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                string result = String.Empty;

                for (int i = 0; i < fileSelect.FileNames.Length; i++)
                {
                    result += fileSelect.FileNames[i] + "\n";
                    inputPaths.Add(fileSelect.FileNames[i]);
                }
                // load paths to textBox
                textBoxFiles.Text = result;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFile = new FolderBrowserDialog();

            //saveFile.Filter = "mkv |*mkv*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputPath = saveFile.SelectedPath;
               // List<string> parts = saveFile.FileName.Split(new char[] {'\\'}).ToList();
                //parts.RemoveAt(parts.Count - 1);

               // string res = string.Join("\\", parts);

                labelPath.Text = outputPath;

                saveFileSet = true;
            }


        }
        private void CheckBoxConcat_CheckedChanged(object sender, EventArgs e)
        {
            concat = checkBoxConcat.Checked;
            comboBoxCodec.Enabled = !concat;
            comboBoxPreset.Enabled = !concat;
            numericBitrate.Enabled = !concat;
        }
        private void LabelPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(saveFileSet)
            {
                Process.Start(labelPath.Text);
            }
        }
        private void NumericBitrate_ValueChanged(object sender, EventArgs e)
        {
            bitRate = (float)numericBitrate.Value / 1024;
            label4.Text = $"{bitRate} Mb/s";
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if(inputPaths.Count < 1 || !saveFileSet)
            {
                MessageBox.Show($"Not all parameters are set\ninputs:{inputPaths.Count}\nselectedFolder:{saveFileSet}", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lock(true);

            helpers = new List<Helper>();

            if (concat)
            {
                //Get video durations:
                //./ffprobe -i output2.mkv -show_format 
                for (int i = 0; i < inputPaths.Count; i++)
                {
                    Helper a = new Helper();
                    helpers.Add(a);

                    Process check = new Process();
                    //process.StartInfo.FileName = res + @"\ffmpeg.exe";
                    check.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffprobe.exe";

                    string command2 = $"\"{inputPaths[i]}\"";

                    check.StartInfo.Arguments = $"{command2}";
                    check.StartInfo.UseShellExecute = false;
                    check.StartInfo.RedirectStandardOutput = true;
                    check.StartInfo.RedirectStandardError = true;
                    check.StartInfo.CreateNoWindow = true;
                    // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //* Set your output and error (asynchronous) handlers
                    check.StartInfo.RedirectStandardInput = true;
                    check.OutputDataReceived += new DataReceivedEventHandler(a.FFProbeOutputHandler);
                    check.ErrorDataReceived += new DataReceivedEventHandler(a.FFProbeOutputHandler);
                    //* Start process and handlers
                    check.Start();
                    check.BeginOutputReadLine();
                    check.BeginErrorReadLine();

                    
                }








                //IT DOESNT WORK FROM THAT POINT FOR SOME FUCKING REASON








                Log("FFProbe ended");
                //write files to list
                string result = String.Empty;
                for (int i = 0; i < inputPaths.Count; i++)
                    result += $"file \"{inputPaths[i]}\" \n";

                File.WriteAllText(fileListPath, result);

                string resName = String.Empty;
                for (int i = 0; i < inputPaths.Count; i++)
                {
                    string[] splitName = inputPaths[i].Split('\\');
                    string originalName = splitName[splitName.Length - 1];
                    originalName = originalName.Split('.')[0];
                    resName += $"_{originalName}";
                }

                string command = $"-safe 0 -f concat -i {fileListPath} -c copy \"{outputPath}\\{resName}_merged.mkv\"";
                List<string> parts = Application.ExecutablePath.Split(new char[] { '\\' }).ToList();
                parts.RemoveAt(parts.Count - 1);
                string res = string.Join("\\", parts);

               // Helper a = new Helper();
               // helpers.Add(a);

                Process converter = new Process();
                //process.StartInfo.FileName = res + @"\ffmpeg.exe";
                converter.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffmpeg.exe";

                converter.StartInfo.Arguments = $"{command}";
                converter.StartInfo.UseShellExecute = false;
                converter.StartInfo.RedirectStandardOutput = true;
                converter.StartInfo.RedirectStandardError = true;
                converter.StartInfo.CreateNoWindow = true;
                // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //* Set your output and error (asynchronous) handlers
                converter.StartInfo.RedirectStandardInput = true;
                converter.OutputDataReceived += new DataReceivedEventHandler(helpers[0].OutputHandlerConcat);
                converter.ErrorDataReceived += new DataReceivedEventHandler(helpers[0].OutputHandlerConcat);
                //* Start process and handlers
                converter.Start();
                converter.BeginOutputReadLine();
                converter.BeginErrorReadLine();

                converter.StandardInput.WriteLine("Y");

                Log("Started ffmpeg process");
            }
            else
            {
                
                try
                {
                    for (int i = 0; i < inputPaths.Count; i++)
                    {
                        Helper a = new Helper();
                        helpers.Add(a);

                        string[] splitName = inputPaths[i].Split('\\');
                        string originalName = splitName[splitName.Length - 1];
                        originalName = originalName.Split('.')[0];


                        string command = $"-i \"{inputPaths[i]}\" -vcodec {codec} -preset {preset} -b:v {bitRate}M \"{outputPath}\\{originalName}_compressed.mkv\"";


                        List<string> parts = Application.ExecutablePath.Split(new char[] { '\\' }).ToList();
                        parts.RemoveAt(parts.Count - 1);

                        string res = string.Join("\\", parts);


                        Process process = new Process();
                        //process.StartInfo.FileName = res + @"\ffmpeg.exe";
                        process.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffmpeg.exe";

                        process.StartInfo.Arguments = $"{command}";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;
                        process.StartInfo.CreateNoWindow = true;
                        // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        //* Set your output and error (asynchronous) handlers
                        process.StartInfo.RedirectStandardInput = true;
                        process.OutputDataReceived += new DataReceivedEventHandler(a.OutputHandler);
                        process.ErrorDataReceived += new DataReceivedEventHandler(a.OutputHandler);
                        //* Start process and handlers
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        // process.WaitForExit();

                        process.StandardInput.WriteLine("Y");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong: {ex.Message}", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        int totalVideoLength = 0;
        int currentLength = 0;

        public void UpdateProgressBar()
        {
            currentLength = totalVideoLength = 0;
            for (int i = 0; i < helpers.Count; i++)
            {
                totalVideoLength += helpers[i].totalSeconds;
                currentLength += helpers[i].currentSeconds;
            }
            progressBar.Maximum = totalVideoLength;
            progressBar.Minimum = 0;

            progressBar.Value = currentLength;

            textBoxFiles.Text += $"Total time: {totalVideoLength}\n";
            textBoxFiles.Text += $"current time: {currentLength}\n";

            if (progressBar.Value >= totalVideoLength && totalVideoLength != 0)
                Lock(false);


        }
        void Lock(bool val)
        {
           // textBoxFiles.Enabled = !val;
            buttonSave.Enabled = !val;
            buttonSelect.Enabled = !val;
            buttonStart.Enabled = !val;

            comboBoxCodec.Enabled = !val;
            comboBoxPreset.Enabled = !val;

            checkBoxConcat.Enabled = !val;
            numericBitrate.Enabled = !val;

            progressBar.Value = 0;
        }

        private void ComboBoxCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
              Codec status;
              Enum.TryParse<Codec>(comboBoxCodec.SelectedValue.ToString(), out status);
            //codec = comboBoxCodec.SelectedValue.ToString();

            switch (status)
            {
                case Codec.H264:
                    codec = "libx264";
                    break;
                case Codec.H265:
                    codec = "libx265";
                    break;
                case Codec.VP9:
                    codec = "libvpx-vp9";
                    break;
                default:
                    codec = "libx264";
                    break;
            }
        }
        private void ComboBoxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Preset status;
            // Enum.TryParse<Preset>(comboBoxPreset.SelectedValue.ToString(), out status);
            preset = comboBoxPreset.SelectedValue.ToString();
        }

        internal void Log(string data)
        {
            textBoxFiles.Text += data + "\n";
        }
    }
}
