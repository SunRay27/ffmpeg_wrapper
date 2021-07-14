using System.Windows.Forms;

namespace FFMPEG_Overlay
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
            this.frameText = new System.Windows.Forms.Label();
            this.consoleText = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.labelEstimated = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // frameText
            // 
            this.frameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.frameText.AutoSize = true;
            this.frameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameText.Location = new System.Drawing.Point(12, 646);
            this.frameText.Name = "frameText";
            this.frameText.Size = new System.Drawing.Size(16, 13);
            this.frameText.TabIndex = 15;
            this.frameText.Text = "...";
            // 
            // consoleText
            // 
            this.consoleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleText.Location = new System.Drawing.Point(12, 45);
            this.consoleText.Multiline = true;
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleText.Size = new System.Drawing.Size(660, 559);
            this.consoleText.TabIndex = 13;
            this.consoleText.WordWrap = false;
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abortButton.Location = new System.Drawing.Point(548, 673);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(130, 35);
            this.abortButton.TabIndex = 16;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(15, 13);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(259, 24);
            this.fileNameLabel.TabIndex = 17;
            this.fileNameLabel.Text = "name of processed file here...";
            // 
            // labelEstimated
            // 
            this.labelEstimated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEstimated.AutoSize = true;
            this.labelEstimated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEstimated.Location = new System.Drawing.Point(12, 617);
            this.labelEstimated.Name = "labelEstimated";
            this.labelEstimated.Size = new System.Drawing.Size(111, 17);
            this.labelEstimated.TabIndex = 18;
            this.labelEstimated.Text = "estimated time...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 673);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(527, 35);
            this.progressBar.TabIndex = 19;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 720);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelEstimated);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.frameText);
            this.Controls.Add(this.consoleText);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frameText;
        private System.Windows.Forms.TextBox consoleText;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label labelEstimated;
        private ProgressBar progressBar;
    }
}