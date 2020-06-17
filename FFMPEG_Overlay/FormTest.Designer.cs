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
            this.labelPath = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBitrate = new System.Windows.Forms.NumericUpDown();
            this.checkBoxConcat = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelffmpegpath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToButton = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFFMPEGButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkWidth = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
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
            this.checkHeight = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkVFlip = new System.Windows.Forms.CheckBox();
            this.checkHFlip = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(9, 737);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(170, 17);
            this.labelPath.TabIndex = 4;
            this.labelPath.TabStop = true;
            this.labelPath.Text = "Output path will be here...";
            this.labelPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelPath_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fileList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 707);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(232, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Исключить выбранный";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.Location = new System.Drawing.Point(10, 25);
            this.fileList.Name = "fileList";
            this.fileList.ScrollAlwaysVisible = true;
            this.fileList.Size = new System.Drawing.Size(423, 613);
            this.fileList.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Видеокодек";
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Items.AddRange(new object[] {
            "H264",
            "H265",
            "VP9"});
            this.comboBoxCodec.Location = new System.Drawing.Point(79, 14);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodec.TabIndex = 9;
            this.comboBoxCodec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCodec_SelectedIndexChanged);
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
            this.comboBoxPreset.Location = new System.Drawing.Point(79, 41);
            this.comboBoxPreset.Name = "comboBoxPreset";
            this.comboBoxPreset.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPreset.TabIndex = 3;
            this.comboBoxPreset.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPreset_SelectedIndexChanged);
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
            this.numericBitrate.ValueChanged += new System.EventHandler(this.NumericBitrate_ValueChanged);
            // 
            // checkBoxConcat
            // 
            this.checkBoxConcat.AutoSize = true;
            this.checkBoxConcat.Enabled = false;
            this.checkBoxConcat.Location = new System.Drawing.Point(458, 425);
            this.checkBoxConcat.Name = "checkBoxConcat";
            this.checkBoxConcat.Size = new System.Drawing.Size(166, 17);
            this.checkBoxConcat.TabIndex = 0;
            this.checkBoxConcat.Text = "Склеить выбранные файлы";
            this.checkBoxConcat.UseVisualStyleBackColor = true;
            this.checkBoxConcat.CheckedChanged += new System.EventHandler(this.CheckBoxConcat_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(477, 700);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(410, 34);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelffmpegpath
            // 
            this.labelffmpegpath.AutoSize = true;
            this.labelffmpegpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelffmpegpath.Location = new System.Drawing.Point(55, 3);
            this.labelffmpegpath.Name = "labelffmpegpath";
            this.labelffmpegpath.Size = new System.Drawing.Size(116, 15);
            this.labelffmpegpath.TabIndex = 6;
            this.labelffmpegpath.Text = "path_to_ffmpeg.exe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveToButton,
            this.selectFFMPEGButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(184, 22);
            this.openFileButton.Text = "Открыть...";
            this.openFileButton.Click += new System.EventHandler(this.OpenFilesClick);
            // 
            // saveToButton
            // 
            this.saveToButton.Name = "saveToButton";
            this.saveToButton.Size = new System.Drawing.Size(184, 22);
            this.saveToButton.Text = "Сохранять в...";
            this.saveToButton.Click += new System.EventHandler(this.SaveToButtonClick);
            // 
            // selectFFMPEGButton
            // 
            this.selectFFMPEGButton.Name = "selectFFMPEGButton";
            this.selectFFMPEGButton.Size = new System.Drawing.Size(184, 22);
            this.selectFFMPEGButton.Text = "Настройка ffmpeg...";
            this.selectFFMPEGButton.Click += new System.EventHandler(this.selectFFMPEGClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(458, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 383);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkHFlip);
            this.tabPage1.Controls.Add(this.checkVFlip);
            this.tabPage1.Controls.Add(this.textBox1);
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
            this.tabPage1.Size = new System.Drawing.Size(425, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видео";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkWidth
            // 
            this.checkWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkWidth.AutoSize = true;
            this.checkWidth.Location = new System.Drawing.Point(15, 228);
            this.checkWidth.Name = "checkWidth";
            this.checkWidth.Size = new System.Drawing.Size(117, 17);
            this.checkWidth.TabIndex = 17;
            this.checkWidth.Text = "Изменить ширину";
            this.checkWidth.UseVisualStyleBackColor = true;
            this.checkWidth.CheckedChanged += new System.EventHandler(this.checkWidth_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Высота";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ширина";
            // 
            // numericHeight
            // 
            this.numericHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericHeight.Enabled = false;
            this.numericHeight.Location = new System.Drawing.Point(342, 251);
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
            this.numericWidth.Location = new System.Drawing.Point(79, 251);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxACodec);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 255);
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
            this.comboBoxACodec.Location = new System.Drawing.Point(81, 18);
            this.comboBoxACodec.Name = "comboBoxACodec";
            this.comboBoxACodec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxACodec.TabIndex = 11;
            this.comboBoxACodec.SelectedIndexChanged += new System.EventHandler(this.comboBoxACodec_SelectedIndexChanged);
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
            this.tabPage4.Size = new System.Drawing.Size(425, 255);
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
            this.comboExtention.SelectedIndexChanged += new System.EventHandler(this.comboExtention_SelectedIndexChanged);
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
            // checkHeight
            // 
            this.checkHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkHeight.AutoSize = true;
            this.checkHeight.Location = new System.Drawing.Point(278, 228);
            this.checkHeight.Name = "checkHeight";
            this.checkHeight.Size = new System.Drawing.Size(116, 17);
            this.checkHeight.TabIndex = 18;
            this.checkHeight.Text = "Изменить высоту";
            this.checkHeight.UseVisualStyleBackColor = true;
            this.checkHeight.CheckedChanged += new System.EventHandler(this.checkHeight_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 277);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(393, 62);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "При изменении только ширины/высоты второй параметр определяется в соответсвии с с" +
    "оотношением сторон входного файла\r\n\r\nНапример: входное видео 1280x720, заменим ш" +
    "ирину на 320 ---> 320x180\r\n\r\n";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 763);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelffmpegpath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.checkBoxConcat);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "FFMPEG wrapper";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel labelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBitrate;
        private System.Windows.Forms.CheckBox checkBoxConcat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelffmpegpath;
        private System.Windows.Forms.CheckedListBox fileList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToButton;
        private System.Windows.Forms.ToolStripMenuItem selectFFMPEGButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.CheckBox checkWidth;
        private System.Windows.Forms.CheckBox checkHeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkHFlip;
        private System.Windows.Forms.CheckBox checkVFlip;
    }
}

