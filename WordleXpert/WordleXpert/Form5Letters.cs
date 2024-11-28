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
        }

        private void Form5Letters_Load(object sender, EventArgs e)
        {
            // get a random word as the answer
            Random random = new Random((int)DateTime.Now.Millisecond);

            string filename = "5-letter-words.txt";
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
                case 0: word1.Select(); break;
                default: break;
            }
        }
    }
}
