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
    public partial class Word7Letters : UserControl
    {
        private string _word = "";

        public string Word { get { return _word; } }

        public event EventHandler WordEntered;

        protected virtual void OnWordEntered(EventArgs e)
        {
            UpdateCurrentWord();
            WordEntered?.Invoke(this, e);
        }

        public Word7Letters()
        {
            InitializeComponent();

            txtLetter1.BackColor = Color.White;
            txtLetter2.BackColor = Color.White;
            txtLetter3.BackColor = Color.White;
            txtLetter4.BackColor = Color.White;
            txtLetter5.BackColor = Color.White;
            txtLetter6.BackColor = Color.White;
            txtLetter7.BackColor = Color.White;
        }

        public void HandleLetterFocus()
        {
            int letterCount = _word.Length;

            txtLetter1.ReadOnly = !(letterCount == 0);
            txtLetter2.ReadOnly = !(letterCount == 1);
            txtLetter3.ReadOnly = !(letterCount == 2);
            txtLetter4.ReadOnly = !(letterCount == 3);
            txtLetter5.ReadOnly = !(letterCount == 4);
            txtLetter6.ReadOnly = !(letterCount == 5);
            txtLetter7.ReadOnly = !(letterCount >= 6);

            txtLetter1.Enabled = (letterCount == 0);
            txtLetter2.Enabled = (letterCount == 1);
            txtLetter3.Enabled = (letterCount == 2);
            txtLetter4.Enabled = (letterCount == 3);
            txtLetter5.Enabled = (letterCount == 4);
            txtLetter6.Enabled = (letterCount == 5);
            txtLetter7.Enabled = (letterCount >= 6);

            switch (letterCount)
            {
                case 0: txtLetter1.Focus(); break;
                case 1: txtLetter2.Focus(); break;
                case 2: txtLetter3.Focus(); break;
                case 3: txtLetter4.Focus(); break;
                case 4: txtLetter5.Focus(); break;
                case 5: txtLetter6.Focus(); break;
                default: txtLetter7.Focus(); break;
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
                case 5: txtLetter6.Text = ""; break;
                default: txtLetter7.Text = ""; break;
            }
        }

        private void UpdateCurrentWord()
        {
            _word = txtLetter1.Text + txtLetter2.Text + txtLetter3.Text + txtLetter4.Text + txtLetter5.Text + txtLetter6.Text + txtLetter7.Text;
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets and backspace
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLetter7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLetter7_KeyDown(object sender, KeyEventArgs e)
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

                if (txtLetter7.Text.Length == 0) return;

                UpdateCurrentWord();
                OnWordEntered(EventArgs.Empty);
            }
            else if (txtLetter7.Text.Length > 0)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
