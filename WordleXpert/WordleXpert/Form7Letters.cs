using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleXpert
{
    public partial class Form7Letters : Form
    {
        private static string Answer;
        private static int GuessCount;
        private static GameFunctions GameFunctions;
        private static char[] HintCorrectLetters;
        private static string HintExistingLetters;

        public Form7Letters()
        {
            InitializeComponent();

            Program.IsInGame = true;
            GameFunctions = new GameFunctions(this);
            lblUser.Text = Program.User;
            if (lblUser.Text == "Guest")
            {
                btnLogout.Text = "Login/Register";
            }
            else
            {
                btnLogout.Text = "Logout";
            }
        }

        private void Form7Letters_Load(object sender, EventArgs e)
        {
            lblUser.Text = Program.User;
            // get a random word as the answer
            Random random = new Random((int)DateTime.Now.Millisecond);

            string filename = "word_list/english_7.txt";
            if (Program.Language == "Melayu") filename = "word_list/melayu_7.txt";

            string[] lines = File.ReadAllLines(filename);

            Answer = lines[random.Next(lines.Length)];
            txtAnswer.Text = Answer;

            // focus to first textbox
            GuessCount = 0;
            HandleWordFocus();
        }

        private void HandleWordFocus()
        {
            switch (GuessCount)
            {
                case 0: word1.Select(); word1.Focus(); word1.HandleLetterFocus(); break;
                case 1: word2.Select(); word2.Focus(); word2.HandleLetterFocus(); break;
                case 2: word3.Select(); word3.Focus(); word3.HandleLetterFocus(); break;
                case 3: word4.Select(); word4.Focus(); word4.HandleLetterFocus(); break;
                case 4: word5.Select(); word5.Focus(); word5.HandleLetterFocus(); break;
                default: word6.Select(); word6.Focus(); word6.HandleLetterFocus(); break;
            }
        }

        private void word1_WordEntered(object sender, EventArgs e)
        {
            if (!Program.DisableHardMode) Program.DisableHardMode = true;

            word1.CheckLetters(Answer);

            if (Program.IsHardMode)
            {
                // update hints
                HintCorrectLetters = word1.HintCorrectLetters;
                HintExistingLetters = word1.HintExistingLetters;
            }

            if (word1.Word == Answer)
            {
                GameFunctions.DisplayWin();
            }
            else
            {
                GuessCount++;
                HandleWordFocus();
            }
        }

        private void word_WordEntered(object sender, EventArgs e)
        {
            if (!Program.DisableHardMode) Program.DisableHardMode = true;

            var word = sender as Word7Letters;

            if (Program.IsHardMode)
            {
                string hint = GameFunctions.CheckWordValid(word.Word, HintCorrectLetters, HintExistingLetters);

                if (hint != "")
                {
                    MessageBox.Show(hint);
                    return;
                }
            }

            word.CheckLetters(Answer);

            if (Program.IsHardMode)
            {
                // update hints
                HintCorrectLetters = word.HintCorrectLetters;
                HintExistingLetters = word.HintExistingLetters;
            }

            if (word.Word == Answer)
            {
                GameFunctions.DisplayWin();
            }
            else
            {
                GuessCount++;
                HandleWordFocus();
            }
        }

        private void word6_WordEntered(object sender, EventArgs e)
        {
            if (Program.IsHardMode)
            {
                string hint = GameFunctions.CheckWordValid(word6.Word, HintCorrectLetters, HintExistingLetters);

                if (hint != "")
                {
                    MessageBox.Show(hint);
                    return;
                }
            }

            word6.CheckLetters(Answer);

            if (word6.Word == Answer)
            {
                GameFunctions.DisplayWin();
            }
            else
            {
                GameFunctions.DisplayLose(Answer);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            GameFunctions.DisplaySettings();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (btnLogout.Text == "Logout")
            {
                btnLogout.Text = "Login/Register";
                Program.User = "Guest";
                this.Close();
            }
            else if (btnLogout.Text == "Login/Register")
            {
                using (var formAccount = new FormAccount())
                {
                    formAccount.StartPosition = FormStartPosition.CenterParent;
                    formAccount.ShowDialog();
                }
                lblUser.Text = Program.User;
                btnLogout.Text = "Logout";
            }
        }
    }
}
