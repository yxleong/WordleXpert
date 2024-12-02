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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordleXpert
{
    public partial class Form5Letters : Form
    {
        public Form5Letters()
        {
            InitializeComponent();
            
            Program.IsInGame = true;
        }

        private void Form5Letters_Load(object sender, EventArgs e)
        {
            // get a random word as the answer
            Random random = new Random((int)DateTime.Now.Millisecond);

            string filename = "english_5.txt";
            if (Program.Language == "Melayu") filename = "melayu_5.txt";

            string[] lines = File.ReadAllLines(filename);

            Program.Answer = lines[random.Next(lines.Length)];
            txtAnswer.Text = Program.Answer.ToString();

            // focus to first textbox
            Program.GuessCount = 0;
            HandleWordFocus();
        }

        private void HandleWordFocus()
        {
            switch (Program.GuessCount)
            {
                case 0: word1.Select(); word1.Focus(); word1.HandleLetterFocus(); break;
                case 1: word2.Select(); word2.Focus(); word2.HandleLetterFocus(); break;
                case 2: word3.Select(); word3.Focus(); word3.HandleLetterFocus(); break;
                case 3: word4.Select(); word4.Focus(); word4.HandleLetterFocus(); break;
                case 4: word5.Select(); word5.Focus(); word5.HandleLetterFocus(); break;
                case 5:
                default: word6.Select(); word6.Focus(); word6.HandleLetterFocus(); break;
            }
        }

        private void word_WordEntered(object sender, EventArgs e)
        {
            var word = sender as Word5Letters;

            if (word.Word == Program.Answer)
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
                Program.GuessCount++;
                HandleWordFocus();
            }
        }

        private void word5_WordEntered(object sender, EventArgs e)
        {
            if (word5.Word == Program.Answer)
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

            Program.IsInGame = false;
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
