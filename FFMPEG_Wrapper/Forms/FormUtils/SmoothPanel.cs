using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.Forms.FormUtils
{
    public class SmoothPanel : Panel
    {

        #region variables
        private int _offsetXTop = 12;
        private int _offsetXBottom = 12;
        private int _offsetYTop = 12;
        private int _offsetYBottom = 12;
        private float _borderWidth = 0.5f;
        private int _borderRadius = 10;
        private Color _borderColor = Color.Black;
        private Color _fillColor = Color.White;

        #endregion

        #region Properties
        public int OffsetXTop
        {
            get { return _offsetXTop; }
            set { _offsetXTop = value; Invalidate(); }
        }
        public int OffsetXBottom
        {
            get { return _offsetXBottom; }
            set { _offsetXBottom = value; Invalidate(); }
        }
        public int OffsetYTop
        {
            get { return _offsetYTop; }
            set { _offsetYTop = value; Invalidate(); }
        }
        public int OffsetYBottom
        {
            get { return _offsetYBottom; }
            set { _offsetYBottom = value; Invalidate(); }
        }
        public float BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; Invalidate(); }
        }
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }
        public Color FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; Invalidate(); }
        }
        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            //g.FillRoundedRectangle(new SolidBrush(Color.White), 10, 10, this.Width - 40, this.Height - 60, 10);
            // SolidBrush brush = new SolidBrush(Color.White);
            // g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 64, 10);
            g.FillRoundedRectangle(new SolidBrush(_fillColor), _offsetXTop, _offsetYTop, this.Width - (_offsetXTop + _offsetXBottom), this.Height - (_offsetYTop + _offsetYBottom), _borderRadius);
            g.DrawRoundedRectangle(new Pen(_borderColor, _borderWidth), _offsetXTop, _offsetYTop, this.Width - (_offsetXTop + _offsetXBottom), this.Height - (_offsetYTop + _offsetYBottom), _borderRadius);
        }
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Refresh();
        }
    }
}
