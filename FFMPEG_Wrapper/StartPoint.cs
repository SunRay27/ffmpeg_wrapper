using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FFMPEG_Wrapper
{
    static class StartPoint
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileManager manager = new FileManager();

            //not first start...
            if (XMLSerializer.Exist(Config.ConfigFileName))
            {
                Config config = XMLSerializer.Load<Config>(Config.ConfigFileName);
                config.Load();
            }
            else
            {
                Config config = new Config();
                config.Init();
            }
            

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            Thread.CurrentThread.CurrentCulture = customCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
