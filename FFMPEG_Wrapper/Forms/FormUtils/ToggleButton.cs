using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using FFMPEG_Wrapper.UtilityComponents;

namespace FFMPEG_Wrapper.Forms.FormUtils
{
    class ToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;
        private int toggleWidth = 70;


        //Properties
        [Category("RJ Code Advance")]
        public int ToggleWidth
        {
            get { return toggleWidth; }
            set
            {
                toggleWidth = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color OnBackColor
        {
            get { return onBackColor; }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color OffBackColor
        {
            get { return offBackColor; }
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }
        [Browsable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }
        [Category("RJ Code Advance")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }
        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
            
        }
        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(toggleWidth - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //OnBackColor = Constants.ThemeColor;

            //base.OnPaint(pevent);
            int toggleSize = this.Height - 5;
            // Graphics g = pevent.Graphics;
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.Clear(Parent.BackColor);//, new Rectangle(Location.X, Location.Y, Size.Width, Size.Height));

            
            if (this.Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                  new Rectangle(toggleWidth - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }

            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), toggleWidth , Size.Height / 2 - Font.Height/2);
        }
    }
}
