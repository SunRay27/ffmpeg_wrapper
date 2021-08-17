
namespace FFMPEG_Wrapper.Forms.Worker
{
    partial class VideoProcessLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoProcessLabel));
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.videoLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusPicture = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.openVideoPic = new System.Windows.Forms.PictureBox();
            this.OpenFolderPic = new System.Windows.Forms.PictureBox();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openVideoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFolderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 5;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.layout.Controls.Add(this.OpenFolderPic, 0, 0);
            this.layout.Controls.Add(this.openVideoPic, 0, 0);
            this.layout.Controls.Add(this.videoLabel, 0, 0);
            this.layout.Controls.Add(this.statusPicture, 4, 0);
            this.layout.Controls.Add(this.statusLabel, 3, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.layout.Size = new System.Drawing.Size(502, 41);
            this.layout.TabIndex = 2;
            // 
            // videoLabel
            // 
            this.videoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoLabel.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.videoLabel.ForeColor = System.Drawing.Color.White;
            this.videoLabel.Location = new System.Drawing.Point(3, 0);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(265, 41);
            this.videoLabel.TabIndex = 0;
            this.videoLabel.Text = "sample_video.mp4 idusbhgo8u45h9gufirnfp9i4u5gh049iufn43kmfpo45uhg94uigjok4mtg";
            this.videoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(360, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(96, 41);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "In progress...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusPicture
            // 
            this.statusPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusPicture.BackgroundImage")));
            this.statusPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statusPicture.Location = new System.Drawing.Point(462, 3);
            this.statusPicture.Name = "statusPicture";
            this.statusPicture.Size = new System.Drawing.Size(36, 35);
            this.statusPicture.TabIndex = 2;
            this.statusPicture.TabStop = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel.Controls.Add(this.layout);
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(502, 41);
            this.panel.TabIndex = 3;
            // 
            // openVideoPic
            // 
            this.openVideoPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openVideoPic.BackgroundImage")));
            this.openVideoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openVideoPic.Location = new System.Drawing.Point(274, 3);
            this.openVideoPic.Name = "openVideoPic";
            this.openVideoPic.Size = new System.Drawing.Size(35, 35);
            this.openVideoPic.TabIndex = 3;
            this.openVideoPic.TabStop = false;
            this.openVideoPic.Click += new System.EventHandler(this.openVideoPic_Click);
            // 
            // OpenFolderPic
            // 
            this.OpenFolderPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFolderPic.BackgroundImage")));
            this.OpenFolderPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFolderPic.Location = new System.Drawing.Point(317, 3);
            this.OpenFolderPic.Name = "OpenFolderPic";
            this.OpenFolderPic.Size = new System.Drawing.Size(35, 35);
            this.OpenFolderPic.TabIndex = 4;
            this.OpenFolderPic.TabStop = false;
            this.OpenFolderPic.Click += new System.EventHandler(this.OpenFolderPic_Click);
            // 
            // VideoProcessLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(136F, 136F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Crimson;
            this.Controls.Add(this.panel);
            this.Name = "VideoProcessLabel";
            this.Size = new System.Drawing.Size(508, 47);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openVideoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFolderPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox statusPicture;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox OpenFolderPic;
        private System.Windows.Forms.PictureBox openVideoPic;
    }
}
