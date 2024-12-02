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
    public partial class Form6Letters : Form
    {
        private static string Answer;
        private static int GuessCount;

        public Form6Letters()
        {
            InitializeComponent();

            Program.IsInGame = true;
        }

        private void Form6Letters_Load(object sender, EventArgs e)
        {
            // get a random word as the answer
            Random random = new Random((int)DateTime.Now.Millisecond);

            string filename = "english_6.txt";
            if (Program.Language == "Melayu") filename = "melayu_6.txt";

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

        private void word_WordEntered(object sender, EventArgs e)
        {
            var word = sender as Word6Letters;

            if (word.Word == Answer)
            {
                Program.IsInGame = false;

                using (var formWin = new FormWin())
                {
                    formWin.StartPosition = FormStartPosition.CenterParent;
                    formWin.FormClosing += delegate { this.Close(); };
                    formWin.ShowDialog();
                }
            }
            else
            {
                GuessCount++;
                HandleWordFocus();
            }
        }

        private void word6_WordEntered(object sender, EventArgs e)
        {
            Program.IsInGame = false;

            if (word6.Word == Answer)
            {
                using (var formWin = new FormWin())
                {
                    formWin.StartPosition = FormStartPosition.CenterParent;
                    formWin.FormClosing += delegate { this.Close(); };
                    formWin.ShowDialog();
                }
            }
            else
            {
                using (var formLose = new FormLose())
                {
                    formLose.StartPosition = FormStartPosition.CenterParent;
                    formLose.FormClosing += delegate { this.Close(); };
                    formLose.ShowDialog();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var formSettings = new FormSettings())
            {
                formSettings.StartPosition = FormStartPosition.CenterParent;
                var result = formSettings.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    Program.IsInGame = false;
                    this.Close();
                }
            }
        }
    }
}
