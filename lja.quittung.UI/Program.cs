using System;
using System.Windows.Forms;

namespace lja.quittung.UI
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var quittungControl = new QuittungControl())
            {
                Application.Run(quittungControl);
            }
        }
    }
}
