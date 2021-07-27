using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace FFMPEG_Wrapper
{

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            leftPanel.Init(editPanel, fileInputPanel,aboutPanel, settingsPanel, outputPanel, topPanel);
        }
        //start all workers
        private void ButtonStart_Click(object sender, EventArgs e)
        {

            /* UI REBUILD
           if (fileList.CheckedItems.Count < 1)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не выбраны файлы для обработки (должна стоять галочка)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           if (!config.SaveFolderValid)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не выбрана папка для вывода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           //todo: make some certain method to check if we have it
           if (!config.FFMPEGPathValid)// || !saveFolderSet || !ffmpegPath.Contains("ffmpeg"))
           {
               MessageBox.Show($"Не указан путь к ffmpeg.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }






           for (int i = 0; i < fileList.CheckedItems.Count; i++)
           {
               string[] splitName = fileList.CheckedItems[i].ToString().Split('\\');
               string originalName = splitName[splitName.Length - 1];
               originalName = originalName.Split('.')[0];

               VideoProcessor videoProcessor = new VideoProcessor
                   (
                   fileList.CheckedItems[i].ToString(),
                   config.SaveFolder,
                   $"{textPrefix.Text}{originalName}{textPostfix.Text}",
                   selectedCodec,
                   selectedACodec,
                   selectedPreset,
                   selectedExtension,
                   bitRate,
                   config.FFMPEGPath,
                   GetTargetWidth(),
                   GetTargetHeight(),
                   checkHFlip.Checked,
                   checkVFlip.Checked
                   );

               videoProcessor.onProcessExit += Converter_Exited;

               videoProcessor.StartProcessing();

               //threads++;
               // UpdateThreads();

           }

           */

        }

    }




}
