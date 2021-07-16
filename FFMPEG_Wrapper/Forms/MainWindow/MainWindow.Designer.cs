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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonStartNew = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.fileInputPanel1 = new FFMPEG_Wrapper.UserControls.FileInputPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panelTop.Controls.Add(this.label12);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.imageLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1260, 64);
            this.panelTop.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 35F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(265, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(995, 64);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hello Screen";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(79, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 64);
            this.label11.TabIndex = 15;
            this.label11.Text = "FFMPEG Wrapper 3000";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 546);
            this.panel1.TabIndex = 14;
            // 
            // imageLogo
            // 
            this.imageLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageLogo.BackgroundImage")));
            this.imageLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageLogo.Location = new System.Drawing.Point(0, 0);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(79, 64);
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.leftPanel.Controls.Add(this.buttonSettings);
            this.leftPanel.Controls.Add(this.buttonAbout);
            this.leftPanel.Controls.Add(this.buttonStartNew);
            this.leftPanel.Controls.Add(this.buttonOutput);
            this.leftPanel.Controls.Add(this.buttonEdit);
            this.leftPanel.Controls.Add(this.buttonInput);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 64);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(79, 613);
            this.leftPanel.TabIndex = 14;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(0, 471);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(79, 71);
            this.buttonSettings.TabIndex = 20;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(0, 542);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(79, 71);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // buttonStartNew
            // 
            this.buttonStartNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonStartNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStartNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStartNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonStartNew.FlatAppearance.BorderSize = 0;
            this.buttonStartNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonStartNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonStartNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartNew.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonStartNew.ForeColor = System.Drawing.Color.White;
            this.buttonStartNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartNew.Image")));
            this.buttonStartNew.Location = new System.Drawing.Point(0, 213);
            this.buttonStartNew.Name = "buttonStartNew";
            this.buttonStartNew.Size = new System.Drawing.Size(79, 71);
            this.buttonStartNew.TabIndex = 18;
            this.buttonStartNew.Text = "Start";
            this.buttonStartNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStartNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStartNew.UseVisualStyleBackColor = false;
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOutput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonOutput.FlatAppearance.BorderSize = 0;
            this.buttonOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonOutput.ForeColor = System.Drawing.Color.White;
            this.buttonOutput.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutput.Image")));
            this.buttonOutput.Location = new System.Drawing.Point(0, 142);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(79, 71);
            this.buttonOutput.TabIndex = 17;
            this.buttonOutput.Text = "Output";
            this.buttonOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOutput.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(0, 71);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(79, 71);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.buttonInput.FlatAppearance.BorderSize = 0;
            this.buttonInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Image = ((System.Drawing.Image)(resources.GetObject("buttonInput.Image")));
            this.buttonInput.Location = new System.Drawing.Point(0, 0);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(79, 71);
            this.buttonInput.TabIndex = 15;
            this.buttonInput.Text = "Input";
            this.buttonInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInput.UseVisualStyleBackColor = false;
            // 
            // fileInputPanel1
            // 
            this.fileInputPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.fileInputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInputPanel1.Location = new System.Drawing.Point(79, 64);
            this.fileInputPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileInputPanel1.Name = "fileInputPanel1";
            this.fileInputPanel1.Size = new System.Drawing.Size(1181, 613);
            this.fileInputPanel1.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.fileInputPanel1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFMPEG wrapper";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonStartNew;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label12;
        private UserControls.FileInputPanel fileInputPanel1;
    }
}

