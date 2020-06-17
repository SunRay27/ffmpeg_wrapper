namespace FFMPEG_Overlay
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
            this.textBoxFiles = new System.Windows.Forms.RichTextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBitrate = new System.Windows.Forms.NumericUpDown();
            this.checkBoxConcat = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.DetectUrls = false;
            this.textBoxFiles.HideSelection = false;
            this.textBoxFiles.Location = new System.Drawing.Point(18, 36);
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxFiles.Size = new System.Drawing.Size(427, 197);
            this.textBoxFiles.TabIndex = 0;
            this.textBoxFiles.Text = "";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(18, 239);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(205, 46);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Выбрать файлы";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(229, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 46);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Выходная папка";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(6, 293);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(128, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.TabStop = true;
            this.labelPath.Text = "Output path will be here...";
            this.labelPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelPath_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 334);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка путей";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxCodec);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxPreset);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericBitrate);
            this.groupBox2.Controls.Add(this.checkBoxConcat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 210);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка видео";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость обратоки";
            // 
            // comboBoxPreset
            // 
            this.comboBoxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxPreset.Items.AddRange(new object[] {
            "Ultra fast",
            "Super fast",
            "Very fast",
            "Faster",
            "Fast",
            "Medium",
            "Slow",
            "Slower",
            "Very slow"});
            this.comboBoxPreset.Location = new System.Drawing.Point(9, 89);
            this.comboBoxPreset.Name = "comboBoxPreset";
            this.comboBoxPreset.Size = new System.Drawing.Size(120, 28);
            this.comboBoxPreset.TabIndex = 3;
            this.comboBoxPreset.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPreset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новый битрейт, Кб/с";
            // 
            // numericBitrate
            // 
            this.numericBitrate.Location = new System.Drawing.Point(11, 123);
            this.numericBitrate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericBitrate.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBitrate.Name = "numericBitrate";
            this.numericBitrate.Size = new System.Drawing.Size(120, 26);
            this.numericBitrate.TabIndex = 1;
            this.numericBitrate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBitrate.ValueChanged += new System.EventHandler(this.NumericBitrate_ValueChanged);
            // 
            // checkBoxConcat
            // 
            this.checkBoxConcat.AutoSize = true;
            this.checkBoxConcat.Location = new System.Drawing.Point(10, 25);
            this.checkBoxConcat.Name = "checkBoxConcat";
            this.checkBoxConcat.Size = new System.Drawing.Size(240, 24);
            this.checkBoxConcat.TabIndex = 0;
            this.checkBoxConcat.Text = "Склеить выбранные файлы";
            this.checkBoxConcat.UseVisualStyleBackColor = true;
            this.checkBoxConcat.CheckedChanged += new System.EventHandler(this.CheckBoxConcat_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(355, 604);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 28);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 604);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(337, 28);
            this.progressBar.TabIndex = 8;
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Items.AddRange(new object[] {
            "H264",
            "H265",
            "VP9"});
            this.comboBoxCodec.Location = new System.Drawing.Point(10, 55);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCodec.TabIndex = 9;
            this.comboBoxCodec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCodec_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кодек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 644);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FFMPEG wrapper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxFiles;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.LinkLabel labelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBitrate;
        private System.Windows.Forms.CheckBox checkBoxConcat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.Label label4;
    }
}

