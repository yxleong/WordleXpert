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
    public partial class FormRules : Form
    {
        public FormRules()
        {
            InitializeComponent();

            if (Program.RuleIsCh) displayChRule(); // default: Eng
        }

        private void buttonLan_Click(object sender, EventArgs e)
        {
            if (Program.RuleIsCh) displayEngRule();
            else displayChRule();

            // update state
            Program.RuleIsCh = !Program.RuleIsCh;
        }

        private void displayChRule() {
            buttonLan.Text = "Eng";
            // change text
            lblRule.Text = "1. 六次機會猜出正確詞彙\r\n" +
                "2a. 字母和位置正確：\r\n" +
                "       標記為正確\r\n" +
                "2b. 字母正確但位置錯誤：\r\n" +
                "       標記為部分正確\r\n" +
                "2c.不在單詞中：\r\n" +
                "       不標記\r\n" +
                "3. 語言或單詞長度可在設置中進行選擇\r\n" +
                "4. 困難模式：\r\n" +
                "      下一次猜測必須包含之前揭示的提示字母\r\n" +
                "5. 註冊或登錄後即可查看你的成績\r\n";
        }

        private void displayEngRule() {
            buttonLan.Text = "中";
            // change text
            lblRule.Text = "1. Six tries to guess the correct word\r\n" +
                "2a. Correct Letter and Spot: \r\n" +
                "       Marked as correct\r\n" +
                "2b. Correct Letter, Wrong Spot: \r\n" +
                "       Marked as partially correct\r\n" +
                "2c. Not in the Word: \r\n" +
                "       No mark\r\n" +
                "3. Set Your Preferences: \r\n" +
                "       Language or Word Length\r\n" +
                "4. Hard Mode: \r\n" +
                "      next guess must include revealed hints\r\n" +
                "5. Register to See your guess\r\n";
        }

        
    }
}
