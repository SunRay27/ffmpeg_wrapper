namespace FFMPEG_Wrapper
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.aboutPanel = new FFMPEG_Wrapper.UserControls.About.AboutPanel();
            this.settingsPanel = new FFMPEG_Wrapper.UserControls.Settings.SettingsPanel();
            this.outputPanel = new FFMPEG_Wrapper.UserControls.Output.OutputPanel();
            this.editPanel = new FFMPEG_Wrapper.UserControls.EditPanel();
            this.fileInputPanel = new FFMPEG_Wrapper.UserControls.FileInputPanel();
            this.leftPanel = new FFMPEG_Wrapper.UserControls.LeftPanel();
            this.topPanel = new FFMPEG_Wrapper.UserControls.MainWindow.TopPanel();
            this.SuspendLayout();
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel.Location = new System.Drawing.Point(79, 72);
            this.aboutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(1181, 605);
            this.aboutPanel.TabIndex = 28;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(79, 72);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1181, 605);
            this.settingsPanel.TabIndex = 26;
            // 
            // outputPanel
            // 
            this.outputPanel.AudioCodecTip = "You can select different audio codec to reencode audio";
            this.outputPanel.AutoNamingTip = "If this option is enabled, output files will be named according to selected reenc" +
    "oding options";
            this.outputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.outputPanel.BitrateTip = "Leave this disabled if you don\'t want to change original bit rate";
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.ExtentionTip = "Output video new extention";
            this.outputPanel.HeightTip = "Enable this to change video height.\\n Important! If you change only width/height " +
    "of the video, the other dimension will be changed according to aspect ratio";
            this.outputPanel.HorflipTip = "Flip video horizontally";
            this.outputPanel.Location = new System.Drawing.Point(79, 72);
            this.outputPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.PostfixTip = "Postfix that will be added to output video name";
            this.outputPanel.PrefixTip = "Prefix that will be added to output video name";
            this.outputPanel.PresetTip = "Select codec preset, Slower preset - better quality and much longer reencoding ti" +
    "me";
            this.outputPanel.Size = new System.Drawing.Size(1181, 605);
            this.outputPanel.TabIndex = 25;
            this.outputPanel.VerflipTip = "Flip video vertically";
            this.outputPanel.VideoCodecTip = "You can select different video codec to reencode video";
            this.outputPanel.WidthTip = "Enable this to change video width.\\n Important! If you change only width/height o" +
    "f the video, the other dimension will be changed according to aspect ratio";
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(79, 72);
            this.editPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1181, 605);
            this.editPanel.TabIndex = 22;
            // 
            // fileInputPanel
            // 
            this.fileInputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.fileInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInputPanel.Location = new System.Drawing.Point(79, 72);
            this.fileInputPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileInputPanel.Name = "fileInputPanel";
            this.fileInputPanel.Size = new System.Drawing.Size(1181, 605);
            this.fileInputPanel.TabIndex = 15;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 72);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(79, 605);
            this.leftPanel.TabIndex = 21;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1260, 72);
            this.topPanel.TabIndex = 24;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.fileInputPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFMPEG wrapper";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.FileInputPanel fileInputPanel;
        private UserControls.LeftPanel leftPanel;
        private UserControls.EditPanel editPanel;
        private UserControls.MainWindow.TopPanel topPanel;
        private UserControls.Output.OutputPanel outputPanel;
        private UserControls.Settings.SettingsPanel settingsPanel;
        private UserControls.About.AboutPanel aboutPanel;
    }
}

