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
    public partial class FormHow2Play : Form
    {
        bool isEng = true;

        public FormHow2Play()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            if (isEng)
            {
                isEng = false;
                lblTitle.Text = "玩法及規則";
                label1.Text = "1. 六次機會猜出正確單詞\n" +
                            "2a. 字母和位置正確：標記為正確\n" +
                            "2b. 字母正確但位置錯誤：標記為部分正確\n" +
                            "2c. 不在單詞中：不標記\n" +
                            "3. 語言或單詞長度可在設置中進行選擇\n" +
                            "4. 困難模式: 下一次猜測必須包含之前揭示的提示字母\n" +
                            "5. 註冊或登錄後即可查看你的成績\n";
            }
            else
            {
                isEng = true;
                lblTitle.Text = "How to Play";
                label1.Text = "1. Six tries to guess the correct word\n" +
                            "2a. Correct Letter and Spot: Marked as correct\n" +
                            "2b. Correct Letter, Wrong Spot: Marked as partially correct\n" +
                            "2c. Not in the Word: No mark\n" +
                            "3. Set Your Preferences: Language or Word Length\n" +
                            "4. Hard Mode: next guess must include revealed hints\n" +
                            "5. Register to See your guess\n";
            }
        }
    }
}
