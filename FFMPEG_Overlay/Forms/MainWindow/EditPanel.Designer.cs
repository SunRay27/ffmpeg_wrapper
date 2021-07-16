
namespace FFMPEG_Overlay.Forms.MainWindow
{
    partial class EditPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPanel));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.CheckedListBox();
            this.labelPath = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkHFlip = new System.Windows.Forms.CheckBox();
            this.checkVFlip = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxConcat = new System.Windows.Forms.CheckBox();
            this.checkHeight = new System.Windows.Forms.CheckBox();
            this.checkWidth = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericBitrate = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPreset = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxACodec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboExtention = new System.Windows.Forms.ComboBox();
            this.textPostfix = new System.Windows.Forms.TextBox();
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.tabControl1);
            this.mainPanel.Controls.Add(this.buttonStart);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1069, 665);
            this.mainPanel.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fileList);
            this.groupBox1.Controls.Add(this.labelPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 665);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Исключить выбранный";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileList
            // 
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.Location = new System.Drawing.Point(3, 23);
            this.fileList.Name = "fileList";
            this.fileList.ScrollAlwaysVisible = true;
            this.fileList.Size = new System.Drawing.Size(324, 623);
            this.fileList.TabIndex = 1;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPath.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(3, 646);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(151, 16);
            this.labelPath.TabIndex = 4;
            this.labelPath.TabStop = true;
            this.labelPath.Text = "Output path will be here...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(330, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkHFlip);
            this.tabPage1.Controls.Add(this.checkVFlip);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.checkBoxConcat);
            this.tabPage1.Controls.Add(this.checkHeight);
            this.tabPage1.Controls.Add(this.checkWidth);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.numericHeight);
            this.tabPage1.Controls.Add(this.numericWidth);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericBitrate);
            this.tabPage1.Controls.Add(this.comboBoxCodec);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxPreset);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видео";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkHFlip
            // 
            this.checkHFlip.AutoSize = true;
            this.checkHFlip.Location = new System.Drawing.Point(15, 140);
            this.checkHFlip.Name = "checkHFlip";
            this.checkHFlip.Size = new System.Drawing.Size(156, 17);
            this.checkHFlip.TabIndex = 21;
            this.checkHFlip.Text = "Отразить по горизонтали";
            this.checkHFlip.UseVisualStyleBackColor = true;
            // 
            // checkVFlip
            // 
            this.checkVFlip.AutoSize = true;
            this.checkVFlip.Location = new System.Drawing.Point(15, 117);
            this.checkVFlip.Name = "checkVFlip";
            this.checkVFlip.Size = new System.Drawing.Size(145, 17);
            this.checkVFlip.TabIndex = 20;
            this.checkVFlip.Text = "Отразить по вериткали";
            this.checkVFlip.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 513);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(610, 89);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "При изменении только ширины/высоты второй параметр определяется в соответсвии с с" +
    "оотношением сторон входного файла\r\n\r\nНапример: входное видео 1280x720, заменим ш" +
    "ирину на 320 ---> 320x180\r\n\r\n";
            // 
            // checkBoxConcat
            // 
            this.checkBoxConcat.AutoSize = true;
            this.checkBoxConcat.Enabled = false;
            this.checkBoxConcat.Location = new System.Drawing.Point(15, 188);
            this.checkBoxConcat.Name = "checkBoxConcat";
            this.checkBoxConcat.Size = new System.Drawing.Size(166, 17);
            this.checkBoxConcat.TabIndex = 0;
            this.checkBoxConcat.Text = "Склеить выбранные файлы";
            this.checkBoxConcat.UseVisualStyleBackColor = true;
            // 
            // checkHeight
            // 
            this.checkHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkHeight.AutoSize = true;
            this.checkHeight.Location = new System.Drawing.Point(492, 463);
            this.checkHeight.Name = "checkHeight";
            this.checkHeight.Size = new System.Drawing.Size(116, 17);
            this.checkHeight.TabIndex = 18;
            this.checkHeight.Text = "Изменить высоту";
            this.checkHeight.UseVisualStyleBackColor = true;
            // 
            // checkWidth
            // 
            this.checkWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkWidth.AutoSize = true;
            this.checkWidth.Location = new System.Drawing.Point(15, 459);
            this.checkWidth.Name = "checkWidth";
            this.checkWidth.Size = new System.Drawing.Size(117, 17);
            this.checkWidth.TabIndex = 17;
            this.checkWidth.Text = "Изменить ширину";
            this.checkWidth.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Высота";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ширина";
            // 
            // numericHeight
            // 
            this.numericHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericHeight.Enabled = false;
            this.numericHeight.Location = new System.Drawing.Point(556, 486);
            this.numericHeight.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(66, 20);
            this.numericHeight.TabIndex = 14;
            this.numericHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // numericWidth
            // 
            this.numericWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericWidth.Enabled = false;
            this.numericWidth.Location = new System.Drawing.Point(79, 486);
            this.numericWidth.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(66, 20);
            this.numericWidth.TabIndex = 13;
            this.numericWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(328, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "-";
            // 
            // numericBitrate
            // 
            this.numericBitrate.Location = new System.Drawing.Point(331, 14);
            this.numericBitrate.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericBitrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBitrate.Name = "numericBitrate";
            this.numericBitrate.Size = new System.Drawing.Size(66, 20);
            this.numericBitrate.TabIndex = 1;
            this.numericBitrate.Value = new decimal(new int[] {
            5120,
            0,
            0,
            0});
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Items.AddRange(new object[] {
            "H264",
            "H265",
            "VP9"});
            this.comboBoxCodec.Location = new System.Drawing.Point(95, 14);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodec.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пресет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Видеокодек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitrate, Kb/s";
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
            this.comboBoxPreset.Location = new System.Drawing.Point(95, 42);
            this.comboBoxPreset.Name = "comboBoxPreset";
            this.comboBoxPreset.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPreset.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxACodec);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(642, 879);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аудио";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxACodec
            // 
            this.comboBoxACodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxACodec.FormattingEnabled = true;
            this.comboBoxACodec.Items.AddRange(new object[] {
            "H264",
            "H265",
            "VP9"});
            this.comboBoxACodec.Location = new System.Drawing.Point(98, 21);
            this.comboBoxACodec.Name = "comboBoxACodec";
            this.comboBoxACodec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxACodec.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Аудиокодек";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.comboExtention);
            this.tabPage4.Controls.Add(this.textPostfix);
            this.tabPage4.Controls.Add(this.textPrefix);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(642, 879);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Прочее";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Постфикс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Префикс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выходное расширение";
            // 
            // comboExtention
            // 
            this.comboExtention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtention.FormattingEnabled = true;
            this.comboExtention.Items.AddRange(new object[] {
            "H264",
            "H265",
            "VP9"});
            this.comboExtention.Location = new System.Drawing.Point(15, 31);
            this.comboExtention.Name = "comboExtention";
            this.comboExtention.Size = new System.Drawing.Size(121, 21);
            this.comboExtention.TabIndex = 12;
            // 
            // textPostfix
            // 
            this.textPostfix.Location = new System.Drawing.Point(298, 32);
            this.textPostfix.Name = "textPostfix";
            this.textPostfix.Size = new System.Drawing.Size(100, 20);
            this.textPostfix.TabIndex = 1;
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(169, 31);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(100, 20);
            this.textPrefix.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.Location = new System.Drawing.Point(980, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 665);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // EditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "EditPanel";
            this.Size = new System.Drawing.Size(1069, 665);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox fileList;
        private System.Windows.Forms.LinkLabel labelPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkHFlip;
        private System.Windows.Forms.CheckBox checkVFlip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxConcat;
        private System.Windows.Forms.CheckBox checkHeight;
        private System.Windows.Forms.CheckBox checkWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericBitrate;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxACodec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboExtention;
        private System.Windows.Forms.TextBox textPostfix;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.Button buttonStart;
    }
}
