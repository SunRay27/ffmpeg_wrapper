using FFMPEG_Wrapper.Forms.MainWindow;
using FFMPEG_Wrapper.Forms.Worker;
using FFMPEG_Wrapper.VideoComponents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FFMPEG_Wrapper
{
    public partial class WorkerForm : Form
    {
        List<VideoProcess> recoders;
        List<VideoProcessLabel> recodeLabels;
        EventHandler onProcessExit;
        Process currentProcess;
        int processesFinished = 0;


        public bool endedOperation = false;
        bool fromAbort = false;


        Stopwatch sw = new Stopwatch();
        int curTime = 0;
        int maxTime = 0;

        public WorkerForm(List<VideoProcess> videoProcessors)
        {
            recoders = videoProcessors;
            InitializeComponent();
        }

        public void Start()
        {
            progress.Invoke((MethodInvoker)(() => progress.Refresh()));

            //create recoders bars
            recodeLabels = new List<VideoProcessLabel>();
            for (int i = 0; i < recoders.Count; i++)
            {
                VideoProcessLabel newLabel = new VideoProcessLabel();
                newLabel.Parent = flowLayoutPanel1;

                if(recoders[i] is VideoRecoder)
                    newLabel.Start($"{(recoders[i] as VideoRecoder).EncodeParameters.OutputName}.{(recoders[i] as VideoRecoder).EncodeParameters.Extension}", (recoders[i] as VideoRecoder).EncodeParameters.OutputPath, (recoders[i] as VideoRecoder).EncodeParameters.OutputFolder);
                else if (recoders[i] is VideoConcatenator)
                    newLabel.Start($"{(recoders[i] as VideoConcatenator).ConcatParameters.OutputName}.{(recoders[i] as VideoConcatenator).ConcatParameters.Extension}", (recoders[i] as VideoConcatenator).ConcatParameters.OutputPath, (recoders[i] as VideoConcatenator).ConcatParameters.OutputFolder);
                recodeLabels.Add(newLabel);
            }
            //execute first
            Execute(recoders[0]);
        }
        void Execute(VideoProcess recoder)
        {
            //set process parameters
            currentProcess = new Process();
            currentProcess.StartInfo.Arguments = recoder.Command;
            currentProcess.StartInfo.FileName = Config.Instance.FFMPEGPath;

            currentProcess.EnableRaisingEvents = true;
            currentProcess.StartInfo.UseShellExecute = false;
            currentProcess.StartInfo.CreateNoWindow = true;
            currentProcess.StartInfo.RedirectStandardInput = true;
            currentProcess.StartInfo.RedirectStandardOutput = true;
            currentProcess.StartInfo.RedirectStandardError = true;

            currentProcess.Exited += OnProcessExit;
            currentProcess.OutputDataReceived += new DataReceivedEventHandler(InterceptOutputAndUpdateUI);
            currentProcess.ErrorDataReceived += new DataReceivedEventHandler(InterceptOutputAndUpdateUI);

            currentProcess.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            currentProcess.StartInfo.StandardErrorEncoding = Encoding.GetEncoding(866);

            //set worker header label
            SetName(recoder.OutputPath.Split('\\')[recoder.OutputPath.Split('\\').Length-1]);
            recodeLabels[processesFinished].Invoke((MethodInvoker)(() => recodeLabels[processesFinished].UpdateStatus(VideoProcessLabel.VideoRecodeStatus.InProgress)));

            //check if we want to overwrite output
            bool overWriteAllowed = false;

            if (System.IO.File.Exists(recoder.OutputPath))
            {
                overWriteAllowed = true;
                /*
                var dialogResult = MessageBox.Show($"File {recoder.OutputPath} already exists. Rewrite?", "Do it? or not?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    overWriteAllowed = true;
                }
                else
                {
                    abortButton_Click(this, null);
                    //abortButton.Invoke((MethodInvoker)(() => abortButton.Text = "Close"));
                    this.Invoke((MethodInvoker)(() => Close()));
                    //Close();
                    return;
                }
                */
            }


            string header =      "+-----------------------------------------------------------------------------------------------------------------------------------+\n" +
                                 "|-----------------------------------------------------------------------------------------------------------------------------------|\n" +
                                 "|----------------Starting new ffmpeg.exe instance with parameters...------------------------------------|\n" +
                                 "|-----------------------------------------------------------------------------------------------------------------------------------|\n" +
                                 "+-----------------------------------------------------------------------------------------------------------------------------------+\n";

            string command = $"{recoder.Command}" + Environment.NewLine + Environment.NewLine;

            WriteLine(header, Color.Black, Color.White);
            WriteLine(command, Color.Lime);

            //* Start process and handlers
            currentProcess.Start();

            currentProcess.BeginOutputReadLine();
            currentProcess.BeginErrorReadLine();

            if (overWriteAllowed)
            {
                currentProcess.StandardInput.WriteLine("Y");
            }
        }

        

         void OnProcessExit(object sender, EventArgs e)
        {
           // MessageBox.Show(currentProcess.ExitCode.ToString());
            if (currentProcess.ExitCode > 0)
            {
                //some problems...
                recodeLabels[processesFinished].Invoke((MethodInvoker)(() => recodeLabels[processesFinished].UpdateStatus(VideoProcessLabel.VideoRecodeStatus.Error)));
            }
            else if(currentProcess.ExitCode == 0)
            {
                //ok!
                recodeLabels[processesFinished].Invoke((MethodInvoker)(() => recodeLabels[processesFinished].UpdateStatus(VideoProcessLabel.VideoRecodeStatus.Finished)));
            }
            else
            {
                recodeLabels[processesFinished].Invoke((MethodInvoker)(() => recodeLabels[processesFinished].UpdateStatus(VideoProcessLabel.VideoRecodeStatus.Aborted)));
            }

            //?????? onProcessExit?.Invoke(sender, e);
            processesFinished++;
            if (recoders.Count > processesFinished)
            {


                Execute(recoders[processesFinished]);
            }
            else
            {
                CompleteConversion();
            }
        }
         void CompleteConversion()
        {
            abortButton.Invoke((MethodInvoker)(() => abortButton.Text = "Close"));
            endedOperation = true;

            SetProgressBarValue(progress.Maximum);

            if (!fromAbort)
            {
                progress.Invoke((MethodInvoker)(() => progress.SliderColor = System.Drawing.Color.Crimson));
                progress.Invoke((MethodInvoker)(() => progress.Refresh()));
            }
            else
            {
                progress.Invoke((MethodInvoker)(() => progress.SliderColor = System.Drawing.Color.Yellow));
                progress.Invoke((MethodInvoker)(() => progress.Refresh()));
            }
        }

         void Abort()
        {
            try
            {
                if (!currentProcess.HasExited)
                {
                    //currentProcess.StandardInput.WriteLine("q");
                    currentProcess.Kill();
                }
            }
            catch
            {

            }
        }
         void abortButton_Click(object sender, EventArgs e)
        {
            if (endedOperation)
            {
                Close();
            }
            else
            {
                Abort();


                progress.Value = progress.Maximum;
                fromAbort = true;
            }
        }



         void SetProgressBarValue(int value)
        {
            if (value <= progress.Maximum)
            {
                progress.Invoke((MethodInvoker)(() => progress.Value = value));
                progress.Invoke((MethodInvoker)(() => progress.Refresh()));
            }

            //(TimeTaken / linesProcessed) * linesLeft = timeLeft
            TimeSpan elapsedSpan = sw.GetMinutes();
            TimeSpan leftSpan = sw.GetEta(value, maxTime);

            string elapsed = $"{String.Format("{0:00}", elapsedSpan.Hours)}:{String.Format("{0:00}", elapsedSpan.Minutes)}:{String.Format("{0:00}", elapsedSpan.Seconds)}";
            string left = $"{String.Format("{0:00}", leftSpan.Hours)}:{String.Format("{0:00}", leftSpan.Minutes)}:{String.Format("{0:00}", leftSpan.Seconds)}";
            labelEstimated.Invoke((MethodInvoker)(() => labelEstimated.Text = $"Time elapsed: {elapsed}     Time left: {left}"));

        }
         void SetMaxProgressBarValue(int value)
        {
            progress.Invoke((MethodInvoker)(() => progress.Maximum = value));
            progress.Invoke((MethodInvoker)(() => progress.Value = progress.Minimum));
            progress.Invoke((MethodInvoker)(() => progress.Refresh()));
            maxTime = value;
            sw.Start();
        }
         void InterceptOutputAndUpdateUI(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;


            if (e.Data.Contains("frame=") && e.Data.Contains("fps=") && e.Data.Contains("size=") && e.Data.Contains("time=") && e.Data.Contains("bitrate="))
            {
                //it is a status string
                SetStatus(e.Data);

                this.curTime = 0;

                string time = e.Data.Split(new string[] { "time=", " bitrate=" }, StringSplitOptions.RemoveEmptyEntries)[1];

                int hours = Convert.ToInt32(time.Split(':')[0]);
                int minutes = Convert.ToInt32(time.Split(':')[1]);
                int seconds = Convert.ToInt32(time.Split(':')[2].Split('.')[0]);
                int mseconds = Convert.ToInt32(time.Split(':')[2].Split('.')[1]);

                this.curTime = hours * 60 * 60 * 100 + minutes * 60 * 100 + seconds * 100 + mseconds;

                SetProgressBarValue(curTime);
                //SetProgressBarValue(curTime);

            }
            else if (e.Data.Contains("Duration:"))
            {
                try
                {
                    string time = e.Data.Split(',')[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];

                    int hours = Convert.ToInt32(time.Split(':')[0]);
                    int minutes = Convert.ToInt32(time.Split(':')[1]);
                    int seconds = Convert.ToInt32(time.Split(':')[2].Split('.')[0]);
                    int mseconds = Convert.ToInt32(time.Split(':')[2].Split('.')[1]);

                    int totalTime = hours * 60 * 60 * 100 + minutes * 60 * 100 + seconds * 100 + mseconds;


                    WriteLine(e.Data, Color.White);
                    SetMaxProgressBarValue(totalTime);
                    //ConsoleWriteLine(e.Data);
                    //SetMaxProgressBarValue(totalTime);
                }
                catch
                { 
                }
            }
            else if (e.Data.ToLower().Contains("configuration: --enable-gpl "))
            {

            }
            else if (e.Data.ToLower().Contains("unable") || e.Data.ToLower().Contains("error") || e.Data.ToLower().Contains("undefined") || e.Data.ToLower().Contains("failed") || e.Data.ToLower().Contains("could not ") || e.Data.ToLower().Contains("no such file or directory"))
            {
                WriteLine(e.Data, Color.Red);
            }
            else if(e.Data.Contains("lib") || e.Data.Contains("input") || e.Data.Contains("output") || e.Data.Contains("hevc") || e.Data.Contains("h264") || e.Data.Contains("x265") || e.Data.Contains("vp9") || e.Data.Contains("vp8"))
            {
                WriteLine(e.Data, Color.Cyan);
            }
            else
            {
                WriteLine(e.Data, Color.White);
                //ConsoleWriteLine(e.Data);
            }
        }



        void WriteLine(string line, Color drawColor)
        {
            consoleText.Invoke((MethodInvoker)(() => consoleText.AppendText(line + '\n')));

            //Thread.Sleep(200);



            // int len = (line.Length - (line.Split('\n').Length + 1));
            // int startPos = consoleText.TextLength - len;


            consoleText.Invoke((MethodInvoker)(() => consoleText.Select(consoleText.TextLength - line.Length - 1, (line.Length))));
            consoleText.Invoke((MethodInvoker)(() => consoleText.SelectionColor = drawColor));
        }

        void WriteLine(string line, Color drawColor, Color backColor)
        {
            consoleText.Invoke((MethodInvoker)(() => consoleText.AppendText(line + '\n')));

            //Thread.Sleep(200);



            // int len = (line.Length - (line.Split('\n').Length + 1));
            // int startPos = consoleText.TextLength - len;


            consoleText.Invoke((MethodInvoker)(() => consoleText.Select(consoleText.TextLength - line.Length - 1, (line.Length))));
            consoleText.Invoke((MethodInvoker)(() => consoleText.SelectionColor = drawColor));
            consoleText.Invoke((MethodInvoker)(() => consoleText.SelectionBackColor = backColor));
        }








        void SetName(string name)
        {
            fileNameLabel.Invoke((MethodInvoker)(() => fileNameLabel.Text = name));
        }
         void SetStatus(string status)
        {
            frameText.Invoke((MethodInvoker)(() => frameText.Text = status));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
