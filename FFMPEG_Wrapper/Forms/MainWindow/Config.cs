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
        //public string SaveFolder { get { return savePath; } set { savePath = value; } }
        public string FFMPEGPath { get { return ffmpegPath; } set { ffmpegPath = value; } }
        public string FFPROBEPath { get { return ffprobePath; } set { ffprobePath = value; } }


        public static Config Instance { get { return instance; } }
        private static Config instance;


        //private string savePath = String.Empty;
        private string ffmpegPath = String.Empty;
        private string ffprobePath = String.Empty;


        public bool FFMPEGPathValid
        {
            get { return IsFFMPEGPathValid(ffmpegPath); }
        }
        public bool FFPROBEPathValid
        {
            get { return IsFFPROBEPathValid(ffprobePath); }
        }

        public Config()
        {
            if (instance == null)
                instance = this;
            else
                throw new Exception("Config instance alread y exists!!!");
        }

        public void Load()
        {
            AllPathsExist();
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

            Load();
        }
        public bool AllPathsExist()
        {
            bool result = true;

            if (!FFMPEGPathValid)
            {
                MessageBox.Show($"Не выбран ffmpeg.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (!FFPROBEPathValid)
            {
                MessageBox.Show($"Не выбран ffprobe.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        public bool RequestFFMPEG()
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;

            fileSelect.Filter = "ffmpeg |*.exe;";
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {

                if (IsFFMPEGPathValid(fileSelect.FileName))
                {
                    ffmpegPath = fileSelect.FileName;
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

        public bool RequestFFPROBE()
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;

            fileSelect.Filter = "ffprobe |*.exe;";
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {

                if (IsFFPROBEPathValid(fileSelect.FileName))
                {
                    ffprobePath = fileSelect.FileName;
                    XMLSerializer.Save(Config.ConfigFileName, this);
                    return true;
                }
                else
                {
                    bool retryResult = false;

                    var Result = MessageBox.Show($"Файл не прошёл проверку: может это не ffprobe?", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (Result == DialogResult.Retry)
                        retryResult = RequestFFPROBE();

                    return retryResult;
                }
            }
            else
                return false;
        }

        public bool RequestFolder(out string path)
        {
            FolderBrowserDialog saveFile = new FolderBrowserDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.SelectedPath;
                return true;

            }
            else
            {
                path = "";
                return false;
            }
        }


        bool IsFFMPEGPathValid(string ffmpegPath)
        {
            bool result = false;
            if(File.Exists(ffmpegPath))
           // if (Directory.Exists(ffmpegPath.Replace("\\ffmpeg.exe", "")))
                //if (ffmpegPath.Contains("ffmpeg.exe"))
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
            if (File.Exists(ffprobePath))
               // if (Directory.Exists(ffprobePath.Replace("\\ffprobe.exe", "")))
               // if (ffprobePath.Contains("ffprobe.exe"))
                {
                    string message = CommandRunner.RunCommand(ffprobePath, "");

                    if (message.Contains("ffprobe version"))
                        result = true;
                }


            return result;
        }
    }
}
