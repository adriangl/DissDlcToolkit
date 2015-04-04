using DissDlcToolkit.Utils;
using DissDlcToolkit.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #if RELEASE
            // Setup UnhandledException handler
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new
              UnhandledExceptionEventHandler(Application_UnhandledException);
            #endif
            // Run the app
            Application.Run(new MainForm());
        }

        private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Application_handleException((Exception)e.ExceptionObject);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Application_handleException(e.Exception);
        }

        private static void Application_handleException(Exception e)
        {
            MessageBoxEx.Show(System.Windows.Forms.Application.OpenForms[0], "An unhandled exception has been found.\r\n" +
                            "Please report the error with the contents of the file \"log.txt\"", "ERROR");
            Logger.Log("Application", e);
            Application.Exit();
        }
    }
}
