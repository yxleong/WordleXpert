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
    public partial class Form8Letters : Form
    {
        private static string Answer;
        private static int GuessCount;
        private static GameFunctions GameFunctions;
        private static char[] HintCorrectLetters;
        private static string HintExistingLetters;
        private Timer timer;

        enum COLOR { BLUE, PURPLE, RED, YELLOW }
        private COLOR color = COLOR.BLUE;

        public Form8Letters()
        {
            InitializeComponent();

            Program.IsInGame = true;
            GameFunctions = new GameFunctions(this);

            // timer
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
            labelTime.Visible = false;
            lblUser.Visible = false;

            // dark theme
            if (Program.IsDark) darkTheme();

            // normal mode
            if (!Program.IsDebugging) txtAnswer.Visible = false;
        }

        private void Form8Letters_Load(object sender, EventArgs e)
        {
            lblUser.Text = Program.User;

            // get a random word as the answer
            Random random = new Random((int)DateTime.Now.Millisecond);

            string filename = "word_list/english_8.txt";
            if (Program.Language == "Melayu") filename = "word_list/melayu_8.txt";

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

            var word = sender as Word8Letters;

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

        private void picSetting_Click(object sender, EventArgs e)
        {
            GameFunctions.DisplaySettings();
        }

        private void pictureHow_Click(object sender, EventArgs e)
        {
            GameFunctions.DisplayHowToPlay();
        }

        private void pictureTheme_Click(object sender, EventArgs e)
        {
            if (Program.IsDark) { return; }
            changeTheme();
        }

        private void changeTheme()
        {
            Color current = System.Drawing.SystemColors.InactiveCaption;

            if (color == COLOR.BLUE)
            {
                this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_8_Purple;
                this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_Purple;
                this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay_Purple;
                this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color_Purple;

                this.labelTime.ForeColor = System.Drawing.Color.Plum;
                this.lblUser.ForeColor = System.Drawing.Color.Plum;

                current = System.Drawing.Color.Thistle;
            }
            else if (color == COLOR.PURPLE)
            {
                this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_8_Red;
                this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_Red;
                this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay_Red;
                this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color_Red;

                this.labelTime.ForeColor = System.Drawing.Color.RosyBrown;
                this.lblUser.ForeColor = System.Drawing.Color.RosyBrown;

                current = System.Drawing.Color.RosyBrown;
            }
            else if (color == COLOR.RED)
            {
                this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_8_Yellow;
                this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_Yellow;
                this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay_Yellow;
                this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color_Yellow;

                this.labelTime.ForeColor = System.Drawing.Color.Tan;
                this.lblUser.ForeColor = System.Drawing.Color.Tan;

                current = System.Drawing.Color.Wheat;
            }
            else
            {
                this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_8;
                this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting;
                this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay;
                this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color;

                this.labelTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;

                current = System.Drawing.SystemColors.InactiveCaption;
            }

            this.word1.BackColor = current;
            this.word2.BackColor = current;
            this.word3.BackColor = current;
            this.word4.BackColor = current;
            this.word5.BackColor = current;
            this.word6.BackColor = current;
            this.btnA.BackColor = this.labelTime.ForeColor;
            this.btnB.BackColor = this.labelTime.ForeColor;
            this.btnC.BackColor = this.labelTime.ForeColor;
            this.btnD.BackColor = this.labelTime.ForeColor;
            this.btnE.BackColor = this.labelTime.ForeColor;
            this.btnF.BackColor = this.labelTime.ForeColor;
            this.btnG.BackColor = this.labelTime.ForeColor;
            this.btnH.BackColor = this.labelTime.ForeColor;
            this.btnI.BackColor = this.labelTime.ForeColor;
            this.btnJ.BackColor = this.labelTime.ForeColor;
            this.btnK.BackColor = this.labelTime.ForeColor;
            this.btnL.BackColor = this.labelTime.ForeColor;
            this.btnM.BackColor = this.labelTime.ForeColor;
            this.btnN.BackColor = this.labelTime.ForeColor;
            this.btnO.BackColor = this.labelTime.ForeColor;
            this.btnP.BackColor = this.labelTime.ForeColor;
            this.btnQ.BackColor = this.labelTime.ForeColor;
            this.btnR.BackColor = this.labelTime.ForeColor;
            this.btnS.BackColor = this.labelTime.ForeColor;
            this.btnT.BackColor = this.labelTime.ForeColor;
            this.btnU.BackColor = this.labelTime.ForeColor;
            this.btnV.BackColor = this.labelTime.ForeColor;
            this.btnW.BackColor = this.labelTime.ForeColor;
            this.btnX.BackColor = this.labelTime.ForeColor;
            this.btnY.BackColor = this.labelTime.ForeColor;
            this.btnZ.BackColor = this.labelTime.ForeColor;
            this.btnBS.BackColor = this.labelTime.ForeColor;
            this.btnEnter.BackColor = this.labelTime.ForeColor;


            // state
            color += 1;
            if (color > COLOR.YELLOW) { color = COLOR.BLUE; }

        }

        private void darkTheme()
        {
            this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_8_Dark;
            this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_Dark;
            this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay_Dark;
            this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color_Dark;
            this.pictureTheme.Visible = false;

            this.labelTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUser.BackColor = System.Drawing.SystemColors.WindowFrame;

            this.word1.BackColor = System.Drawing.SystemColors.WindowText;
            this.word2.BackColor = System.Drawing.SystemColors.WindowText;
            this.word3.BackColor = System.Drawing.SystemColors.WindowText;
            this.word4.BackColor = System.Drawing.SystemColors.WindowText;
            this.word5.BackColor = System.Drawing.SystemColors.WindowText;
            this.word6.BackColor = System.Drawing.SystemColors.WindowText;

            this.btnA.BackColor = this.labelTime.ForeColor;
            this.btnB.BackColor = this.labelTime.ForeColor;
            this.btnC.BackColor = this.labelTime.ForeColor;
            this.btnD.BackColor = this.labelTime.ForeColor;
            this.btnE.BackColor = this.labelTime.ForeColor;
            this.btnF.BackColor = this.labelTime.ForeColor;
            this.btnG.BackColor = this.labelTime.ForeColor;
            this.btnH.BackColor = this.labelTime.ForeColor;
            this.btnI.BackColor = this.labelTime.ForeColor;
            this.btnJ.BackColor = this.labelTime.ForeColor;
            this.btnK.BackColor = this.labelTime.ForeColor;
            this.btnL.BackColor = this.labelTime.ForeColor;
            this.btnM.BackColor = this.labelTime.ForeColor;
            this.btnN.BackColor = this.labelTime.ForeColor;
            this.btnO.BackColor = this.labelTime.ForeColor;
            this.btnP.BackColor = this.labelTime.ForeColor;
            this.btnQ.BackColor = this.labelTime.ForeColor;
            this.btnR.BackColor = this.labelTime.ForeColor;
            this.btnS.BackColor = this.labelTime.ForeColor;
            this.btnT.BackColor = this.labelTime.ForeColor;
            this.btnU.BackColor = this.labelTime.ForeColor;
            this.btnV.BackColor = this.labelTime.ForeColor;
            this.btnW.BackColor = this.labelTime.ForeColor;
            this.btnX.BackColor = this.labelTime.ForeColor;
            this.btnY.BackColor = this.labelTime.ForeColor;
            this.btnZ.BackColor = this.labelTime.ForeColor;
            this.btnBS.BackColor = this.labelTime.ForeColor;
            this.btnEnter.BackColor = this.labelTime.ForeColor;

            this.btnA.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnB.ForeColor = this.btnA.ForeColor;
            this.btnC.ForeColor = this.btnA.ForeColor;
            this.btnD.ForeColor = this.btnA.ForeColor;
            this.btnE.ForeColor = this.btnA.ForeColor;
            this.btnF.ForeColor = this.btnA.ForeColor;
            this.btnG.ForeColor = this.btnA.ForeColor;
            this.btnH.ForeColor = this.btnA.ForeColor;
            this.btnI.ForeColor = this.btnA.ForeColor;
            this.btnJ.ForeColor = this.btnA.ForeColor;
            this.btnK.ForeColor = this.btnA.ForeColor;
            this.btnL.ForeColor = this.btnA.ForeColor;
            this.btnM.ForeColor = this.btnA.ForeColor;
            this.btnN.ForeColor = this.btnA.ForeColor;
            this.btnO.ForeColor = this.btnA.ForeColor;
            this.btnP.ForeColor = this.btnA.ForeColor;
            this.btnQ.ForeColor = this.btnA.ForeColor;
            this.btnR.ForeColor = this.btnA.ForeColor;
            this.btnS.ForeColor = this.btnA.ForeColor;
            this.btnT.ForeColor = this.btnA.ForeColor;
            this.btnU.ForeColor = this.btnA.ForeColor;
            this.btnV.ForeColor = this.btnA.ForeColor;
            this.btnW.ForeColor = this.btnA.ForeColor;
            this.btnX.ForeColor = this.btnA.ForeColor;
            this.btnY.ForeColor = this.btnA.ForeColor;
            this.btnZ.ForeColor = this.btnA.ForeColor;
            this.btnBS.ForeColor = this.btnA.ForeColor;
            this.btnEnter.ForeColor = this.btnA.ForeColor;
        }

        // enter words in click mode
        private void btn_OnScreen_Entered(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            switch (GuessCount)
            {
                case 0: word1.Select(); word1.Focus(); word1.HandleLetterFocus(); word1.HandleInput(clickedButton.Text); break;
                case 1: word2.Select(); word2.Focus(); word2.HandleLetterFocus(); word2.HandleInput(clickedButton.Text); break;
                case 2: word3.Select(); word3.Focus(); word3.HandleLetterFocus(); word3.HandleInput(clickedButton.Text); break;
                case 3: word4.Select(); word4.Focus(); word4.HandleLetterFocus(); word4.HandleInput(clickedButton.Text); break;
                case 4: word5.Select(); word5.Focus(); word5.HandleLetterFocus(); word5.HandleInput(clickedButton.Text); break;
                default: word6.Select(); word6.Focus(); word6.HandleLetterFocus(); word6.HandleInput(clickedButton.Text); break;
            }
        }

        // Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labelTime.Text = currentTime.ToString("yyyy/MM/dd HH:mm:ss");
            labelTime.Visible = true;
            lblUser.Visible = true;
        }
    }
}
