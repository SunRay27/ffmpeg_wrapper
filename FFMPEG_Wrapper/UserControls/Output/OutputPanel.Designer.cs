
namespace FFMPEG_Wrapper.UserControls.Output
{
    partial class OutputPanel
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.miscPanel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.concatButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.startButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectSavePathButton = new FFMPEG_Wrapper.UserControls.Output.RJButton();
            this.defaultSavePathBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.audioCodecCombo = new FFMPEG_Wrapper.Forms.FormUtils.RoundedComboBox();
            this.audioCodecLabel = new System.Windows.Forms.Label();
            this.extentionLabel = new System.Windows.Forms.Label();
            this.extentionCombo = new FFMPEG_Wrapper.Forms.FormUtils.RoundedComboBox();
            this.postfixLabel = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.postfixBox = new FFMPEG_Wrapper.Forms.FormUtils.CustomTextBox();
            this.prefixBox = new FFMPEG_Wrapper.Forms.FormUtils.CustomTextBox();
            this.autoNamingBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.videoPanel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.presetCombo = new FFMPEG_Wrapper.Forms.FormUtils.RoundedComboBox();
            this.presetLabel = new System.Windows.Forms.Label();
            this.videoCodecLabel = new System.Windows.Forms.Label();
            this.videocodecCombo = new FFMPEG_Wrapper.Forms.FormUtils.RoundedComboBox();
            this.bitrateBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.bitrateNumeric = new FFMPEG_Wrapper.Forms.FormUtils.CustomNumeric();
            this.bitrateHelperLabel = new System.Windows.Forms.Label();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.horFlipBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.verFlipBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.customHeightBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.customWidthBox = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.customHeightLabel = new System.Windows.Forms.Label();
            this.customWidthLabel = new System.Windows.Forms.Label();
            this.customHeightNumeric = new FFMPEG_Wrapper.Forms.FormUtils.CustomNumeric();
            this.customWidthNumeric = new FFMPEG_Wrapper.Forms.FormUtils.CustomNumeric();
            this.saveAspectButton = new FFMPEG_Wrapper.Forms.FormUtils.ToggleButton();
            this.tipPanel = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.layoutPanel.SuspendLayout();
            this.miscPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.videoPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customWidthNumeric)).BeginInit();
            this.tipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Controls.Add(this.miscPanel, 1, 0);
            this.layoutPanel.Controls.Add(this.videoPanel, 0, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Size = new System.Drawing.Size(1488, 718);
            this.layoutPanel.TabIndex = 2;
            // 
            // miscPanel
            // 
            this.miscPanel.AutoSize = true;
            this.miscPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.BorderRadius = 5;
            this.miscPanel.BorderWidth = 1F;
            this.miscPanel.Controls.Add(this.concatButton);
            this.miscPanel.Controls.Add(this.startButton);
            this.miscPanel.Controls.Add(this.tableLayoutPanel3);
            this.miscPanel.Controls.Add(this.tableLayoutPanel2);
            this.miscPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.miscPanel.Location = new System.Drawing.Point(748, 4);
            this.miscPanel.Margin = new System.Windows.Forms.Padding(4);
            this.miscPanel.Name = "miscPanel";
            this.miscPanel.OffsetXBottom = 25;
            this.miscPanel.OffsetXTop = 25;
            this.miscPanel.OffsetYBottom = 25;
            this.miscPanel.OffsetYTop = 25;
            this.miscPanel.Size = new System.Drawing.Size(736, 710);
            this.miscPanel.TabIndex = 1;
            // 
            // concatButton
            // 
            this.concatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.concatButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.concatButton.BorderColor = System.Drawing.Color.Crimson;
            this.concatButton.BorderRadius = 9;
            this.concatButton.BorderSize = 2;
            this.concatButton.FlatAppearance.BorderSize = 0;
            this.concatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concatButton.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.concatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.concatButton.Location = new System.Drawing.Point(24, 619);
            this.concatButton.Margin = new System.Windows.Forms.Padding(4);
            this.concatButton.Name = "concatButton";
            this.concatButton.Size = new System.Drawing.Size(679, 56);
            this.concatButton.TabIndex = 38;
            this.concatButton.Text = "Reencode N files...";
            this.concatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.concatButton.UseVisualStyleBackColor = false;
            this.concatButton.Click += new System.EventHandler(this.concatButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.startButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.startButton.BorderColor = System.Drawing.Color.Crimson;
            this.startButton.BorderRadius = 9;
            this.startButton.BorderSize = 2;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.startButton.Location = new System.Drawing.Point(25, 554);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(679, 56);
            this.startButton.TabIndex = 37;
            this.startButton.Text = "Reencode N files...";
            this.startButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 507F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.selectSavePathButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.defaultSavePathBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.savePathLabel, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 265);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(683, 123);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 52);
            this.label1.TabIndex = 37;
            this.label1.Text = "Save folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectSavePathButton
            // 
            this.selectSavePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectSavePathButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectSavePathButton.BorderColor = System.Drawing.Color.Crimson;
            this.selectSavePathButton.BorderRadius = 9;
            this.selectSavePathButton.BorderSize = 2;
            this.selectSavePathButton.FlatAppearance.BorderSize = 0;
            this.selectSavePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSavePathButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectSavePathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectSavePathButton.Location = new System.Drawing.Point(511, 56);
            this.selectSavePathButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectSavePathButton.Name = "selectSavePathButton";
            this.selectSavePathButton.Size = new System.Drawing.Size(167, 56);
            this.selectSavePathButton.TabIndex = 36;
            this.selectSavePathButton.Text = "Select...";
            this.selectSavePathButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.selectSavePathButton.UseVisualStyleBackColor = false;
            this.selectSavePathButton.Click += new System.EventHandler(this.selectSavePathButton_Click);
            // 
            // defaultSavePathBox
            // 
            this.defaultSavePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultSavePathBox.Checked = true;
            this.defaultSavePathBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultSavePathBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultSavePathBox.ForeColor = System.Drawing.Color.White;
            this.defaultSavePathBox.Location = new System.Drawing.Point(511, 10);
            this.defaultSavePathBox.Margin = new System.Windows.Forms.Padding(4);
            this.defaultSavePathBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.defaultSavePathBox.Name = "defaultSavePathBox";
            this.defaultSavePathBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.defaultSavePathBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.defaultSavePathBox.OnBackColor = System.Drawing.Color.Crimson;
            this.defaultSavePathBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.defaultSavePathBox.Size = new System.Drawing.Size(168, 31);
            this.defaultSavePathBox.TabIndex = 35;
            this.defaultSavePathBox.Text = "Default";
            this.defaultSavePathBox.ToggleWidth = 50;
            this.defaultSavePathBox.UseVisualStyleBackColor = true;
            this.defaultSavePathBox.CheckedChanged += new System.EventHandler(this.defaultSavePathBox_CheckedChanged);
            // 
            // savePathLabel
            // 
            this.savePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePathLabel.ForeColor = System.Drawing.Color.White;
            this.savePathLabel.Location = new System.Drawing.Point(4, 76);
            this.savePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(499, 22);
            this.savePathLabel.TabIndex = 38;
            this.savePathLabel.Text = "label2";
            this.savePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePathLabel.Click += new System.EventHandler(this.savePathLabel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.Controls.Add(this.audioCodecCombo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.audioCodecLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.extentionLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.extentionCombo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.postfixLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.prefixLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.postfixBox, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.prefixBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.autoNamingBox, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(683, 207);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // audioCodecCombo
            // 
            this.audioCodecCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.audioCodecCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.audioCodecCombo.BorderColor = System.Drawing.Color.Crimson;
            this.audioCodecCombo.BorderSize = 1;
            this.audioCodecCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.audioCodecCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.audioCodecCombo.ForeColor = System.Drawing.Color.White;
            this.audioCodecCombo.IconColor = System.Drawing.Color.Crimson;
            this.audioCodecCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.audioCodecCombo.ListTextColor = System.Drawing.Color.White;
            this.audioCodecCombo.Location = new System.Drawing.Point(185, 7);
            this.audioCodecCombo.Margin = new System.Windows.Forms.Padding(4);
            this.audioCodecCombo.MinimumSize = new System.Drawing.Size(1, 1);
            this.audioCodecCombo.Name = "audioCodecCombo";
            this.audioCodecCombo.Padding = new System.Windows.Forms.Padding(1);
            this.audioCodecCombo.Size = new System.Drawing.Size(187, 37);
            this.audioCodecCombo.TabIndex = 31;
            this.audioCodecCombo.Texts = "";
            this.audioCodecCombo.OnSelectedIndexChanged += new System.EventHandler(this.audioCodecCombo_OnSelectedIndexChanged);
            // 
            // audioCodecLabel
            // 
            this.audioCodecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.audioCodecLabel.AutoSize = true;
            this.audioCodecLabel.BackColor = System.Drawing.Color.Transparent;
            this.audioCodecLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.audioCodecLabel.ForeColor = System.Drawing.Color.White;
            this.audioCodecLabel.Location = new System.Drawing.Point(4, 14);
            this.audioCodecLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.audioCodecLabel.Name = "audioCodecLabel";
            this.audioCodecLabel.Size = new System.Drawing.Size(173, 22);
            this.audioCodecLabel.TabIndex = 12;
            this.audioCodecLabel.Text = "Audio codec";
            // 
            // extentionLabel
            // 
            this.extentionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.extentionLabel.BackColor = System.Drawing.Color.Transparent;
            this.extentionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.extentionLabel.ForeColor = System.Drawing.Color.White;
            this.extentionLabel.Location = new System.Drawing.Point(4, 61);
            this.extentionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extentionLabel.Name = "extentionLabel";
            this.extentionLabel.Size = new System.Drawing.Size(173, 24);
            this.extentionLabel.TabIndex = 13;
            this.extentionLabel.Text = "Output extension";
            this.extentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extentionCombo
            // 
            this.extentionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extentionCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.extentionCombo.BorderColor = System.Drawing.Color.Crimson;
            this.extentionCombo.BorderSize = 1;
            this.extentionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.extentionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extentionCombo.ForeColor = System.Drawing.Color.White;
            this.extentionCombo.IconColor = System.Drawing.Color.Crimson;
            this.extentionCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.extentionCombo.ListTextColor = System.Drawing.Color.White;
            this.extentionCombo.Location = new System.Drawing.Point(185, 55);
            this.extentionCombo.Margin = new System.Windows.Forms.Padding(4);
            this.extentionCombo.MinimumSize = new System.Drawing.Size(1, 1);
            this.extentionCombo.Name = "extentionCombo";
            this.extentionCombo.Padding = new System.Windows.Forms.Padding(1);
            this.extentionCombo.Size = new System.Drawing.Size(187, 37);
            this.extentionCombo.TabIndex = 32;
            this.extentionCombo.Texts = "";
            this.extentionCombo.OnSelectedIndexChanged += new System.EventHandler(this.extentionCombo_OnSelectedIndexChanged);
            // 
            // postfixLabel
            // 
            this.postfixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postfixLabel.AutoSize = true;
            this.postfixLabel.BackColor = System.Drawing.Color.Transparent;
            this.postfixLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.postfixLabel.ForeColor = System.Drawing.Color.White;
            this.postfixLabel.Location = new System.Drawing.Point(380, 120);
            this.postfixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postfixLabel.Name = "postfixLabel";
            this.postfixLabel.Size = new System.Drawing.Size(165, 22);
            this.postfixLabel.TabIndex = 15;
            this.postfixLabel.Text = "Postfix";
            // 
            // prefixLabel
            // 
            this.prefixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.BackColor = System.Drawing.Color.Transparent;
            this.prefixLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prefixLabel.ForeColor = System.Drawing.Color.White;
            this.prefixLabel.Location = new System.Drawing.Point(185, 120);
            this.prefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(187, 22);
            this.prefixLabel.TabIndex = 14;
            this.prefixLabel.Text = "Prefix";
            // 
            // postfixBox
            // 
            this.postfixBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postfixBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.postfixBox.BorderColor = System.Drawing.Color.Crimson;
            this.postfixBox.BorderFocusColor = System.Drawing.Color.White;
            this.postfixBox.BorderRadius = 0;
            this.postfixBox.BorderSize = 1;
            this.postfixBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.postfixBox.ForeColor = System.Drawing.Color.White;
            this.postfixBox.Location = new System.Drawing.Point(382, 155);
            this.postfixBox.Margin = new System.Windows.Forms.Padding(6);
            this.postfixBox.Multiline = false;
            this.postfixBox.Name = "postfixBox";
            this.postfixBox.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.postfixBox.PasswordChar = false;
            this.postfixBox.PlaceholderColor = System.Drawing.Color.White;
            this.postfixBox.PlaceholderText = "";
            this.postfixBox.Size = new System.Drawing.Size(161, 43);
            this.postfixBox.TabIndex = 34;
            this.postfixBox.Texts = "";
            this.postfixBox.UnderlinedStyle = false;
            // 
            // prefixBox
            // 
            this.prefixBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prefixBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.prefixBox.BorderColor = System.Drawing.Color.Crimson;
            this.prefixBox.BorderFocusColor = System.Drawing.Color.White;
            this.prefixBox.BorderRadius = 0;
            this.prefixBox.BorderSize = 1;
            this.prefixBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prefixBox.ForeColor = System.Drawing.Color.White;
            this.prefixBox.Location = new System.Drawing.Point(187, 155);
            this.prefixBox.Margin = new System.Windows.Forms.Padding(6);
            this.prefixBox.Multiline = false;
            this.prefixBox.Name = "prefixBox";
            this.prefixBox.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.prefixBox.PasswordChar = false;
            this.prefixBox.PlaceholderColor = System.Drawing.Color.White;
            this.prefixBox.PlaceholderText = "";
            this.prefixBox.Size = new System.Drawing.Size(183, 43);
            this.prefixBox.TabIndex = 33;
            this.prefixBox.Texts = "";
            this.prefixBox.UnderlinedStyle = false;
            // 
            // autoNamingBox
            // 
            this.autoNamingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoNamingBox.Checked = true;
            this.autoNamingBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoNamingBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoNamingBox.ForeColor = System.Drawing.Color.White;
            this.autoNamingBox.Location = new System.Drawing.Point(4, 162);
            this.autoNamingBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoNamingBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.autoNamingBox.Name = "autoNamingBox";
            this.autoNamingBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.autoNamingBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.autoNamingBox.OnBackColor = System.Drawing.Color.Crimson;
            this.autoNamingBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.autoNamingBox.Size = new System.Drawing.Size(173, 31);
            this.autoNamingBox.TabIndex = 35;
            this.autoNamingBox.Text = "Auto";
            this.autoNamingBox.ToggleWidth = 50;
            this.autoNamingBox.UseVisualStyleBackColor = true;
            this.autoNamingBox.CheckedChanged += new System.EventHandler(this.autoNamingBox_CheckedChanged);
            // 
            // videoPanel
            // 
            this.videoPanel.AutoSize = true;
            this.videoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.videoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.videoPanel.BorderRadius = 5;
            this.videoPanel.BorderWidth = 1F;
            this.videoPanel.Controls.Add(this.tableLayoutPanel1);
            this.videoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.videoPanel.ForeColor = System.Drawing.Color.White;
            this.videoPanel.Location = new System.Drawing.Point(4, 4);
            this.videoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.OffsetXBottom = 25;
            this.videoPanel.OffsetXTop = 25;
            this.videoPanel.OffsetYBottom = 25;
            this.videoPanel.OffsetYTop = 25;
            this.videoPanel.Size = new System.Drawing.Size(736, 710);
            this.videoPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.presetCombo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.presetLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoCodecLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.videocodecCombo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bitrateBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bitrateNumeric, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bitrateHelperLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bitrateLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.horFlipBox, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.verFlipBox, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.customHeightBox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.customWidthBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.customHeightLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.customWidthLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.customHeightNumeric, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.customWidthNumeric, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.saveAspectButton, 0, 6);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 651);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // presetCombo
            // 
            this.presetCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.presetCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.presetCombo.BorderColor = System.Drawing.Color.Crimson;
            this.presetCombo.BorderSize = 1;
            this.presetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.presetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.presetCombo.ForeColor = System.Drawing.Color.White;
            this.presetCombo.IconColor = System.Drawing.Color.Crimson;
            this.presetCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.presetCombo.ListTextColor = System.Drawing.Color.White;
            this.presetCombo.Location = new System.Drawing.Point(256, 49);
            this.presetCombo.Margin = new System.Windows.Forms.Padding(4);
            this.presetCombo.MinimumSize = new System.Drawing.Size(1, 1);
            this.presetCombo.Name = "presetCombo";
            this.presetCombo.Padding = new System.Windows.Forms.Padding(1);
            this.presetCombo.Size = new System.Drawing.Size(179, 37);
            this.presetCombo.TabIndex = 31;
            this.presetCombo.Texts = "";
            this.presetCombo.OnSelectedIndexChanged += new System.EventHandler(this.presetCombo_OnSelectedIndexChanged);
            // 
            // presetLabel
            // 
            this.presetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetLabel.AutoSize = true;
            this.presetLabel.BackColor = System.Drawing.Color.Transparent;
            this.presetLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.presetLabel.ForeColor = System.Drawing.Color.White;
            this.presetLabel.Location = new System.Drawing.Point(4, 45);
            this.presetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(244, 45);
            this.presetLabel.TabIndex = 4;
            this.presetLabel.Text = "Preset";
            this.presetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoCodecLabel
            // 
            this.videoCodecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoCodecLabel.AutoSize = true;
            this.videoCodecLabel.BackColor = System.Drawing.Color.Transparent;
            this.videoCodecLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.videoCodecLabel.ForeColor = System.Drawing.Color.White;
            this.videoCodecLabel.Location = new System.Drawing.Point(4, 0);
            this.videoCodecLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.videoCodecLabel.Name = "videoCodecLabel";
            this.videoCodecLabel.Size = new System.Drawing.Size(244, 45);
            this.videoCodecLabel.TabIndex = 10;
            this.videoCodecLabel.Text = "Video codec";
            this.videoCodecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videocodecCombo
            // 
            this.videocodecCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videocodecCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.videocodecCombo.BorderColor = System.Drawing.Color.Crimson;
            this.videocodecCombo.BorderSize = 1;
            this.videocodecCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.videocodecCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.videocodecCombo.ForeColor = System.Drawing.Color.White;
            this.videocodecCombo.IconColor = System.Drawing.Color.Crimson;
            this.videocodecCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.videocodecCombo.ListTextColor = System.Drawing.Color.White;
            this.videocodecCombo.Location = new System.Drawing.Point(256, 4);
            this.videocodecCombo.Margin = new System.Windows.Forms.Padding(4);
            this.videocodecCombo.MinimumSize = new System.Drawing.Size(1, 1);
            this.videocodecCombo.Name = "videocodecCombo";
            this.videocodecCombo.Padding = new System.Windows.Forms.Padding(1);
            this.videocodecCombo.Size = new System.Drawing.Size(179, 37);
            this.videocodecCombo.TabIndex = 30;
            this.videocodecCombo.Texts = "";
            this.videocodecCombo.OnSelectedIndexChanged += new System.EventHandler(this.videocodecCombo_OnSelectedIndexChanged);
            // 
            // bitrateBox
            // 
            this.bitrateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitrateBox.ForeColor = System.Drawing.Color.White;
            this.bitrateBox.Location = new System.Drawing.Point(4, 137);
            this.bitrateBox.Margin = new System.Windows.Forms.Padding(4);
            this.bitrateBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.bitrateBox.Name = "bitrateBox";
            this.bitrateBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.bitrateBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.bitrateBox.OnBackColor = System.Drawing.Color.Crimson;
            this.bitrateBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.bitrateBox.Size = new System.Drawing.Size(244, 31);
            this.bitrateBox.TabIndex = 38;
            this.bitrateBox.Text = "Change bitrate";
            this.bitrateBox.ToggleWidth = 50;
            this.bitrateBox.UseVisualStyleBackColor = true;
            this.bitrateBox.CheckedChanged += new System.EventHandler(this.bitrateBox_CheckedChanged);
            // 
            // bitrateNumeric
            // 
            this.bitrateNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.bitrateNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bitrateNumeric.Enabled = false;
            this.bitrateNumeric.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitrateNumeric.ForeColor = System.Drawing.Color.White;
            this.bitrateNumeric.Location = new System.Drawing.Point(443, 132);
            this.bitrateNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.bitrateNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.bitrateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitrateNumeric.Name = "bitrateNumeric";
            this.bitrateNumeric.Size = new System.Drawing.Size(178, 30);
            this.bitrateNumeric.TabIndex = 35;
            this.bitrateNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bitrateNumeric.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.bitrateNumeric.ValueChanged += new System.EventHandler(this.bitrateNumeric_ValueChanged);
            this.bitrateNumeric.Enter += new System.EventHandler(this.bitrateNumeric_Enter);
            // 
            // bitrateHelperLabel
            // 
            this.bitrateHelperLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateHelperLabel.AutoSize = true;
            this.bitrateHelperLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitrateHelperLabel.Location = new System.Drawing.Point(443, 177);
            this.bitrateHelperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitrateHelperLabel.Name = "bitrateHelperLabel";
            this.bitrateHelperLabel.Size = new System.Drawing.Size(190, 28);
            this.bitrateHelperLabel.TabIndex = 11;
            this.bitrateHelperLabel.Text = "-";
            this.bitrateHelperLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.BackColor = System.Drawing.Color.Transparent;
            this.bitrateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bitrateLabel.ForeColor = System.Drawing.Color.White;
            this.bitrateLabel.Location = new System.Drawing.Point(257, 128);
            this.bitrateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(177, 49);
            this.bitrateLabel.TabIndex = 2;
            this.bitrateLabel.Text = "New bitrate, Kbit/s";
            this.bitrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horFlipBox
            // 
            this.horFlipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.horFlipBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horFlipBox.Location = new System.Drawing.Point(4, 603);
            this.horFlipBox.Margin = new System.Windows.Forms.Padding(4);
            this.horFlipBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.horFlipBox.Name = "horFlipBox";
            this.horFlipBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.horFlipBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.horFlipBox.OnBackColor = System.Drawing.Color.Crimson;
            this.horFlipBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.horFlipBox.Size = new System.Drawing.Size(244, 32);
            this.horFlipBox.TabIndex = 28;
            this.horFlipBox.Text = "Horizontal flip";
            this.horFlipBox.ToggleWidth = 50;
            this.horFlipBox.UseVisualStyleBackColor = true;
            // 
            // verFlipBox
            // 
            this.verFlipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.verFlipBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verFlipBox.Location = new System.Drawing.Point(4, 545);
            this.verFlipBox.Margin = new System.Windows.Forms.Padding(4);
            this.verFlipBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.verFlipBox.Name = "verFlipBox";
            this.verFlipBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.verFlipBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.verFlipBox.OnBackColor = System.Drawing.Color.Crimson;
            this.verFlipBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.verFlipBox.Size = new System.Drawing.Size(244, 32);
            this.verFlipBox.TabIndex = 32;
            this.verFlipBox.Text = "Vertical flip";
            this.verFlipBox.ToggleWidth = 50;
            this.verFlipBox.UseVisualStyleBackColor = true;
            // 
            // customHeightBox
            // 
            this.customHeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customHeightBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customHeightBox.Location = new System.Drawing.Point(4, 492);
            this.customHeightBox.Margin = new System.Windows.Forms.Padding(4);
            this.customHeightBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.customHeightBox.Name = "customHeightBox";
            this.customHeightBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.customHeightBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customHeightBox.OnBackColor = System.Drawing.Color.Crimson;
            this.customHeightBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customHeightBox.Size = new System.Drawing.Size(244, 31);
            this.customHeightBox.TabIndex = 33;
            this.customHeightBox.Text = "Set custom height";
            this.customHeightBox.ToggleWidth = 50;
            this.customHeightBox.UseVisualStyleBackColor = true;
            this.customHeightBox.CheckedChanged += new System.EventHandler(this.customHeightBox_CheckedChanged);
            // 
            // customWidthBox
            // 
            this.customWidthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customWidthBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customWidthBox.Location = new System.Drawing.Point(4, 440);
            this.customWidthBox.Margin = new System.Windows.Forms.Padding(4);
            this.customWidthBox.MinimumSize = new System.Drawing.Size(63, 31);
            this.customWidthBox.Name = "customWidthBox";
            this.customWidthBox.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.customWidthBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customWidthBox.OnBackColor = System.Drawing.Color.Crimson;
            this.customWidthBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customWidthBox.Size = new System.Drawing.Size(244, 31);
            this.customWidthBox.TabIndex = 34;
            this.customWidthBox.Text = "Set custom width";
            this.customWidthBox.ToggleWidth = 50;
            this.customWidthBox.UseVisualStyleBackColor = true;
            this.customWidthBox.CheckedChanged += new System.EventHandler(this.customWidthBox_CheckedChanged);
            // 
            // customHeightLabel
            // 
            this.customHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customHeightLabel.AutoSize = true;
            this.customHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.customHeightLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.customHeightLabel.ForeColor = System.Drawing.Color.White;
            this.customHeightLabel.Location = new System.Drawing.Point(256, 482);
            this.customHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customHeightLabel.Name = "customHeightLabel";
            this.customHeightLabel.Size = new System.Drawing.Size(179, 52);
            this.customHeightLabel.TabIndex = 16;
            this.customHeightLabel.Text = "Height";
            this.customHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customWidthLabel
            // 
            this.customWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customWidthLabel.AutoSize = true;
            this.customWidthLabel.BackColor = System.Drawing.Color.Transparent;
            this.customWidthLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.customWidthLabel.ForeColor = System.Drawing.Color.White;
            this.customWidthLabel.Location = new System.Drawing.Point(256, 429);
            this.customWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customWidthLabel.Name = "customWidthLabel";
            this.customWidthLabel.Size = new System.Drawing.Size(179, 53);
            this.customWidthLabel.TabIndex = 15;
            this.customWidthLabel.Text = "Width";
            this.customWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customHeightNumeric
            // 
            this.customHeightNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customHeightNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.customHeightNumeric.Enabled = false;
            this.customHeightNumeric.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customHeightNumeric.ForeColor = System.Drawing.Color.White;
            this.customHeightNumeric.Location = new System.Drawing.Point(443, 493);
            this.customHeightNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.customHeightNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.customHeightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customHeightNumeric.Name = "customHeightNumeric";
            this.customHeightNumeric.Size = new System.Drawing.Size(87, 30);
            this.customHeightNumeric.TabIndex = 37;
            this.customHeightNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customHeightNumeric.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // customWidthNumeric
            // 
            this.customWidthNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customWidthNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.customWidthNumeric.Enabled = false;
            this.customWidthNumeric.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customWidthNumeric.ForeColor = System.Drawing.Color.White;
            this.customWidthNumeric.Location = new System.Drawing.Point(443, 440);
            this.customWidthNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.customWidthNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.customWidthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customWidthNumeric.Name = "customWidthNumeric";
            this.customWidthNumeric.Size = new System.Drawing.Size(87, 30);
            this.customWidthNumeric.TabIndex = 36;
            this.customWidthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customWidthNumeric.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // saveAspectButton
            // 
            this.saveAspectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAspectButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveAspectButton.Location = new System.Drawing.Point(4, 385);
            this.saveAspectButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveAspectButton.MinimumSize = new System.Drawing.Size(63, 31);
            this.saveAspectButton.Name = "saveAspectButton";
            this.saveAspectButton.OffBackColor = System.Drawing.SystemColors.ControlDark;
            this.saveAspectButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.saveAspectButton.OnBackColor = System.Drawing.Color.Crimson;
            this.saveAspectButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.saveAspectButton.Size = new System.Drawing.Size(244, 31);
            this.saveAspectButton.TabIndex = 39;
            this.saveAspectButton.Text = "Save aspect ratio";
            this.saveAspectButton.ToggleWidth = 50;
            this.saveAspectButton.UseVisualStyleBackColor = true;
            this.saveAspectButton.CheckedChanged += new System.EventHandler(this.saveAspectButton_CheckedChanged);
            // 
            // tipPanel
            // 
            this.tipPanel.BackColor = System.Drawing.Color.Transparent;
            this.tipPanel.BorderColor = System.Drawing.Color.Crimson;
            this.tipPanel.BorderRadius = 5;
            this.tipPanel.BorderWidth = 1F;
            this.tipPanel.Controls.Add(this.tipTextBox);
            this.tipPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tipPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tipPanel.Location = new System.Drawing.Point(0, 718);
            this.tipPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tipPanel.Name = "tipPanel";
            this.tipPanel.OffsetXBottom = 25;
            this.tipPanel.OffsetXTop = 25;
            this.tipPanel.OffsetYBottom = 25;
            this.tipPanel.OffsetYTop = 25;
            this.tipPanel.Size = new System.Drawing.Size(1488, 161);
            this.tipPanel.TabIndex = 20;
            // 
            // tipTextBox
            // 
            this.tipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tipTextBox.ForeColor = System.Drawing.Color.White;
            this.tipTextBox.Location = new System.Drawing.Point(55, 46);
            this.tipTextBox.Margin = new System.Windows.Forms.Padding(21);
            this.tipTextBox.Multiline = true;
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.ReadOnly = true;
            this.tipTextBox.Size = new System.Drawing.Size(1377, 71);
            this.tipTextBox.TabIndex = 19;
            this.tipTextBox.Text = "При изменении только ширины/высоты второй параметр определяется в соответсвии с с" +
    "оотношением сторон входного файла\r\n\r\nНапример: входное видео 1280x720, заменим ш" +
    "ирину на 320 ---> 320x180\r\n\r\n";
            // 
            // OutputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(136F, 136F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.tipPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OutputPanel";
            this.Size = new System.Drawing.Size(1488, 879);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.miscPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.videoPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customWidthNumeric)).EndInit();
            this.tipPanel.ResumeLayout(false);
            this.tipPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private Forms.FormUtils.SmoothPanel miscPanel;
        private Forms.FormUtils.SmoothPanel videoPanel;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.Label customHeightLabel;
        private System.Windows.Forms.Label customWidthLabel;
        private System.Windows.Forms.Label presetLabel;
        private System.Windows.Forms.Label videoCodecLabel;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Label audioCodecLabel;
        private System.Windows.Forms.Label postfixLabel;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label extentionLabel;
        private Forms.FormUtils.SmoothPanel tipPanel;
        private Forms.FormUtils.RoundedComboBox presetCombo;
        private Forms.FormUtils.RoundedComboBox videocodecCombo;
        private Forms.FormUtils.ToggleButton horFlipBox;
        private Forms.FormUtils.ToggleButton customWidthBox;
        private Forms.FormUtils.ToggleButton customHeightBox;
        private Forms.FormUtils.ToggleButton verFlipBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Forms.FormUtils.RoundedComboBox audioCodecCombo;
        private Forms.FormUtils.RoundedComboBox extentionCombo;
        private Forms.FormUtils.CustomTextBox prefixBox;
        private Forms.FormUtils.CustomTextBox postfixBox;
        private System.Windows.Forms.Label bitrateHelperLabel;
        private Forms.FormUtils.CustomNumeric bitrateNumeric;
        private Forms.FormUtils.CustomNumeric customWidthNumeric;
        private Forms.FormUtils.CustomNumeric customHeightNumeric;
        private Forms.FormUtils.ToggleButton autoNamingBox;
        private Forms.FormUtils.ToggleButton bitrateBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private RJButton selectSavePathButton;
        private Forms.FormUtils.ToggleButton defaultSavePathBox;
        private System.Windows.Forms.Label savePathLabel;
        private RJButton startButton;
        private RJButton concatButton;
        private Forms.FormUtils.ToggleButton saveAspectButton;
    }
}
