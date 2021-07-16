using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FFMPEG_Wrapper
{




    public partial class WorkerForm : Form
    {
        VideoProcessor processor;
        public bool endedOperation = false;
        bool fromAbort = false;

        Stopwatch sw = new Stopwatch();

        int maxTime = 0;
        public WorkerForm(VideoProcessor videoProcessor)
        {
            processor = videoProcessor;
            InitializeComponent();
        }

        public void SetName(string name)
        {
            fileNameLabel.Invoke((MethodInvoker)(() => fileNameLabel.Text = name));
        }



        public void SetProgressBarValue(int value)
        {
            progressBar.Invoke((MethodInvoker)(() => progressBar.Value = value));

            //(TimeTaken / linesProcessed) * linesLeft = timeLeft
            TimeSpan elapsedSpan = sw.GetMinutes();
            TimeSpan leftSpan = sw.GetEta(value, maxTime);

            string elapsed = $"{String.Format("{0:00}", elapsedSpan.Hours)}:{String.Format("{0:00}", elapsedSpan.Minutes)}:{String.Format("{0:00}", elapsedSpan.Seconds)}";
            string left = $"{String.Format("{0:00}", leftSpan.Hours)}:{String.Format("{0:00}", leftSpan.Minutes)}:{String.Format("{0:00}", leftSpan.Seconds)}";
            labelEstimated.Invoke((MethodInvoker)(() => labelEstimated.Text = $"Time elapsed: {elapsed}     Time left: {left}"));

        }
        public void SetMaxProgressBarValue(int value)
        {
            progressBar.Invoke((MethodInvoker)(() => progressBar.Maximum = value));
            maxTime = value;
            sw.Start();
        }
        public void SetStatus(string status)
        {
           frameText.Invoke((MethodInvoker)(() => frameText.Text = status));
            
            //estimate
        }



        public void WriteLine(string line)
        {
            consoleText.Invoke((MethodInvoker)(() => consoleText.AppendText(line + Environment.NewLine)));
        }

        public void CompleteConversion()
        {
            abortButton.Invoke((MethodInvoker)(() => abortButton.Text = "Close"));
            endedOperation = true;

            SetProgressBarValue(progressBar.Maximum);

            if(!fromAbort)
                progressBar.Invoke((MethodInvoker)(() => progressBar.SetState(3)));
            else
                progressBar.Invoke((MethodInvoker)(() => progressBar.SetState(2)));
            // progressBar.Invoke((MethodInvoker)(() => progressBar.BackColor = Color.Yellow));

        }
        public void ShowOverwriteQuestion(string outputPath)
        {

        }
        public void abortButton_Click(object sender, EventArgs e)
        {
            if (endedOperation)
            {
                Close();
            }
            else
            {
                //abort...
                processor.Abort();
                progressBar.Value = progressBar.Maximum;
                fromAbort = true;
               // progressBar.BackColor = Color.Red;
            }
        }
    }
}
