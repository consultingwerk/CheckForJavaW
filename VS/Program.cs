using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        static CheckForJavaW check;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            check = new CheckForJavaW();

            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            Application.Run();
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            check.Exit();
        }
    }
}
