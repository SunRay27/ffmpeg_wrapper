
namespace FFMPEG_Wrapper.UserControls.Settings
{
    partial class SettingsPanel
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
            this.smoothPanel1 = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.miscPanel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectffprobeButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.ffprobePathLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectffmpegButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.ffmpegPathLabel = new System.Windows.Forms.Label();
            this.smoothPanel1.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.miscPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // smoothPanel1
            // 
            this.smoothPanel1.AutoSize = true;
            this.smoothPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.smoothPanel1.BorderRadius = 25;
            this.smoothPanel1.BorderWidth = 5F;
            this.smoothPanel1.Controls.Add(this.label8);
            this.smoothPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.smoothPanel1.Location = new System.Drawing.Point(0, 0);
            this.smoothPanel1.Name = "smoothPanel1";
            this.smoothPanel1.OffsetXBottom = 400;
            this.smoothPanel1.OffsetXTop = 400;
            this.smoothPanel1.OffsetYBottom = 200;
            this.smoothPanel1.OffsetYTop = 200;
            this.smoothPanel1.Size = new System.Drawing.Size(1201, 670);
            this.smoothPanel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1201, 670);
            this.label8.TabIndex = 15;
            this.label8.Text = "NOT IMPLEMENTED";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.38135F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.61865F));
            this.layoutPanel.Controls.Add(this.miscPanel, 0, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(1201, 670);
            this.layoutPanel.TabIndex = 3;
            // 
            // miscPanel
            // 
            this.miscPanel.AutoSize = true;
            this.miscPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.BorderRadius = 5;
            this.miscPanel.BorderWidth = 1F;
            this.miscPanel.Controls.Add(this.tableLayoutPanel1);
            this.miscPanel.Controls.Add(this.tableLayoutPanel3);
            this.miscPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.Location = new System.Drawing.Point(3, 3);
            this.miscPanel.Name = "miscPanel";
            this.miscPanel.OffsetXBottom = 25;
            this.miscPanel.OffsetXTop = 25;
            this.miscPanel.OffsetYBottom = 25;
            this.miscPanel.OffsetYTop = 25;
            this.miscPanel.Size = new System.Drawing.Size(503, 664);
            this.miscPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectffprobeButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ffprobePathLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 85);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "ffprobe.exe path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectffprobeButton
            // 
            this.selectffprobeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectffprobeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectffprobeButton.BorderColor = System.Drawing.Color.Crimson;
            this.selectffprobeButton.BorderRadius = 9;
            this.selectffprobeButton.BorderSize = 2;
            this.selectffprobeButton.FlatAppearance.BorderSize = 0;
            this.selectffprobeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectffprobeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectffprobeButton.ForeColor = System.Drawing.Color.White;
            this.selectffprobeButton.Location = new System.Drawing.Point(361, 40);
            this.selectffprobeButton.Name = "selectffprobeButton";
            this.selectffprobeButton.Size = new System.Drawing.Size(118, 40);
            this.selectffprobeButton.TabIndex = 36;
            this.selectffprobeButton.Text = "Select...";
            this.selectffprobeButton.TextColor = System.Drawing.Color.White;
            this.selectffprobeButton.UseVisualStyleBackColor = false;
            this.selectffprobeButton.Click += new System.EventHandler(this.selectffprobeButton_Click);
            // 
            // ffprobePathLabel
            // 
            this.ffprobePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ffprobePathLabel.AutoSize = true;
            this.ffprobePathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ffprobePathLabel.ForeColor = System.Drawing.Color.White;
            this.ffprobePathLabel.Location = new System.Drawing.Point(3, 52);
            this.ffprobePathLabel.Name = "ffprobePathLabel";
            this.ffprobePathLabel.Size = new System.Drawing.Size(352, 17);
            this.ffprobePathLabel.TabIndex = 38;
            this.ffprobePathLabel.Text = "label2";
            this.ffprobePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.selectffmpegButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ffmpegPathLabel, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(482, 87);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "ffmpeg.exe path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectffmpegButton
            // 
            this.selectffmpegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectffmpegButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectffmpegButton.BorderColor = System.Drawing.Color.Crimson;
            this.selectffmpegButton.BorderRadius = 9;
            this.selectffmpegButton.BorderSize = 2;
            this.selectffmpegButton.FlatAppearance.BorderSize = 0;
            this.selectffmpegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectffmpegButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectffmpegButton.ForeColor = System.Drawing.Color.White;
            this.selectffmpegButton.Location = new System.Drawing.Point(361, 40);
            this.selectffmpegButton.Name = "selectffmpegButton";
            this.selectffmpegButton.Size = new System.Drawing.Size(118, 40);
            this.selectffmpegButton.TabIndex = 36;
            this.selectffmpegButton.Text = "Select...";
            this.selectffmpegButton.TextColor = System.Drawing.Color.White;
            this.selectffmpegButton.UseVisualStyleBackColor = false;
            this.selectffmpegButton.Click += new System.EventHandler(this.selectffmpegButton_Click);
            // 
            // ffmpegPathLabel
            // 
            this.ffmpegPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ffmpegPathLabel.AutoSize = true;
            this.ffmpegPathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ffmpegPathLabel.ForeColor = System.Drawing.Color.White;
            this.ffmpegPathLabel.Location = new System.Drawing.Point(3, 53);
            this.ffmpegPathLabel.Name = "ffmpegPathLabel";
            this.ffmpegPathLabel.Size = new System.Drawing.Size(352, 17);
            this.ffmpegPathLabel.TabIndex = 38;
            this.ffmpegPathLabel.Text = "label2";
            this.ffmpegPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.smoothPanel1);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1201, 670);
            this.smoothPanel1.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.miscPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Forms.FormUtils.SmoothPanel smoothPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private Forms.FormUtils.SmoothPanel miscPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Output.RJButton selectffprobeButton;
        private System.Windows.Forms.Label ffprobePathLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Output.RJButton selectffmpegButton;
        private System.Windows.Forms.Label ffmpegPathLabel;
    }
}
