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
        public string currentWord = "";
        public Word5Letters()
        {
            InitializeComponent();

            HandleLetterFocus(currentWord.Length);
        }

        private void HandleLetterFocus(int letterCount)
        {
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
            currentWord = txtLetter1.Text + txtLetter2.Text + txtLetter3.Text + txtLetter4.Text + txtLetter5.Text;
            HandleLetterFocus(currentWord.Length);
            wordLen.Text = currentWord.Length.ToString();
        }
    }
}
