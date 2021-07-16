using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFMPEG_Overlay.Forms.MainWindow
{
    [Serializable]
    public class Config
    {
        public static string ConfigFileName { get; } = "config";
        public string SaveFolder { get { return savePath; } }
        public string FFMPEGPath { get { return ffmpegPath; } }

        private string savePath = String.Empty;
        private string ffmpegPath = String.Empty;

        public bool SaveFolderValid
        {
            get { return Directory.Exists(savePath); }
        }
        public bool FFMPEGPathValid
        {
            get { return IsFFMPEGPathValid(ffmpegPath); }
        }


        //called if config file doesn't exist
        public void Init()
        {
            // try to find ffmpeg in root folder
            string possiblePath = $"{Application.StartupPath}\\ffmpeg.exe";

            if (IsFFMPEGPathValid(possiblePath))
                ffmpegPath = possiblePath;

            XMLSerializer.Save("config", this);
        }
        public bool AllPathsExist()
        {
            bool result = true;
            if (!SaveFolderValid)
            {
                MessageBox.Show($"Не выбрана папка для вывода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (!FFMPEGPathValid)
            {
                MessageBox.Show($"Не выбран ffmpeg.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        public bool RequestFFMPEG()
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;

            fileSelect.Filter = "ffmpeg.exe |*.exe;";
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                ffmpegPath = fileSelect.FileName;
                if (FFMPEGPathValid)
                {
                    XMLSerializer.Save(Config.ConfigFileName, this);
                    return true;
                }
                else
                {
                    bool retryResult = false;

                    var Result = MessageBox.Show($"Файл не прошёл проверку: может это не ffmpeg?", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (Result == DialogResult.Retry)
                        retryResult = RequestFFMPEG();

                    return retryResult;
                }
            }
            else
                return false;
        }

        public bool RequestSaveFolder()
        {
            FolderBrowserDialog saveFile = new FolderBrowserDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFile.SelectedPath;

                if (SaveFolderValid)
                {
                    XMLSerializer.Save(Config.ConfigFileName, this);
                    return true;
                }
                else
                {
                    bool retryResult = false;
                    var Result = MessageBox.Show($"Некорректный путь - содержит кириллицу", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (Result == DialogResult.Retry)
                        retryResult = RequestSaveFolder();
                    return retryResult;
                }

            }
            else
                return false;
        }


        bool IsFFMPEGPathValid(string ffmpegPath)
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

                    if (!process.HasExited)
                        process.Kill();
                }
                catch
                { }
            }


            return result;
        }


    }
}
