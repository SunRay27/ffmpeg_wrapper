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
    public class VideoContainer
    {
        public static MainWindow window;
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

            window.Invoke(new Action(() =>
            {
                window.UpdateProgressBar();
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

                window.Invoke(new Action(() =>
                {
                    window.UpdateProgressBar();
                     window.Log("Got totalSeconds from ffprobe");
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
                window.Invoke(new Action(() =>
                {
                    window.UpdateProgressBar();
                    window.Log("Got current from ffmpeg");
                }
));

            }




        }
    }


    public partial class MainWindow : Form
    {
        public enum Codec { H264, H265, VP9 };
        public enum Preset { ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };

        List<VideoContainer> videos = new List<VideoContainer>();

        bool saveFolderSet = false;
        bool concat = false;
        float bitRate = 0;

        string codec = String.Empty;
        string preset = string.Empty;

        string outputPath = String.Empty;
        List<string> inputPaths = new List<string>();

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
            comboBoxCodec.DataSource = Enum.GetValues(typeof(Codec));
            comboBoxPreset.DataSource = Enum.GetValues(typeof(Preset));


            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            VideoContainer.window = this;

            progressBar.Minimum = 0;
            progressBar.Maximum = 1000;

            bitRate = (float)numericBitrate.Value / 1024;
            label4.Text = $"{bitRate} Mb/s";

            workingFolder = AppDomain.CurrentDomain.BaseDirectory;
            tempFolder = workingFolder + @"\temp";
            //string tempPath = workingFolder + @"\temp";
            if (!Directory.Exists(tempFolder))
                Directory.CreateDirectory(tempFolder);

            fileListPath = tempFolder + @"\files.txt";
            File.WriteAllText(fileListPath, "");

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

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputPath = saveFile.SelectedPath;
                labelPath.Text = outputPath;
                saveFolderSet = true;
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
            if(saveFolderSet)
                Process.Start(labelPath.Text);
        }
        private void NumericBitrate_ValueChanged(object sender, EventArgs e)
        {
            bitRate = (float)numericBitrate.Value / 1024;
            label4.Text = $"{bitRate} Mb/s";
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if(inputPaths.Count < 1 || !saveFolderSet)
            {
                MessageBox.Show($"Not all parameters are set\ninputs:{inputPaths.Count}\nselectedFolder:{saveFolderSet}", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lock(true);

            videos = new List<VideoContainer>();

            if (concat)
            {
                //Get video durations:
                for (int i = 0; i < inputPaths.Count; i++)
                {
                    VideoContainer a = new VideoContainer();
                    videos.Add(a);

                    Start_ffprobe(inputPaths[i], new DataReceivedEventHandler(a.FFProbeOutputHandler));
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

               // Helper a = new Helper();
               // helpers.Add(a);

                Process converter = new Process();
                converter.StartInfo.FileName = workingFolder + @"\ffmpeg.exe";
               // converter.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffmpeg.exe";

                converter.StartInfo.Arguments = $"{command}";
                converter.StartInfo.UseShellExecute = false;
                converter.StartInfo.RedirectStandardOutput = true;
                converter.StartInfo.RedirectStandardError = true;
                converter.StartInfo.CreateNoWindow = true;
                // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //* Set your output and error (asynchronous) handlers
                converter.StartInfo.RedirectStandardInput = true;
                converter.OutputDataReceived += new DataReceivedEventHandler(videos[0].OutputHandlerConcat);
                converter.ErrorDataReceived += new DataReceivedEventHandler(videos[0].OutputHandlerConcat);
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
                        VideoContainer a = new VideoContainer();
                        videos.Add(a);

                        string[] splitName = inputPaths[i].Split('\\');
                        string originalName = splitName[splitName.Length - 1];
                        originalName = originalName.Split('.')[0];


                        string command = $"-i \"{inputPaths[i]}\" -vcodec {codec} -preset {preset} -b:v {bitRate}M \"{outputPath}\\{originalName}_compressed.mkv\"";


                        Process process = new Process();
                        process.StartInfo.FileName = workingFolder + @"\ffmpeg.exe";
                        //process.StartInfo.FileName = @"F:\Сервис\Настройка\Работа с видео\ffmpeg\bin\ffmpeg.exe";

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

        void Start_ffprobe(string file, DataReceivedEventHandler handler)
        {
            string args = $"\"{file}\"";

            Process ffprobe = new Process();
            ffprobe.StartInfo.FileName = workingFolder + @"\ffprobe.exe";
            ffprobe.StartInfo.Arguments = args;
            ffprobe.StartInfo.UseShellExecute = false;
            ffprobe.StartInfo.CreateNoWindow = true;

            ffprobe.StartInfo.RedirectStandardOutput = true;
            ffprobe.StartInfo.RedirectStandardError = true;
            ffprobe.StartInfo.RedirectStandardInput = true;

            ffprobe.OutputDataReceived += new DataReceivedEventHandler(handler);
            ffprobe.ErrorDataReceived += new DataReceivedEventHandler(handler);

            ffprobe.Start();
            ffprobe.BeginOutputReadLine();
            ffprobe.BeginErrorReadLine();
        }

        int totalVideoLength = 0;
        int currentLength = 0;

        public void UpdateProgressBar()
        {
            currentLength = totalVideoLength = 0;
            for (int i = 0; i < videos.Count; i++)
            {
                totalVideoLength += videos[i].totalSeconds;
                currentLength += videos[i].currentSeconds;
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
              Enum.TryParse(comboBoxCodec.SelectedValue.ToString(), out status);

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
            preset = comboBoxPreset.SelectedValue.ToString();
        }

        internal void Log(string data)
        {
            textBoxFiles.Text += data + "\n";
        }
    }
}
