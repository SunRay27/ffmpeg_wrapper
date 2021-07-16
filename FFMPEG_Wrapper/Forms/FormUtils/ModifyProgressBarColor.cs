using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FFMPEG_Wrapper
{
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        /// <summary>
        /// 1 = green
        /// 2 = red
        /// 3 = yellow
        /// </summary>
        /// <param name="pBar"></param>
        /// <param name="state"></param>
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
