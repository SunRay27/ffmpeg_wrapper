
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dropPanel.SuspendLayout();
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
            this.fileTable.Location = new System.Drawing.Point(62, 55);
            this.fileTable.Margin = new System.Windows.Forms.Padding(0);
            this.fileTable.Name = "fileTable";
            this.fileTable.Size = new System.Drawing.Size(860, 415);
            this.fileTable.TabIndex = 0;
            this.fileTable.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.fileTable_ControlRemoved);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fileTable;
        private Forms.FormUtils.SmoothPanel dropPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
