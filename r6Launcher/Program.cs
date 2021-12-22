using System;
using System.Windows.Forms;

namespace r6Launcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log.WriteLog("R6Launcher Started");
            Application.Run(new Main());
            Log.WriteLog("R6Launcher Exited");
        }
    }
}
