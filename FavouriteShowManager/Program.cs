using System;
using System.Drawing;
using System.Windows.Forms;

namespace FavouriteShowManager
{

    static class Program
    {

        public static Window window;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Window();
            window.WindowState = FormWindowState.Maximized;
            Application.Run(window);
        }
    }
}
