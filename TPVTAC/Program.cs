using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPVTAC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }

        static void Start()
        {
            //Application.Run(new fBackgroundWhite());
            fBackgroundWhite fback = new fBackgroundWhite();
            if (fback.ShowDialog() == DialogResult.OK)
            { 
                Application.Run(new ftpvt());
            }
        }
    }
}
