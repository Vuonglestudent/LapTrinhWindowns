using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMonHoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public frmMain mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new frmMain();
            Application.Run(mainForm);
        }
    }
}
