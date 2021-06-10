using System;
using System.Windows.Forms;

namespace Notes
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_Form prog = new Main_Form();
            Application.Run(prog);
        }
    }
}