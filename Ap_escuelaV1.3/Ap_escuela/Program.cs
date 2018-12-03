using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ap_escuela
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

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Application.Run(new Autentificacion());
        }
    }
}
