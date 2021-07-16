
namespace FFMPEG_Wrapper.UserControls
{
    partial class InputVideoTemplate
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputVideoTemplate));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.fileFormat = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.PictureBox();
            this.checkBox = new FFMPEG_Wrapper.Forms.FormUtils.BigCheckBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.mainPanel.Controls.Add(this.buttonRemove);
            this.mainPanel.Controls.Add(this.checkBox);
            this.mainPanel.Controls.Add(this.fileFormat);
            this.mainPanel.Controls.Add(this.fileName);
            this.mainPanel.Controls.Add(this.preview);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(194, 188);
            this.mainPanel.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(169, 163);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(25, 25);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // fileFormat
            // 
            this.fileFormat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileFormat.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.fileFormat.ForeColor = System.Drawing.Color.White;
            this.fileFormat.Location = new System.Drawing.Point(0, 165);
            this.fileFormat.Name = "fileFormat";
            this.fileFormat.Size = new System.Drawing.Size(194, 23);
            this.fileFormat.TabIndex = 2;
            this.fileFormat.Text = "1920x1080 .mp4";
            this.fileFormat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // fileName
            // 
            this.fileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.fileName.ForeColor = System.Drawing.Color.White;
            this.fileName.Location = new System.Drawing.Point(0, 105);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(194, 83);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "FILE_NAME_really long filename to test these stupid labels and auto size settings" +
    " just in case lol";
            this.fileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preview
            // 
            this.preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview.BackgroundImage")));
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.preview.Dock = System.Windows.Forms.DockStyle.Top;
            this.preview.InitialImage = null;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(194, 105);
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.checkBox.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.checkBox.BoxLocationX = 0;
            this.checkBox.BoxLocationY = 0;
            this.checkBox.BoxSize = 24;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Location = new System.Drawing.Point(3, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(25, 25);
            this.checkBox.TabIndex = 3;
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox.TextLocationX = 16;
            this.checkBox.TextLocationY = 1;
            this.checkBox.TickColor = System.Drawing.Color.LimeGreen;
            this.checkBox.TickLeftPosition = 0F;
            this.checkBox.TickSize = 21F;
            this.checkBox.TickTopPosition = 0F;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // InputVideoTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.mainPanel);
            this.Name = "InputVideoTemplate";
            this.Size = new System.Drawing.Size(200, 194);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label fileFormat;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.PictureBox preview;
        private Forms.FormUtils.BigCheckBox checkBox;
        private System.Windows.Forms.Button buttonRemove;
    }
}
