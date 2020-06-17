using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Overlay
{
    public class VideoProcessor
    {
        public enum Codec { H264, H265, VP9, Copy };
        public enum Preset { ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };
        public enum OutExtension { MP4, MKV };

        //in kb/s
        float bitRate = 0;

        string codec = String.Empty;
        string preset = String.Empty;

        string inputPath = String.Empty;
        string outputPath = String.Empty;

        int totalTime = 0;
        int curTime = 0;


        WorkerForm worker;

        Process process;
        public Process Process { get { return process; } }

        //public DataReceivedEventHandler onProcessPrint;
        public EventHandler onProcessExit;

        void SetCodecToString(Codec codec)
        {
            switch (codec)
            {
                case Codec.H264:
                    this.codec = "libx264";
                    break;
                case Codec.H265:
                    this.codec = "libx265";
                    break;
                case Codec.VP9:
                    this.codec = "libvpx-vp9";
                    break;
                case Codec.Copy:
                    this.codec = "copy";
                    break;
                default:
                    this.codec = "libx264";
                    break;
            }
        }
        void SetPresetToString(Preset preset)
        {
            this.preset = preset.ToString();
        }
        public VideoProcessor(string inputPath, string outputFolder, string outName, Codec codec, Preset preset, OutExtension ext, float bitrate)
        {
            this.inputPath = inputPath;
            this.outputPath = $@"{outputFolder}\{outName}.{ext.ToString()}";
            this.bitRate = bitrate;

            SetCodecToString(codec);
            SetPresetToString(preset);

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }


        public void StartProcessing()
        {
            string command = $"-i {inputPath} -c:v {codec} -b:v {bitRate}M -preset {preset} {outputPath}";

            process = new Process();
            process.StartInfo.FileName = MainWindow.ffmpegPath;

            
            string deb = MainWindow.ffmpegPath;
            process.EnableRaisingEvents = true;


            {
                 process.StartInfo.UseShellExecute = false;
                 process.StartInfo.CreateNoWindow = true;



                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
            }
            //

            process.Exited += OnProcessExit;
            //process.OutputDataReceived += new DataReceivedEventHandler(OnProcessPrint);
            process.ErrorDataReceived += new DataReceivedEventHandler(InterceptOutputAndUpdateUI);

            process.StartInfo.Arguments = $"{command}";


            process.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            process.StartInfo.StandardErrorEncoding = Encoding.GetEncoding(866);


            //open worker window
            worker = new WorkerForm(this);
            worker.Show();
            worker.SetName(outputPath);

            //* Start process and handlers
            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.StandardInput.WriteLine("Y");
            //process.WaitForExit();
        }


        void OnProcessExit(object sender, EventArgs e)
        {
            onProcessExit?.Invoke(sender,e);
            worker.CompleteConversion();
        }

        void InterceptOutputAndUpdateUI(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;

            if(e.Data.Contains("frame=") && e.Data.Contains("fps=") && e.Data.Contains("size=") && e.Data.Contains("time=") && e.Data.Contains("bitrate="))
            {
                //it is a status string
                worker.SetStatus(e.Data);

                this.curTime = 0;

                string time = e.Data.Split(new string[] { "time=", " bitrate=" },StringSplitOptions.RemoveEmptyEntries)[1];

                int hours = Convert.ToInt32(time.Split(':')[0]);
                int minutes = Convert.ToInt32(time.Split(':')[1]);
                int seconds = Convert.ToInt32(time.Split(':')[2].Split('.')[0]);

                this.curTime = hours * 60 * 60 + minutes * 60 + seconds;

                worker.SetProgressBarValue(curTime);
                //SetProgressBarValue(curTime);

            }
            else if(e.Data.Contains("Duration:"))
            {
                string time = e.Data.Split(',')[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];

                int hours = Convert.ToInt32(time.Split(':')[0]);
                int minutes = Convert.ToInt32(time.Split(':')[1]);
                int seconds = Convert.ToInt32(time.Split(':')[2].Split('.')[0]);

                this.totalTime = hours * 60 * 60 + minutes * 60 + seconds;

                worker.WriteLine(e.Data);
                worker.SetMaxProgressBarValue(totalTime);
                //ConsoleWriteLine(e.Data);
                //SetMaxProgressBarValue(totalTime);
            }
            else
            {
                worker.WriteLine(e.Data);
                //ConsoleWriteLine(e.Data);
            }
        }



        public void Abort()
        {
          
            if(!process.HasExited)
             process.Kill();
        }

        ~VideoProcessor()
        {
            if (!process.HasExited)
                process.Kill();
        }

    }
}
