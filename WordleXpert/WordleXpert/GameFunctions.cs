using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleXpert
{
    internal class GameFunctions
    {
        public Form GameForm;

        public GameFunctions(Form gameForm)
        {
            GameForm = gameForm;
        }

        public void DisplayWin()
        {
            Program.IsInGame = false;
            Program.DisableHardMode = false;

            // update stats
            // total games played, win percentage, how many guesses
            Program.TotalGamesPlayed++;
            Program.TotalWins++;
            Program.WinPercentage = (double)Program.TotalWins / Program.TotalGamesPlayed * 100;
            Program.SaveUserStats();


            // display window
            using (var formWin = new FormWin())
            {
                formWin.StartPosition = FormStartPosition.CenterParent;
                formWin.FormClosing += delegate { GameForm.Close(); };
                formWin.ShowDialog();
            }
        }

        public void DisplayLose(string answer)
        {
            Program.IsInGame = false;
            Program.DisableHardMode = false;

            // update stats
            // total games played, win percentage
            Program.TotalGamesPlayed++;
            Program.WinPercentage = (double)Program.TotalWins / Program.TotalGamesPlayed * 100;
            Program.SaveUserStats();

            // display window
            using (var formLose = new FormLose(answer))
            {
                formLose.StartPosition = FormStartPosition.CenterParent;
                formLose.FormClosing += delegate { GameForm.Close(); };
                formLose.ShowDialog();
            }
        }

        public void DisplaySettings()
        {
            using (var formSettings = new FormSettings())
            {
                formSettings.StartPosition = FormStartPosition.CenterParent;
                var result = formSettings.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    Program.IsInGame = false;
                    Program.DisableHardMode = false;
                    GameForm.Close();
                }
            }
        }
    }
}
