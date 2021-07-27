using FFMPEG_Wrapper.UserControls;
using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.Forms.MainWindow
{
    //creates file-reencode parameters bond
    public class FileManager
    {
        public class InputFile
        {
            string filePath;
            string fileName;
            string extension;
            int width, height, bitrate;
            InputVideoTemplate holder;
            string previewPath;
            bool selected;

            public InputFile(string path, InputVideoTemplate holder)
            {
                //set filePath
                filePath = path;

                ExtractNames();
                ExtractDimensions();
                ExtractImage();


                //set holder link
                this.holder = holder;
                holder.ApplyFileInfo(this);
                selected = false;
            }

            public string GetFilePath() {return filePath;}
            public string GetFileName() {return fileName; }
            public string GetFileExtention() {return extension; }
            public string GetFilePreviewPath() {return previewPath; }
            public int GetFileWidth() { return width; }
            public int GetFileHeight() { return height; }
            public int GetFileBitrate() { return bitrate; }
            public bool Selected { get{ return selected; } set{ selected = value; } }

            void ExtractImage()
            {
                //get video preview
                string framePath = $"{PreviewFolderPath}temp.jpg";
                string frameArgs = $"-i \"{filePath}\" -vf \"select=eq(n\\,{0})\" -vframes 1 {framePath}";
                CommandRunner.RunCommand(Config.Instance.FFMPEGPath, frameArgs);

                //scale=-1:108 ---->  -1 means autoSize, 108 - image height
                string resizedPath = $"{PreviewFolderPath}{Guid.NewGuid()}.jpg";
                string resizeArgs = $"-i \"{framePath}\" -vf scale=192:-1 {resizedPath}";
                CommandRunner.RunCommand(Config.Instance.FFMPEGPath, resizeArgs);

                previewPath = resizedPath;

                //delete initial frame
                File.Delete(framePath);

            }
            void ExtractNames()
            {
                //set file name and extension
                string[] split = filePath.Split('\\');
                string name = split[split.Length - 1];
                string ext = name.Split('.')[1];
                name = name.Split('.')[0];

                fileName = name;
                extension = ext;
            }
            void ExtractDimensions()
            {

                // get width/height
                string command = $"-v error -select_streams v:0 -show_entries stream=width,height -of csv=s=x:p=0 \"{filePath}\"";
                string dimensions = CommandRunner.RunCommand(Config.Instance.FFPROBEPath, command);

                width = Convert.ToInt32(dimensions.Split('x')[0]);
                height = Convert.ToInt32(dimensions.Split('x')[1]);

                //get bitrate
                string command2 = $"-v error -select_streams v:0 -show_entries stream=width,height,duration,bit_rate -of default=noprint_wrappers=1 \"{filePath}\"";
                string bitrate = CommandRunner.RunCommand(Config.Instance.FFPROBEPath, command2);

                //MessageBox.Show(bitrate);
                this.bitrate = Convert.ToInt32(bitrate.Split('\n')[3].Split('=')[1])/1024;
            }
            ~InputFile()
            {
                //delete preview pic
                try
                {
                    File.Delete(previewPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete preview pic {previewPath} \n\n Exception:\n {ex.Message} \n\n Stacktrace:\n {ex.StackTrace}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public static string TempFolderPath { get; } = Application.StartupPath + "\\temp\\";
        public static string PreviewFolderPath { get; } = Application.StartupPath + "\\temp\\preview\\";
        public static string DefaultSavePath { get; } = Application.StartupPath + "\\output\\";
        
        public static FileManager Instance { get { return instance; } }
        private static FileManager instance;

        public List<InputFile> CurrentFiles { get { return new List<InputFile>(currentFiles); } }
        List<InputFile> currentFiles = new List<InputFile>();

        public FileManager()
        {
            if (instance == null)
            {
                instance = this;
                CheckTempFolders();

            }
            else
                throw new Exception("FileManager instance alread y exists!!!");
        }

        //FFMPEG path + (some temp folders?)
        void CheckTempFolders()
        {
            //base temp folder
            if (!Directory.Exists(TempFolderPath))
                Directory.CreateDirectory(TempFolderPath);

            if (!Directory.Exists(PreviewFolderPath))
                Directory.CreateDirectory(PreviewFolderPath);

            if (!Directory.Exists(DefaultSavePath))
                Directory.CreateDirectory(DefaultSavePath);

            //delete all previews from temp folder if they exist (AND THEY CAN EXIST!!!)
            List<string> images = new List<string>(Directory.GetFiles(PreviewFolderPath, "*.jpg"));
            if (images.Count > 0)
                //delete all images
                for (int i = 0; i < images.Count; i++)
                    File.Delete(images[i]);
        }
        public void ProcessInputFiles(List<string> filePaths, List<InputVideoTemplate> templates)
        {
            for (int i = 0; i < filePaths.Count; i++)
            {
                InputFile newFile = new InputFile(filePaths[i], templates[i]);
                currentFiles.Add(newFile);
            }
        }



        public void RemoveFile(InputFile toDelete)
        {
            currentFiles.Remove(toDelete);
            toDelete = null;


            /* WHY USE GC??? i just can call a function to dispose...*/
            // MAYBE BECOUSE USER CAN EXIT APP WITHOUT DELETING FILES FROM LIST? A? A?
            // lol i'm crazy
            //force GC collect to call InputFileDestructors...
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


    }
}
