using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleXpert
{
    internal static class Program
    {
        public static string Language = "English";
        public static int WordLength = 5;
        public static bool IsInGame = false;
        public static bool IsHardMode = false;
        public static bool DisableHardMode = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStartMenu());
        }
    }
}
