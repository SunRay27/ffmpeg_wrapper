
namespace FFMPEG_Wrapper.UserControls.MainWindow
{
    partial class TopPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopPanel));
            this.panelTop = new System.Windows.Forms.Panel();
            this.programLabel = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Label();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panelTop.Controls.Add(this.programLabel);
            this.panelTop.Controls.Add(this.panelLabel);
            this.panelTop.Controls.Add(this.imageLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1027, 141);
            this.panelTop.TabIndex = 15;
            // 
            // programLabel
            // 
            this.programLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.programLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programLabel.ForeColor = System.Drawing.Color.White;
            this.programLabel.Location = new System.Drawing.Point(70, 0);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(186, 141);
            this.programLabel.TabIndex = 15;
            this.programLabel.Text = "FFMPEG Wrapper 3000";
            this.programLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLabel
            // 
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelLabel.Font = new System.Drawing.Font("Century Gothic", 35F);
            this.panelLabel.ForeColor = System.Drawing.Color.White;
            this.panelLabel.Location = new System.Drawing.Point(70, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(957, 141);
            this.panelLabel.TabIndex = 16;
            this.panelLabel.Text = "Hello Screen";
            this.panelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageLogo
            // 
            this.imageLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageLogo.BackgroundImage")));
            this.imageLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageLogo.Location = new System.Drawing.Point(0, 0);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(70, 141);
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // TopPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTop);
            this.Name = "TopPanel";
            this.Size = new System.Drawing.Size(1027, 141);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label panelLabel;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.PictureBox imageLogo;
    }
}
