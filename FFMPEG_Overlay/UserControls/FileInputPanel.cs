using FFMPEG_Overlay.Forms.FormUtils;
using System.Windows.Forms;

namespace FFMPEG_Overlay.UserControls
{
    public partial class FileInputPanel : UserControl
    {
        public FileInputPanel()
        {
            InitializeComponent();
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            ShowDropPanel(false);
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            ShowDropPanel(true);

            //firstly check file extension
            e.Effect = DragDropEffects.Link;
            
        }

        private void dropPanel_DragLeave(object sender, System.EventArgs e)
        {
            ShowDropPanel(false);
        }

        void ShowDropPanel(bool newVal)
        {
            fileTable.Visible = !newVal;
            fileTable.Enabled = !newVal;
        }
    }
}
