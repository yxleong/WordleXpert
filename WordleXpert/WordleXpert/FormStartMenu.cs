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
           // panel1.BackgroundImage = Image.FromFile
             //   (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img\StartMenu_bg.png");
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
    }
}
