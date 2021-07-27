using FFMPEG_Wrapper.UtilityComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.Forms.FormUtils
{
    public class CustomNumeric : NumericUpDown
    {
        public CustomNumeric()
        {
            //InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            Controls[0].Visible = false ;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if(Enabled)
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Constants.ThemeColor, ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
           // if(Controls.Count)
            Controls[1].Width = Width - 4;
        }
    }
}
