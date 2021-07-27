
namespace FFMPEG_Wrapper.UserControls
{
    partial class LeftPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftPanel));
            this.panel = new System.Windows.Forms.Panel();
            this.selector = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel.Controls.Add(this.selector);
            this.panel.Controls.Add(this.buttonSettings);
            this.panel.Controls.Add(this.buttonAbout);
            this.panel.Controls.Add(this.buttonOutput);
            this.panel.Controls.Add(this.buttonEdit);
            this.panel.Controls.Add(this.buttonInput);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(88, 681);
            this.panel.TabIndex = 15;
            // 
            // selector
            // 
            this.selector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selector.BackColor = System.Drawing.Color.Crimson;
            this.selector.Location = new System.Drawing.Point(83, 0);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(5, 71);
            this.selector.TabIndex = 21;
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 539);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(88, 71);
            this.buttonSettings.TabIndex = 20;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.buttonAbout.Location = new System.Drawing.Point(0, 610);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(88, 71);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
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
            this.buttonOutput.Size = new System.Drawing.Size(88, 71);
            this.buttonOutput.TabIndex = 17;
            this.buttonOutput.Text = "Output";
            this.buttonOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
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
            this.buttonEdit.Size = new System.Drawing.Size(88, 71);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.buttonInput.Size = new System.Drawing.Size(88, 71);
            this.buttonInput.TabIndex = 15;
            this.buttonInput.Text = "Input";
            this.buttonInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // LeftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "LeftPanel";
            this.Size = new System.Drawing.Size(88, 681);
            this.Resize += new System.EventHandler(this.LeftPanel_Resize);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Panel selector;
    }
}
