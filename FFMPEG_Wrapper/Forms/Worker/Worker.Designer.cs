using System.Windows.Forms;

namespace FFMPEG_Wrapper
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.labelEstimated = new System.Windows.Forms.Label();
            this.frameText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.progress = new FFMPEG_Wrapper.Forms.FormUtils.RJProgressBar();
            this.abortButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.smoothPanel2 = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.smoothPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(660, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 67);
            this.label1.TabIndex = 21;
            this.label1.Text = "Task queue:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameLabel.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.fileNameLabel.ForeColor = System.Drawing.Color.White;
            this.fileNameLabel.Location = new System.Drawing.Point(4, 0);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(649, 67);
            this.fileNameLabel.TabIndex = 17;
            this.fileNameLabel.Text = "name of processed file here...";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstimated
            // 
            this.labelEstimated.AutoSize = true;
            this.labelEstimated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEstimated.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelEstimated.ForeColor = System.Drawing.Color.White;
            this.labelEstimated.Location = new System.Drawing.Point(4, 760);
            this.labelEstimated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstimated.Name = "labelEstimated";
            this.labelEstimated.Size = new System.Drawing.Size(649, 34);
            this.labelEstimated.TabIndex = 18;
            this.labelEstimated.Text = "estimated time...";
            // 
            // frameText
            // 
            this.frameText.AutoSize = true;
            this.frameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameText.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.frameText.ForeColor = System.Drawing.Color.White;
            this.frameText.Location = new System.Drawing.Point(4, 794);
            this.frameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frameText.Name = "frameText";
            this.frameText.Size = new System.Drawing.Size(649, 51);
            this.frameText.TabIndex = 15;
            this.frameText.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.56811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.43189F));
            this.tableLayoutPanel1.Controls.Add(this.frameText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.abortButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelEstimated, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progress, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fileNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.smoothPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 693F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 886);
            this.tableLayoutPanel1.TabIndex = 21;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(660, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 687);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // consoleText
            // 
            this.consoleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.consoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleText.Font = new System.Drawing.Font("Century Gothic", 6.882353F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleText.ForeColor = System.Drawing.Color.White;
            this.consoleText.Location = new System.Drawing.Point(23, 23);
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.Size = new System.Drawing.Size(606, 641);
            this.consoleText.TabIndex = 40;
            this.consoleText.Text = "";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.progress.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.progress.ChannelHeight = 15;
            this.progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress.Font = new System.Drawing.Font("Century Gothic", 6.933333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress.ForeBackColor = System.Drawing.Color.Crimson;
            this.progress.ForeColor = System.Drawing.Color.White;
            this.progress.Location = new System.Drawing.Point(3, 848);
            this.progress.Name = "progress";
            this.progress.ShowMaximun = true;
            this.progress.ShowValue = FFMPEG_Wrapper.Forms.FormUtils.TextPosition.Sliding;
            this.progress.Size = new System.Drawing.Size(651, 35);
            this.progress.SliderColor = System.Drawing.Color.Crimson;
            this.progress.SliderHeight = 15;
            this.progress.SymbolAfter = "";
            this.progress.SymbolBefore = "";
            this.progress.TabIndex = 20;
            this.progress.Value = 20;
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.abortButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.abortButton.BorderColor = System.Drawing.Color.Crimson;
            this.abortButton.BorderRadius = 9;
            this.abortButton.BorderSize = 2;
            this.abortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abortButton.FlatAppearance.BorderSize = 0;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.abortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.abortButton.Location = new System.Drawing.Point(661, 849);
            this.abortButton.Margin = new System.Windows.Forms.Padding(4);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(539, 33);
            this.abortButton.TabIndex = 38;
            this.abortButton.Text = "Abort processing";
            this.abortButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // smoothPanel2
            // 
            this.smoothPanel2.BorderColor = System.Drawing.Color.Crimson;
            this.smoothPanel2.BorderRadius = 10;
            this.smoothPanel2.BorderWidth = 2F;
            this.smoothPanel2.Controls.Add(this.consoleText);
            this.smoothPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.smoothPanel2.Location = new System.Drawing.Point(3, 70);
            this.smoothPanel2.Name = "smoothPanel2";
            this.smoothPanel2.OffsetXBottom = 12;
            this.smoothPanel2.OffsetXTop = 12;
            this.smoothPanel2.OffsetYBottom = 12;
            this.smoothPanel2.OffsetYTop = 12;
            this.smoothPanel2.Size = new System.Drawing.Size(651, 687);
            this.smoothPanel2.TabIndex = 40;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(136F, 136F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1204, 886);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.smoothPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Output.RJButton abortButton;
        private Label label1;
        private Label fileNameLabel;
        private Forms.FormUtils.RJProgressBar progress;
        private Label labelEstimated;
        private Label frameText;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox consoleText;
        private Forms.FormUtils.SmoothPanel smoothPanel2;
    }
}