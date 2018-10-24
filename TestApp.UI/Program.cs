using Autofac;
using System;
using System.Windows.Forms;
using TestApp.UI.Startup;

namespace TestApp.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var bootstraper = new BootStraper();
            var container = bootstraper.Bootstrap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());

        }
    }
}
