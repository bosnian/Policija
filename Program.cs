using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policija
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

            Login form = new Login();
            Application.Run(form);
            
            if(form.logiran == true)
                Application.Run(new App());
        }
    }
}
