using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FFMPEG_Overlay
{
    public class VideoProcessor
    {
        public enum VideoCodec { H264, H264_amd, H264_nvenc, H264_intel_qsv, H265, H265_nvenc, H265_amd, H265_intel_qsv, VP8, VP9, Copy };
        public enum AudioCodec { Copy, Vorbis, WavPack, MP3, Remove };
        public enum Preset { none, ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };
        public enum OutExtension { mp4, mkv };

        //in kb/s
        float bitRate = 0;

        string videoCodec = String.Empty;
        string audioCodec = String.Empty;
        string preset = String.Empty;

        string inputPath = String.Empty;
        string outputPath = String.Empty;

        int totalTime = 0;
        int curTime = 0;

        int targetWidth = -2;
        int targetHeight = -2;

        string flipAddon = string.Empty;

        WorkerForm worker;

        string ffmpegPath;

        Process process;


        bool overWriteAllowed = false;
        public Process Process { get { return process; } }

        //public DataReceivedEventHandler onProcessPrint;
        public EventHandler onProcessExit;

        void SetVideoCodecToString(VideoCodec codec)
        {
            switch (codec)
            {
                case VideoCodec.H264:
                    this.videoCodec = "libx264";
                    break;
                case VideoCodec.H264_amd:
                    this.videoCodec = "h264_amf";
                    break;
                case VideoCodec.H264_nvenc:
                    this.videoCodec = "h264_nvenc";
                    break;
                case VideoCodec.H264_intel_qsv:
                    this.videoCodec = "h264_qsv";
                    break;
                case VideoCodec.H265:
                    this.videoCodec = "libx265";
                    break;
                case VideoCodec.H265_nvenc:
                    this.videoCodec = "hevc_nvenc";
                    break;
                case VideoCodec.H265_amd:
                    this.videoCodec = "hevc_amf";
                    break;
                case VideoCodec.H265_intel_qsv:
                    this.videoCodec = "hevc_qsv";
                    break;
                case VideoCodec.VP8:
                    this.videoCodec = "libvpx";
                    break;
                case VideoCodec.VP9:
                    this.videoCodec = "libvpx-vp9";
                    break;
                case VideoCodec.Copy:
                    this.videoCodec = "copy";
                    break;
            }

        }
        void SetAudioCodecToString(AudioCodec codec)
        {
            switch (codec)
            {
                case AudioCodec.Copy:
                    audioCodec = "copy";
                    break;
                case AudioCodec.MP3:
                    audioCodec = "libmp3lame";
                    break;
                case AudioCodec.Vorbis:
                    audioCodec = "libvorbis";
                    break;
                case AudioCodec.WavPack:
                    audioCodec = "wavpack";
                    break;
                case AudioCodec.Remove:
                    audioCodec = "none";
                    break;
                default:
                    break;
            }
        }
        void SetPresetToString(Preset preset)
        {
            this.preset = preset.ToString();
        }
        public VideoProcessor(string inputPath, string outputFolder, string outName, VideoCodec codec, AudioCodec codec2, Preset preset, OutExtension ext, float bitrate, string ffmpegPath, int newWidth = -2, int newHeight = -2, bool hflip = false, bool vflip = false)
        {
            this.inputPath = inputPath;
            this.outputPath = $@"{outputFolder}\{outName}.{ext.ToString()}";
            this.bitRate = bitrate;
            this.targetHeight = newHeight;
            this.targetWidth = newWidth;
            this.ffmpegPath = ffmpegPath;

            if (hflip && vflip)
                flipAddon = "hflip,vflip,";
            else if (hflip)
                flipAddon = "hflip,";
            else if (vflip)
                flipAddon = "vflip,";

            SetVideoCodecToString(codec);
            SetAudioCodecToString(codec2);
            SetPresetToString(preset);

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }


        public void StartProcessing()
        {
            string command = $"-i \"{inputPath}\" -c:v {videoCodec}";
            if (flipAddon == string.Empty && targetWidth == -2 && targetHeight == -2)
            {
                command += $" -b:v {bitRate}M";
            }
            else
            {
                command += $" -vf \"{flipAddon}scale={targetWidth}:{targetHeight}\" -b:v {bitRate}M";
            }

            if (preset == "none")
            {
                if (audioCodec != "none")
                    command += $" -c:a {audioCodec} \"{outputPath}\"";
                else
                    command += $" -an \"{outputPath}\"";
            }
            else
            {
                if (audioCodec != "none")
                    command += $" -c:a {audioCodec} -preset {preset} \"{outputPath}\"";
                else
                    command += $" -an -preset {preset} \"{outputPath}\"";
            }

            process = new Process();
            process.StartInfo.FileName = ffmpegPath;


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
            process.OutputDataReceived += new DataReceivedEventHandler(InterceptOutputAndUpdateUI);
            process.ErrorDataReceived += new DataReceivedEventHandler(InterceptOutputAndUpdateUI);

            process.StartInfo.Arguments = $"{command}";


            process.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            process.StartInfo.StandardErrorEncoding = Encoding.GetEncoding(866);


            //open worker window
            worker = new WorkerForm(this);
            worker.Show();
            worker.SetName(outputPath);


            //check if we want to overwrite
            if (System.IO.File.Exists(outputPath))
            {
                var dialogResult = MessageBox.Show($"Файл {outputPath} уже существует. Перезаписать?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    overWriteAllowed = true;
                }
                else
                {
                    worker.abortButton_Click(this, null);
                    return;
                }
            }


            string helloString = "//*************************************************************************************************************//" + Environment.NewLine +
                                 "//*****WELOCOME TO MY SUPER DUPER FFMPEG WRAPPER REENCODING PROCESS!!!!!!!!!!!!!****//" + Environment.NewLine +
                                 "//*************************************************************************************************************//" + Environment.NewLine +

                                 $"{command}" + Environment.NewLine + Environment.NewLine;

            worker.WriteLine(helloString);

            //* Start process and handlers
            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            if (overWriteAllowed)
            {
                process.StandardInput.WriteLine("Y");
            }
            //process.WaitForExit();
        }


        void OnProcessExit(object sender, EventArgs e)
        {
            onProcessExit?.Invoke(sender, e);
            worker.CompleteConversion();
        }

        void InterceptOutputAndUpdateUI(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;


            if (e.Data.Contains("frame=") && e.Data.Contains("fps=") && e.Data.Contains("size=") && e.Data.Contains("time=") && e.Data.Contains("bitrate="))
            {
                //it is a status string
                worker.SetStatus(e.Data);

                this.curTime = 0;

                string time = e.Data.Split(new string[] { "time=", " bitrate=" }, StringSplitOptions.RemoveEmptyEntries)[1];

                int hours = Convert.ToInt32(time.Split(':')[0]);
                int minutes = Convert.ToInt32(time.Split(':')[1]);
                int seconds = Convert.ToInt32(time.Split(':')[2].Split('.')[0]);

                this.curTime = hours * 60 * 60 + minutes * 60 + seconds;

                worker.SetProgressBarValue(curTime);
                //SetProgressBarValue(curTime);

            }
            else if (e.Data.Contains("Duration:"))
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
            try
            {
                if (!process.HasExited)
                    process.Kill();
            }
            catch
            {

            }
        }

        ~VideoProcessor()
        {
            try
            {
                if (!process.HasExited)
                    process.Kill();
            }
            catch
            {

            }
        }

    }
}
