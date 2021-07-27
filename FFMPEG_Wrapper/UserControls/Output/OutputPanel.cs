using FFMPEG_Wrapper.Forms.MainWindow;
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
using static FFMPEG_Wrapper.Forms.MainWindow.FileManager;
using static FFMPEG_Wrapper.VideoProcessor;

namespace FFMPEG_Wrapper.UserControls.Output
{
    public partial class OutputPanel : UserControl
    {
        #region tips
        [Category("Tooltips")]
        public string VideoCodecTip{ get { return videoCodecTip; }set { videoCodecTip = value; Invalidate(); }}
        [Category("Tooltips")]
        public string PresetTip { get { return presetTip; } set { presetTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string BitrateTip { get { return bitrateTip; } set { bitrateTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string HeightTip { get { return heightTip; } set { heightTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string WidthTip { get { return widthTip; } set { widthTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string HorflipTip { get { return horflipTip; } set { horflipTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string VerflipTip { get { return verflipTip; } set { verflipTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string AudioCodecTip { get { return audioCodecTip; } set { audioCodecTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string ExtentionTip { get { return extentionTip; } set { extentionTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string PrefixTip { get { return prefixTip; } set { prefixTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string PostfixTip { get { return postfixTip; } set { postfixTip = value; Invalidate(); } }
        [Category("Tooltips")]
        public string AutoNamingTip { get { return autoNamingTip; } set { autoNamingTip = value; Invalidate(); } }

        string videoCodecTip;
        string presetTip;
        string bitrateTip;
        string heightTip;
        string widthTip;
        string horflipTip;
        string verflipTip;
        string audioCodecTip;
        string extentionTip;
        string prefixTip;
        string postfixTip;

        string autoNamingTip;

        private void SetupTips()
        {
            videocodecCombo.MouseEnter += (sender, e) => SetToolTipText(videoCodecTip);
            videoCodecLabel.MouseEnter += (sender, e) => SetToolTipText(videoCodecTip);

            presetCombo.MouseEnter += (sender, e) => SetToolTipText(presetTip);
            presetLabel.MouseEnter += (sender, e) => SetToolTipText(presetTip);

            bitrateLabel.MouseEnter += (sender, e) => SetToolTipText(bitrateTip);
            bitrateNumeric.MouseEnter += (sender, e) => SetToolTipText(bitrateTip);
            bitrateBox.MouseEnter += (sender, e) => SetToolTipText(bitrateTip);

            customHeightBox.MouseEnter += (sender, e) => SetToolTipText(heightTip);
            customHeightNumeric.MouseEnter += (sender, e) => SetToolTipText(heightTip);

            customWidthBox.MouseEnter += (sender, e) => SetToolTipText(widthTip);
            customWidthNumeric.MouseEnter += (sender, e) => SetToolTipText(widthTip);

            horFlipBox.MouseEnter += (sender, e) => SetToolTipText(horflipTip);
            verFlipBox.MouseEnter += (sender, e) => SetToolTipText(verflipTip);

            audioCodecCombo.MouseEnter += (sender, e) => SetToolTipText(audioCodecTip);
            audioCodecLabel.MouseEnter += (sender, e) => SetToolTipText(audioCodecTip);

            extentionCombo.MouseEnter += (sender, e) => SetToolTipText(extentionTip);
            extentionLabel.MouseEnter += (sender, e) => SetToolTipText(extentionTip);

            prefixBox.MouseEnter += (sender, e) => SetToolTipText(prefixTip);
            prefixLabel.MouseEnter += (sender, e) => SetToolTipText(prefixTip);

            postfixBox.MouseEnter += (sender, e) => SetToolTipText(postfixTip);
            postfixLabel.MouseEnter += (sender, e) => SetToolTipText(postfixTip);

            autoNamingBox.MouseEnter += (sender, e) => SetToolTipText(autoNamingTip);
        }
        private void SetToolTipText(string text)
        {
            tipTextBox.Text = text;
        }

        #endregion


        VideoProcessor.VideoCodec selectedVCodec;
        VideoProcessor.AudioCodec selectedACodec;
        VideoProcessor.Preset selectedPreset;
        VideoProcessor.OutExtension selectedExtension;
        float bitRate = 0;

        public OutputPanel()
        {
            InitializeComponent();
            SetupTips();
            SetUILinks();
            UpdateUI();
        }

        void SetUILinks()
        {
            videocodecCombo.DataSource = Enum.GetValues(typeof(VideoProcessor.VideoCodec));
            audioCodecCombo.DataSource = Enum.GetValues(typeof(VideoProcessor.AudioCodec));
            presetCombo.DataSource = Enum.GetValues(typeof(VideoProcessor.Preset));
            presetCombo.SelectedItem = VideoProcessor.Preset.medium;
            extentionCombo.DataSource = Enum.GetValues(typeof(VideoProcessor.OutExtension));
        }
        void UpdateUI()
        {
            customWidthBox_CheckedChanged(null, null);
            customHeightBox_CheckedChanged(null, null);
            autoNamingBox_CheckedChanged(null, null);
            bitrateBox_CheckedChanged(null, null);
            defaultSavePathBox_CheckedChanged(null, null);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
           // return;
            if(Visible)
            {
                int c = 0;
                for (int i = 0; i < FileManager.Instance.CurrentFiles.Count; i++)
                {
                    if (FileManager.Instance.CurrentFiles[i].Selected)
                        c++;
                }
                if (c > 0)
                {
                    startButton.Enabled = true;
                    startButton.Text = $"Process {c} file(s)...";
                }
                else
                {
                    startButton.Enabled = false;
                    startButton.Text = $"Select files in input tab to be able to start process...";
                }
            }
        }


        private void bitrateNumeric_ValueChanged(object sender, EventArgs e)
        {
            bitRate = (float)bitrateNumeric.Value / 1024f;
            bitrateHelperLabel.Text = $"{bitRate} Mbit/s";
        }

        private void customWidthBox_CheckedChanged(object sender, EventArgs e)
        {
            customWidthNumeric.Enabled = customWidthBox.Checked;
        }

        private void customHeightBox_CheckedChanged(object sender, EventArgs e)
        {
            customHeightNumeric.Enabled = customHeightBox.Checked;
        }

        private void autoNamingBox_CheckedChanged(object sender, EventArgs e)
        {
            prefixBox.Enabled = postfixBox.Enabled = !autoNamingBox.Checked;
        }

        private void bitrateBox_CheckedChanged(object sender, EventArgs e)
        {
            bitrateNumeric.Enabled = bitrateBox.Checked;
        }

        private void bitrateNumeric_Enter(object sender, EventArgs e)
        {
            bitRate = (float)bitrateNumeric.Value / 1024f;
            bitrateHelperLabel.Text = $"{bitRate} Mbit/s";
        }

        private void videocodecCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(videocodecCombo.SelectedItem.ToString(), out selectedVCodec);
        }

        private void presetCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(presetCombo.SelectedItem.ToString(), out selectedPreset);
        }

        private void audioCodecCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(audioCodecCombo.SelectedItem.ToString(), out selectedACodec);
        }

        private void extentionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(extentionCombo.SelectedItem.ToString(), out selectedExtension);
        }

        private void defaultSavePathBox_CheckedChanged(object sender, EventArgs e)
        {
            selectSavePathButton.Enabled = !defaultSavePathBox.Checked;

            if(defaultSavePathBox.Checked)
                savePathLabel.Text = FileManager.DefaultSavePath;

        }

        private void selectSavePathButton_Click(object sender, EventArgs e)
        {
            string folder = "";
            bool requestResult = Config.Instance.RequestFolder(out folder);
            if (requestResult)
                savePathLabel.Text = folder;
        }


        private void savePathLabel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(savePathLabel.Text))
                Process.Start(savePathLabel.Text);
        }

        public EncodeParameters GetEncodeParameters (InputFile file)
        {

            return new EncodeParameters(
                inputPath: file.GetFilePath(),
                outputFolder: savePathLabel.Text,
                outputName: autoNamingBox.Checked? $"{file.GetFileName()}_V{selectedVCodec}_A{selectedACodec}_{selectedPreset}" : $"{prefixBox.Texts}{file.GetFileName()}{postfixBox.Texts}",
                videoCodec: selectedVCodec,
                audioCodec: selectedACodec,
                preset: selectedPreset,
                extention: selectedExtension,
                bitrateBox.Checked ? bitRate : file.GetFileBitrate()/1024f,
                width: customWidthBox.Checked ? (int)customWidthNumeric.Value : -2,
                heigh: customHeightBox.Checked ? (int)customHeightNumeric.Value : -2,
                horizontalFlip: horFlipBox.Checked,
                verticalFlip: verFlipBox.Checked
                );
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileManager.Instance.CurrentFiles.Count; i++)
            {
                VideoProcessor videoProcessor = new VideoProcessor(GetEncodeParameters(FileManager.Instance.CurrentFiles[i]));
                videoProcessor.onProcessExit += OnWorkerExited;
                videoProcessor.StartProcessing();
            }
        }
        private void OnWorkerExited(object sender, EventArgs e)
        {

        }
    }
}
