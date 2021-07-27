
namespace FFMPEG_Wrapper.UserControls
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
            this.smoothPanel1 = new FFMPEG_Wrapper.Forms.FormUtils.SmoothPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.smoothPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smoothPanel1
            // 
            this.smoothPanel1.AutoSize = true;
            this.smoothPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.smoothPanel1.BorderRadius = 25;
            this.smoothPanel1.BorderWidth = 5F;
            this.smoothPanel1.Controls.Add(this.label8);
            this.smoothPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.smoothPanel1.Location = new System.Drawing.Point(0, 0);
            this.smoothPanel1.Name = "smoothPanel1";
            this.smoothPanel1.OffsetXBottom = 400;
            this.smoothPanel1.OffsetXTop = 400;
            this.smoothPanel1.OffsetYBottom = 200;
            this.smoothPanel1.OffsetYTop = 200;
            this.smoothPanel1.Size = new System.Drawing.Size(1210, 665);
            this.smoothPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1210, 665);
            this.label8.TabIndex = 15;
            this.label8.Text = "NOT IMPLEMENTED";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.smoothPanel1);
            this.Name = "EditPanel";
            this.Size = new System.Drawing.Size(1210, 665);
            this.smoothPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Forms.FormUtils.SmoothPanel smoothPanel1;
        private System.Windows.Forms.Label label8;
    }
}
