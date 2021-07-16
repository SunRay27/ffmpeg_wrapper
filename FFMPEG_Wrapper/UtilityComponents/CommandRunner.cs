using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UtilityComponents
{
    class CommandRunner
    {
        public static string RunCommand(string cmd, string args)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = cmd;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                if (output == string.Empty)
                    output = process.StandardError.ReadToEnd();

                if (!process.HasExited)
                    process.Kill();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run command: {cmd} {args} \n\n Exception:\n {ex.Message} \n\n Stacktrace:\n {ex.StackTrace}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex.Message;
            }
            
        }
    }
}
