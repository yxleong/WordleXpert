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
            string filename, answer;
            Random random = new Random((int)DateTime.Now.Millisecond);

            if (Program.WordLength == 5)
            {
                filename = "5-letter-words.txt";
            }
            else
            {
                filename = "5-letter-words.txt";
            }

            string[] lines = File.ReadAllLines(filename);
            answer = lines[random.Next(lines.Length)];
            correct_word.Text = answer.ToString();

            // handle read-only property
            int guessCount = 0;
            HandleTextboxFocus(guessCount);
        }

        private void HandleTextboxFocus(int guessCount)
        {
            textBox1.ReadOnly = !(guessCount == 0);
            textBox2.ReadOnly = !(guessCount == 1);
            textBox3.ReadOnly = !(guessCount == 2);
            textBox4.ReadOnly = !(guessCount == 3);
            textBox5.ReadOnly = !(guessCount == 4);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow alphabets, backspace, enter
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter);

        }
    }
}
