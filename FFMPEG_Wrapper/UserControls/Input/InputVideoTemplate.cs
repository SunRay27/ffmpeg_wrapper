using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.Drawing;
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
        private FileManager.InputFile inputFile;
        public InputVideoTemplate()
        {
            InitializeComponent();
            //UpdateBorderColor(Selected);

        }

        public void UpdateBorderColor(bool selected)
        {
            this.BackColor = selected ? _checkedBackColor : _uncheckedBackColor;
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //UpdateBorderColor(Selected);
            inputFile.Selected = checkBox.Checked;
        }
        public void ApplyFileInfo(FileManager.InputFile inputFile)
        {
            this.inputFile = inputFile;
            this.fileName.Text = inputFile.GetFileName();
            this.fileFormat.Text = $"{inputFile.GetFileWidth()}x{inputFile.GetFileHeight()} {inputFile.GetFileBitrate()}kbit/s .{inputFile.GetFileExtention()}";
            preview.BackgroundImage = Image.FromFile(inputFile.GetFilePreviewPath());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FileManager.Instance.RemoveFile(inputFile);
            preview.BackgroundImage = null;
            Parent.Controls.Remove(this);
        }
    }
}
