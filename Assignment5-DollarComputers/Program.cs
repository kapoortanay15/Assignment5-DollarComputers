using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5_DollarComputers.Views;

namespace Assignment5_DollarComputers
{
    static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            Application.Run(splashForm);
        }
    }
}
