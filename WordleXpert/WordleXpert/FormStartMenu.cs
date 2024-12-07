using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WordleXpert
{
    public partial class FormStartMenu : Form
    {
        public FormStartMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form formGame;

            if (Program.WordLength == 6) formGame = new Form6Letters();
            else if (Program.WordLength == 7) formGame = new Form7Letters();
            else if (Program.WordLength == 8) formGame = new Form8Letters();
            else formGame = new Form5Letters();

            formGame.Location = this.Location;
            formGame.StartPosition = FormStartPosition.Manual;
            formGame.FormClosing += delegate { this.Show(); };
            formGame.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var formSettings = new FormSettings())
            {
                formSettings.StartPosition = FormStartPosition.CenterParent;
                formSettings.ShowDialog();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(btnAccount.Text == "Account")
            {
                using (var formAccount = new FormAccount())
                {
                    formAccount.StartPosition = FormStartPosition.CenterParent;
                    formAccount.ShowDialog();
                }
                btnAccount.Text = "logout";
            }
            else if(btnAccount.Text == "logout")
            {
                btnAccount.Text = "Account";
                Program.User = "Guest";
            }
        }
    }
}
