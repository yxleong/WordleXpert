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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // get a random word as the answer
            string filename;
            Random random = new Random((int)DateTime.Now.Millisecond);

            switch (Program.WordLength)
            {
                case 6: filename = "5-letter-words.txt"; break;
                default: filename = "5-letter-words.txt"; break;
            }

            string[] lines = File.ReadAllLines(filename);
            Program.Answer = lines[random.Next(lines.Length)];
            correct_word.Text = Program.Answer.ToString();

            // focus to first textbox
            Program.GuessCount = 0;
            HandleTextboxFocus();
        }

        private void HandleTextboxFocus()
        {
            textBox1.ReadOnly = !(Program.GuessCount == 0);
            textBox2.ReadOnly = !(Program.GuessCount == 1);
            textBox3.ReadOnly = !(Program.GuessCount == 2);
            textBox4.ReadOnly = !(Program.GuessCount == 3);
            textBox5.ReadOnly = !(Program.GuessCount == 4);

            switch (Program.GuessCount)
            {
                case 0: textBox1.Focus(); break;
                case 1: textBox2.Focus(); break;
                case 2: textBox3.Focus(); break;
                case 3: textBox4.Focus(); break;
                case 4: textBox5.Focus(); break;
                default: break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets, backspace, enter
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                var textbox = sender as TextBox;
                string userGuess = textbox.Text;

                if (userGuess == Program.Answer)
                {
                    answer_checker.Text = "Correct!";
                }
                else
                {
                    answer_checker.Text = "Wrong!";
                    Program.GuessCount++;
                    HandleTextboxFocus();
                }
            }
        }
    }
}
