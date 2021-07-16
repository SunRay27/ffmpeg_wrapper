using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.UserControls
{
    public partial class InputVideoTemplate : UserControl
    {
        /*
        public Color CheckedBackColor
        {
            get { return _checkedBackColor; }
            set { _checkedBackColor = value; Invalidate(); }
        }
        public Color UncheckedBackColor
        {
            get { return _uncheckedBackColor; }
            set { _uncheckedBackColor = value; Invalidate(); }
        }*/

        public bool Selected { get { return checkBox.Checked; } }


        private Color _checkedBackColor = Color.LimeGreen;
        private Color _uncheckedBackColor = Color.FromArgb(39, 42, 49);
        public InputVideoTemplate()
        {
            InitializeComponent();
            UpdateBorderColor(Selected);
            
        }

        public void UpdateBorderColor(bool selected)
        {
            this.BackColor = selected? _checkedBackColor : _uncheckedBackColor;
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBorderColor(Selected);
        }
    }
}
