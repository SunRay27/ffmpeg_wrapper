
namespace FFMPEG_Wrapper.UserControls.About
{
    partial class AboutPanel
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
            this.panel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.programVersionLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderColor = System.Drawing.Color.Crimson;
            this.panel.BorderRadius = 0;
            this.panel.BorderWidth = 2F;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.programVersionLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.OffsetXBottom = -50;
            this.panel.OffsetXTop = -50;
            this.panel.OffsetYBottom = -50;
            this.panel.OffsetYTop = -50;
            this.panel.Size = new System.Drawing.Size(828, 613);
            this.panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi! This is my super program which can do simple reencoding to videos. More funct" +
    "ions to come, more pain to get. \"About\" section will be filled with some useful " +
    "functionality in future! Cool!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programVersionLabel
            // 
            this.programVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.programVersionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programVersionLabel.ForeColor = System.Drawing.Color.White;
            this.programVersionLabel.Location = new System.Drawing.Point(26, 564);
            this.programVersionLabel.Name = "programVersionLabel";
            this.programVersionLabel.Size = new System.Drawing.Size(767, 24);
            this.programVersionLabel.TabIndex = 0;
            this.programVersionLabel.Text = "ver. over9000";
            // 
            // AboutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel);
            this.Name = "AboutPanel";
            this.Size = new System.Drawing.Size(828, 613);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label programVersionLabel;
        private Forms.FormUtils.SmoothPanel panel;
        private System.Windows.Forms.Label label1;
    }
}
