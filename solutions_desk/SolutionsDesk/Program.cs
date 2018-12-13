using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace solutions_desk
{
    static class Program
    {
        public static int idOperadorLogado;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
