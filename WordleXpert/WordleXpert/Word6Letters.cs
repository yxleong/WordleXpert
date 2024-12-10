using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleXpert
{
    public partial class Word6Letters : UserControl
    {
        private string _word = "";
        private System.Windows.Forms.TextBox[] tbArray;
        private Dictionary<char, int> lettersDict = new Dictionary<char, int>();

        public char[] HintCorrectLetters = { '*', '*', '*', '*', '*' };
        public string HintExistingLetters = "";

        public string Word { get { return _word; } }

        public event EventHandler WordEntered;

        protected virtual void OnWordEntered(EventArgs e)
        {
            UpdateCurrentWord();
            WordEntered?.Invoke(this, e);
        }

        public Word6Letters()
        {
            InitializeComponent();

            tbArray = new System.Windows.Forms.TextBox[] { txtLetter1, txtLetter2, txtLetter3, txtLetter4, txtLetter5, txtLetter6 };

            for (int i = 0; i < tbArray.Length; i++)
            {
                tbArray[i].BackColor = Color.White;
            }
        }

        public void HandleLetterFocus()
        {
            int letterCount = _word.Length;

            for (int i = 0; i < tbArray.Length; i++)
            {
                if (i == tbArray.Length - 1)
                {
                    tbArray[i].ReadOnly = !(letterCount >= i);
                    tbArray[i].Enabled = (letterCount >= i);
                    continue;
                }
                tbArray[i].ReadOnly = !(letterCount == i);
                tbArray[i].Enabled = (letterCount == i);
            }

            switch (letterCount)
            {
                case 0: txtLetter1.Focus(); break;
                case 1: txtLetter2.Focus(); break;
                case 2: txtLetter3.Focus(); break;
                case 3: txtLetter4.Focus(); break;
                case 4: txtLetter5.Focus(); break;
                default: txtLetter6.Focus(); break;
            }
        }

        private void HandleBackspace()
        {
            int letterCount = _word.Length;
            letterCount--;

            switch (letterCount)
            {
                case 0: txtLetter1.Text = ""; break;
                case 1: txtLetter2.Text = ""; break;
                case 2: txtLetter3.Text = ""; break;
                case 3: txtLetter4.Text = ""; break;
                case 4: txtLetter5.Text = ""; break;
                default: txtLetter6.Text = ""; break;
            }
        }

        private void UpdateCurrentWord()
        {
            _word = txtLetter1.Text + txtLetter2.Text + txtLetter3.Text + txtLetter4.Text + txtLetter5.Text + txtLetter6.Text;
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets and backspace
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLetter6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets, backspace, enter
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter);
        }

        private void txtLetter_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentWord();
            HandleLetterFocus();
        }

        private void txtLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                HandleBackspace();
                UpdateCurrentWord();
                HandleLetterFocus();
            }
        }

        private void txtLetter6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                HandleBackspace();
                UpdateCurrentWord();
                HandleLetterFocus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (txtLetter6.Text.Length == 0) return;

                UpdateCurrentWord();
                OnWordEntered(EventArgs.Empty);
            }
            else if (txtLetter6.Text.Length > 0)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CheckCorrectLetters(string answer)
        {
            for (int i = 0; i < tbArray.Length; i++)
            {
                if (tbArray[i].Text[0] == answer[i] && lettersDict[tbArray[i].Text[0]] > 0)
                {
                    tbArray[i].BackColor = Color.LimeGreen;
                    lettersDict[tbArray[i].Text[0]]--;

                    if (Program.IsHardMode) HintCorrectLetters[i] = answer[i];
                }
            }
        }

        private void CheckExistingLetters(string answer)
        {
            for (int i = 0; i < tbArray.Length; i++)
            {
                if (answer.Contains(tbArray[i].Text[0]) && lettersDict[tbArray[i].Text[0]] > 0 && tbArray[i].BackColor != Color.LimeGreen)
                {
                    tbArray[i].BackColor = Color.Yellow;
                    lettersDict[tbArray[i].Text[0]]--;

                    if (Program.IsHardMode) HintExistingLetters += tbArray[i].Text[0];
                }
            }
        }

        public void CheckLetters(string answer)
        {
            foreach (char letter in answer)
            {
                if (!lettersDict.ContainsKey(letter)) lettersDict.Add(letter, 1);
                else lettersDict[letter] += 1;
            }

            CheckCorrectLetters(answer);
            CheckExistingLetters(answer);
        }
    }
}
