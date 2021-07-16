
namespace FFMPEG_Wrapper.UserControls
{
    partial class FileInputPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInputPanel));
            this.dropPanel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.fileTable = new System.Windows.Forms.FlowLayoutPanel();
            this.inputVideoTemplate1 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate2 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate3 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate4 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate5 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate6 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate7 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate8 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate9 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate10 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate11 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.inputVideoTemplate12 = new FFMPEG_Wrapper.UserControls.InputVideoTemplate();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dropPanel.SuspendLayout();
            this.fileTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BackColor = System.Drawing.Color.Transparent;
            this.dropPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dropPanel.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dropPanel.BorderRadius = 25;
            this.dropPanel.BorderWidth = 5F;
            this.dropPanel.Controls.Add(this.fileTable);
            this.dropPanel.Controls.Add(this.pictureBox1);
            this.dropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.dropPanel.Location = new System.Drawing.Point(0, 0);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.OffsetX = 40;
            this.dropPanel.OffsetY = 40;
            this.dropPanel.Size = new System.Drawing.Size(987, 531);
            this.dropPanel.TabIndex = 1;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            this.dropPanel.DragLeave += new System.EventHandler(this.dropPanel_DragLeave);
            // 
            // fileTable
            // 
            this.fileTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTable.AutoScroll = true;
            this.fileTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.fileTable.Controls.Add(this.inputVideoTemplate1);
            this.fileTable.Controls.Add(this.inputVideoTemplate2);
            this.fileTable.Controls.Add(this.inputVideoTemplate3);
            this.fileTable.Controls.Add(this.inputVideoTemplate4);
            this.fileTable.Controls.Add(this.inputVideoTemplate5);
            this.fileTable.Controls.Add(this.inputVideoTemplate6);
            this.fileTable.Controls.Add(this.inputVideoTemplate7);
            this.fileTable.Controls.Add(this.inputVideoTemplate8);
            this.fileTable.Controls.Add(this.inputVideoTemplate9);
            this.fileTable.Controls.Add(this.inputVideoTemplate10);
            this.fileTable.Controls.Add(this.inputVideoTemplate11);
            this.fileTable.Controls.Add(this.inputVideoTemplate12);
            this.fileTable.Location = new System.Drawing.Point(62, 55);
            this.fileTable.Margin = new System.Windows.Forms.Padding(0);
            this.fileTable.Name = "fileTable";
            this.fileTable.Size = new System.Drawing.Size(860, 415);
            this.fileTable.TabIndex = 0;
            // 
            // inputVideoTemplate1
            // 
            this.inputVideoTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate1.Location = new System.Drawing.Point(3, 3);
            this.inputVideoTemplate1.Name = "inputVideoTemplate1";
            this.inputVideoTemplate1.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate1.TabIndex = 0;
            // 
            // inputVideoTemplate2
            // 
            this.inputVideoTemplate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate2.Location = new System.Drawing.Point(209, 3);
            this.inputVideoTemplate2.Name = "inputVideoTemplate2";
            this.inputVideoTemplate2.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate2.TabIndex = 1;
            // 
            // inputVideoTemplate3
            // 
            this.inputVideoTemplate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate3.Location = new System.Drawing.Point(415, 3);
            this.inputVideoTemplate3.Name = "inputVideoTemplate3";
            this.inputVideoTemplate3.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate3.TabIndex = 2;
            // 
            // inputVideoTemplate4
            // 
            this.inputVideoTemplate4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate4.Location = new System.Drawing.Point(621, 3);
            this.inputVideoTemplate4.Name = "inputVideoTemplate4";
            this.inputVideoTemplate4.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate4.TabIndex = 3;
            // 
            // inputVideoTemplate5
            // 
            this.inputVideoTemplate5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate5.Location = new System.Drawing.Point(3, 203);
            this.inputVideoTemplate5.Name = "inputVideoTemplate5";
            this.inputVideoTemplate5.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate5.TabIndex = 4;
            // 
            // inputVideoTemplate6
            // 
            this.inputVideoTemplate6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate6.Location = new System.Drawing.Point(209, 203);
            this.inputVideoTemplate6.Name = "inputVideoTemplate6";
            this.inputVideoTemplate6.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate6.TabIndex = 5;
            // 
            // inputVideoTemplate7
            // 
            this.inputVideoTemplate7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate7.Location = new System.Drawing.Point(415, 203);
            this.inputVideoTemplate7.Name = "inputVideoTemplate7";
            this.inputVideoTemplate7.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate7.TabIndex = 6;
            // 
            // inputVideoTemplate8
            // 
            this.inputVideoTemplate8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate8.Location = new System.Drawing.Point(621, 203);
            this.inputVideoTemplate8.Name = "inputVideoTemplate8";
            this.inputVideoTemplate8.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate8.TabIndex = 7;
            // 
            // inputVideoTemplate9
            // 
            this.inputVideoTemplate9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate9.Location = new System.Drawing.Point(3, 403);
            this.inputVideoTemplate9.Name = "inputVideoTemplate9";
            this.inputVideoTemplate9.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate9.TabIndex = 8;
            // 
            // inputVideoTemplate10
            // 
            this.inputVideoTemplate10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate10.Location = new System.Drawing.Point(209, 403);
            this.inputVideoTemplate10.Name = "inputVideoTemplate10";
            this.inputVideoTemplate10.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate10.TabIndex = 9;
            // 
            // inputVideoTemplate11
            // 
            this.inputVideoTemplate11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate11.Location = new System.Drawing.Point(415, 403);
            this.inputVideoTemplate11.Name = "inputVideoTemplate11";
            this.inputVideoTemplate11.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate11.TabIndex = 10;
            // 
            // inputVideoTemplate12
            // 
            this.inputVideoTemplate12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.inputVideoTemplate12.Location = new System.Drawing.Point(621, 403);
            this.inputVideoTemplate12.Name = "inputVideoTemplate12";
            this.inputVideoTemplate12.Size = new System.Drawing.Size(200, 194);
            this.inputVideoTemplate12.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FileInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.dropPanel);
            this.Name = "FileInputPanel";
            this.Size = new System.Drawing.Size(987, 531);
            this.dropPanel.ResumeLayout(false);
            this.fileTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fileTable;
        private Forms.FormUtils.SmoothPanel dropPanel;
        private InputVideoTemplate inputVideoTemplate1;
        private InputVideoTemplate inputVideoTemplate2;
        private InputVideoTemplate inputVideoTemplate3;
        private InputVideoTemplate inputVideoTemplate4;
        private InputVideoTemplate inputVideoTemplate5;
        private InputVideoTemplate inputVideoTemplate6;
        private InputVideoTemplate inputVideoTemplate7;
        private InputVideoTemplate inputVideoTemplate8;
        private InputVideoTemplate inputVideoTemplate9;
        private InputVideoTemplate inputVideoTemplate10;
        private InputVideoTemplate inputVideoTemplate11;
        private InputVideoTemplate inputVideoTemplate12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
