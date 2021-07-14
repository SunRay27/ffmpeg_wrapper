﻿namespace FFMPEG_Overlay
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
            this.labelPath = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.CheckedListBox();
            this.checkBoxConcat = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkHFlip = new System.Windows.Forms.CheckBox();
            this.checkVFlip = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToButton = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFFMPEGButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonStartNew = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPath.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(3, 612);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(151, 16);
            this.labelPath.TabIndex = 4;
            this.labelPath.TabStop = true;
            this.labelPath.Text = "Output path will be here...";
            this.labelPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelPath_LinkClicked);
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
            this.groupBox1.Size = new System.Drawing.Size(462, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Исключить выбранный";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.fileList.Size = new System.Drawing.Size(456, 589);
            this.fileList.TabIndex = 1;
            // 
            // checkBoxConcat
            // 
            this.checkBoxConcat.AutoSize = true;
            this.checkBoxConcat.Enabled = false;
            this.checkBoxConcat.Location = new System.Drawing.Point(15, 188);
            this.checkBoxConcat.Name = "checkBoxConcat";
            this.checkBoxConcat.Size = new System.Drawing.Size(180, 20);
            this.checkBoxConcat.TabIndex = 0;
            this.checkBoxConcat.Text = "Склеить выбранные файлы";
            this.checkBoxConcat.UseVisualStyleBackColor = true;
            this.checkBoxConcat.CheckedChanged += new System.EventHandler(this.CheckBoxConcat_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.Location = new System.Drawing.Point(1112, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 631);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(462, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 631);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видео";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkHFlip
            // 
            this.checkHFlip.AutoSize = true;
            this.checkHFlip.Location = new System.Drawing.Point(15, 140);
            this.checkHFlip.Name = "checkHFlip";
            this.checkHFlip.Size = new System.Drawing.Size(168, 20);
            this.checkHFlip.TabIndex = 21;
            this.checkHFlip.Text = "Отразить по горизонтали";
            this.checkHFlip.UseVisualStyleBackColor = true;
            // 
            // checkVFlip
            // 
            this.checkVFlip.AutoSize = true;
            this.checkVFlip.Location = new System.Drawing.Point(15, 117);
            this.checkVFlip.Name = "checkVFlip";
            this.checkVFlip.Size = new System.Drawing.Size(156, 20);
            this.checkVFlip.TabIndex = 20;
            this.checkVFlip.Text = "Отразить по вериткали";
            this.checkVFlip.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 497);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(610, 89);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "При изменении только ширины/высоты второй параметр определяется в соответсвии с с" +
    "оотношением сторон входного файла\r\n\r\nНапример: входное видео 1280x720, заменим ш" +
    "ирину на 320 ---> 320x180\r\n\r\n";
            // 
            // checkHeight
            // 
            this.checkHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkHeight.AutoSize = true;
            this.checkHeight.Location = new System.Drawing.Point(489, 444);
            this.checkHeight.Name = "checkHeight";
            this.checkHeight.Size = new System.Drawing.Size(119, 20);
            this.checkHeight.TabIndex = 18;
            this.checkHeight.Text = "Изменить высоту";
            this.checkHeight.UseVisualStyleBackColor = true;
            this.checkHeight.CheckedChanged += new System.EventHandler(this.checkHeight_CheckedChanged);
            // 
            // checkWidth
            // 
            this.checkWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkWidth.AutoSize = true;
            this.checkWidth.Location = new System.Drawing.Point(15, 440);
            this.checkWidth.Name = "checkWidth";
            this.checkWidth.Size = new System.Drawing.Size(128, 20);
            this.checkWidth.TabIndex = 17;
            this.checkWidth.Text = "Изменить ширину";
            this.checkWidth.UseVisualStyleBackColor = true;
            this.checkWidth.CheckedChanged += new System.EventHandler(this.checkWidth_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Высота";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ширина";
            // 
            // numericHeight
            // 
            this.numericHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericHeight.Enabled = false;
            this.numericHeight.Location = new System.Drawing.Point(556, 470);
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
            this.numericHeight.Size = new System.Drawing.Size(66, 21);
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
            this.numericWidth.Location = new System.Drawing.Point(79, 470);
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
            this.numericWidth.Size = new System.Drawing.Size(66, 21);
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
            this.numericBitrate.Size = new System.Drawing.Size(66, 21);
            this.numericBitrate.TabIndex = 1;
            this.numericBitrate.Value = new decimal(new int[] {
            5120,
            0,
            0,
            0});
            this.numericBitrate.ValueChanged += new System.EventHandler(this.NumericBitrate_ValueChanged);
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
            this.comboBoxCodec.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCodec.TabIndex = 9;
            this.comboBoxCodec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCodec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пресет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Видеокодек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
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
            this.comboBoxPreset.Size = new System.Drawing.Size(120, 24);
            this.comboBoxPreset.TabIndex = 3;
            this.comboBoxPreset.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPreset_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxACodec);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 563);
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
            this.comboBoxACodec.Size = new System.Drawing.Size(121, 24);
            this.comboBoxACodec.TabIndex = 11;
            this.comboBoxACodec.SelectedIndexChanged += new System.EventHandler(this.comboBoxACodec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(425, 563);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Прочее";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Постфикс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Префикс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
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
            this.comboExtention.Size = new System.Drawing.Size(121, 24);
            this.comboExtention.TabIndex = 12;
            this.comboExtention.SelectedIndexChanged += new System.EventHandler(this.comboExtention_SelectedIndexChanged);
            // 
            // textPostfix
            // 
            this.textPostfix.Location = new System.Drawing.Point(298, 32);
            this.textPostfix.Name = "textPostfix";
            this.textPostfix.Size = new System.Drawing.Size(100, 21);
            this.textPostfix.TabIndex = 1;
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(169, 31);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(100, 21);
            this.textPrefix.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.selectFFMPEGButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveToButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 21);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(245, 22);
            this.openFileButton.Text = "Добавить видео...";
            this.openFileButton.Click += new System.EventHandler(this.OpenFilesClick);
            // 
            // saveToButton
            // 
            this.saveToButton.Name = "saveToButton";
            this.saveToButton.Size = new System.Drawing.Size(245, 22);
            this.saveToButton.Text = "Указать папку сохранений...";
            this.saveToButton.Click += new System.EventHandler(this.SaveToButtonClick);
            // 
            // selectFFMPEGButton
            // 
            this.selectFFMPEGButton.Name = "selectFFMPEGButton";
            this.selectFFMPEGButton.Size = new System.Drawing.Size(173, 21);
            this.selectFFMPEGButton.Text = "Указать путь к ffmpeg.exe";
            this.selectFFMPEGButton.Click += new System.EventHandler(this.selectFFMPEGButton_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panelTop.Controls.Add(this.label12);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.imageLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 64);
            this.panelTop.TabIndex = 13;
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
            this.leftPanel.Location = new System.Drawing.Point(0, 89);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(79, 631);
            this.leftPanel.TabIndex = 14;
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
            this.buttonAbout.Location = new System.Drawing.Point(0, 560);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(79, 71);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = false;
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 489);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(79, 71);
            this.buttonSettings.TabIndex = 20;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 35F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(265, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1015, 64);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hello Screen";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.tabControl1);
            this.mainPanel.Controls.Add(this.buttonStart);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(79, 89);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1201, 631);
            this.mainPanel.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "FFMPEG wrapper";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel labelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxConcat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckedListBox fileList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBoxACodec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboExtention;
        private System.Windows.Forms.TextBox textPostfix;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToButton;
        private System.Windows.Forms.ToolStripMenuItem selectFFMPEGButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkHFlip;
        private System.Windows.Forms.CheckBox checkVFlip;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Panel mainPanel;
    }
}
