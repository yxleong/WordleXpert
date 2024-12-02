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
    public partial class FormStartMenu : Form
    {
        public FormStartMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form formGame;

            if (Program.WordLength == 5) formGame = new Form5Letters();
            else formGame = new Form6Letters();

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
    }
}
