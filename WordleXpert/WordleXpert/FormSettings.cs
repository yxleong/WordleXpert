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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cboLanguage.Text = Program.Language;
            cboWordLength.Text = Program.WordLength.ToString();
            PrintSettings();
        }

        private void PrintSettings()
        {
            txtTest.Text = Program.Language + " | " + Program.WordLength.ToString();
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Language = cboLanguage.Text;
            PrintSettings();
        }

        private void cboWordLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.WordLength = Convert.ToInt32(cboWordLength.Text);
            PrintSettings();
        }
    }
}
