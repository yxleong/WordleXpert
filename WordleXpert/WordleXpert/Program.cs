using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordleXpert
{
    internal static class Program
    {
        public static string Language = "English";
        public static int WordLength = 5;
        public static bool IsInGame = false;
        public static bool IsHardMode = false;
        public static bool DisableHardMode = false;

        public static string User = "Guest";
        public static int TotalGamesPlayed = 0;
        public static int TotalWins = 0;
        public static double WinPercentage = 0;

        public static void SaveUserStats()
        {
            if (User == "Guest")
            {
                return;
            }

            string statsFilePath = $"{User}_stats.txt";
            string statsContent = $"{TotalGamesPlayed}|{TotalWins}|{WinPercentage}";
            File.WriteAllText(statsFilePath, statsContent);
        }

        public static void LoadUserStats()
        {
            if (User == "Guest")
            {
                TotalGamesPlayed = 0;
                TotalWins = 0;
                WinPercentage = 0;
                return;
            }

            string statsFilePath = $"{User}_stats.txt";
            if (File.Exists(statsFilePath))
            {
                string statsContent = File.ReadAllText(statsFilePath);
                var parts = statsContent.Split('|');
                TotalGamesPlayed = int.Parse(parts[0]);
                TotalWins = int.Parse(parts[1]);
                WinPercentage = double.Parse(parts[2]);
            }
            else
            {
                TotalGamesPlayed = 0;
                TotalWins = 0;
                WinPercentage = 0;

                SaveUserStats();
            }
        }

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
