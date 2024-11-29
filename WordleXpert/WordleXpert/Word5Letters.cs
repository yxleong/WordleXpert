using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordleXpert
{
    public partial class Word5Letters : UserControl
    {
        private string _word = "";

        public string Word
        {
            get { return _word; }
            //set { _word = value; }
        }

        public event EventHandler WordEntered;

        protected virtual void OnWordEntered(EventArgs e)
        {
            UpdateCurrentWord();
            WordEntered?.Invoke(this, e);
        }

        public Word5Letters()
        {
            InitializeComponent();

            HandleLetterFocus();
        }

        private void HandleLetterFocus()
        {
            int letterCount = _word.Length;

            txtLetter1.ReadOnly = !(letterCount == 0);
            txtLetter2.ReadOnly = !(letterCount == 1);
            txtLetter3.ReadOnly = !(letterCount == 2);
            txtLetter4.ReadOnly = !(letterCount == 3);
            txtLetter5.ReadOnly = !(letterCount >= 4);

            switch (letterCount)
            {
                case 0: txtLetter1.Focus(); break;
                case 1: txtLetter2.Focus(); break;
                case 2: txtLetter3.Focus(); break;
                case 3: txtLetter4.Focus(); break;
                default: txtLetter5.Focus(); break;
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
                default: txtLetter5.Text = ""; break;
            }
        }

        private void UpdateCurrentWord()
        {
            _word = txtLetter1.Text + txtLetter2.Text + txtLetter3.Text + txtLetter4.Text + txtLetter5.Text;
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets and backspace
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLetter5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLetter5_KeyDown(object sender, KeyEventArgs e)
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

                if (txtLetter5.Text.Length == 0) return;

                UpdateCurrentWord();
                OnWordEntered(EventArgs.Empty);
            }
            else if (txtLetter5.Text.Length > 0)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
