using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADF.UCM.Demo.HIC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Modif my comment
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTest());
        }
    }
}