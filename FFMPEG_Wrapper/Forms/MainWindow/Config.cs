using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.Forms.MainWindow
{
    [Serializable]
    public class Config
    {
        public static string ConfigFileName { get; } = "config";
        public string SaveFolder { get { return savePath; } set { savePath = value; } }
        public string FFMPEGPath { get { return ffmpegPath; } set { ffmpegPath = value; } }
        public string FFPROBEPath { get { return ffprobePath; } set { ffprobePath = value; } }


        public static Config Instance { get { return instance; } }
        private static Config instance;


        private string savePath = String.Empty;
        private string ffmpegPath = String.Empty;
        private string ffprobePath = String.Empty;

        public bool SaveFolderValid
        {
            get { return Directory.Exists(savePath); }
        }
        public bool FFMPEGPathValid
        {
            get { return IsFFMPEGPathValid(ffmpegPath); }
        }
        public bool FFPROBEPathValid
        {
            get { return IsFFMPEGPathValid(ffmpegPath); }
        }

        public Config()
        {
            if (instance == null)
                instance = this;
            else
                throw new Exception("Config instance alread y exists!!!");
        }

        //called if config file doesn't exist
        public void Init()
        {
            // try to find ffmpeg in root folder
            string possiblePath = $"{Application.StartupPath}\\ffmpeg.exe";

            if (IsFFMPEGPathValid(possiblePath))
                ffmpegPath = possiblePath;

            // try to find ffprobe in root folder
            string possiblePath2 = $"{Application.StartupPath}\\ffprobe.exe";

            if (IsFFPROBEPathValid(possiblePath2))
                ffprobePath = possiblePath2;

            XMLSerializer.Save("config", instance);
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
                string message = CommandRunner.RunCommand(ffmpegPath, "");
                if (message.Contains("ffmpeg version"))
                    result = true;
            }


            return result;
        }

        bool IsFFPROBEPathValid(string ffprobePath)
        {
            bool result = false;

            if (ffprobePath.Contains("ffprobe.exe"))
            {
                string message = CommandRunner.RunCommand(ffprobePath, "");

                if (message.Contains("ffprobe version"))
                    result = true;
            }


            return result;
        }
    }
}
