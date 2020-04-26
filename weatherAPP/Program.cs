using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace weatherAPP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
			API_caller.initClient(); 
            Application.EnableVisualStyles();

            Application.ThreadException +=
                new ThreadExceptionEventHandler(UI_ThreadExcetion);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(Non_UI_ThreadException);

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lockScreen());
        }

        private static void UI_ThreadExcetion(object sender, ThreadExceptionEventArgs e)
        {
            var notification = new notification.network_error();
            notification.StartPosition = FormStartPosition.CenterScreen;

            DialogResult res_dialog = notification.ShowDialog();

            if (res_dialog == DialogResult.OK)
            {
                Application.Restart(); 
            }
        }

        private static void Non_UI_ThreadException(object sender,
            UnhandledExceptionEventArgs e)
        {
			var notification = new notification.network_error();
            notification.StartPosition = FormStartPosition.CenterScreen;

            DialogResult res_dialog = notification.ShowDialog();

            if (res_dialog == DialogResult.OK)
            {
                Application.Restart(); 
            }
        }
    }
}
