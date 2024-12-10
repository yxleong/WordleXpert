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

        public string CheckWordValid(string guessWord, char[] hintCorrectLetters, string hintExistingLetters)
        {
            string tempGuessWord = guessWord;

            for (int i = 0; i < hintCorrectLetters.Length; i++)
            {
                if (hintCorrectLetters[i] != '*' && guessWord[i] != hintCorrectLetters[i])
                {
                    string num;
                    if (i == 0) num = "1st";
                    else if (i == 1) num = "2nd";
                    else if (i == 2) num = "3rd";
                    else num = (i + 1).ToString() + "th";

                    return num + " letter must be " + hintCorrectLetters[i];
                }
                else if (guessWord[i] == hintCorrectLetters[i])
                {
                    char[] sep = { hintCorrectLetters[i] };
                    string[] temp = tempGuessWord.Split(sep, 2);
                    tempGuessWord = string.Join("", temp);
                }
            }

            guessWord = tempGuessWord;

            for (int i = 0; i < hintExistingLetters.Length; i++)
            {
                if (guessWord.Contains(hintExistingLetters[i]))
                {
                    char[] sep = { hintExistingLetters[i] };
                    string[] temp = guessWord.Split(sep, 2);
                    guessWord = string.Join("", temp);

                }
                else
                {
                    return "Guess must contain " + hintExistingLetters[i];
                }
            }

            return "";
        }
    }
}
