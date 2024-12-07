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
        private static string SetLanguage;
        private static string SetWordLength;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            SetLanguage = Program.Language;
            SetWordLength = Program.WordLength.ToString();

            cboLanguage.Text = SetLanguage;
            cboWordLength.Text = SetWordLength;
            chkHardMode.Checked = Program.IsHardMode;

            lblHardModeInfo.Visible = false;

            PrintSettings();
        }

        private void PrintSettings()
        {
            txtTest.Text = Program.Language + " (" + SetLanguage + ") | ";
            txtTest.Text += Program.WordLength.ToString() + " (" + SetWordLength + ") | ";
            txtTest.Text += "Hard Mode: " + Program.IsHardMode.ToString();
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLanguage = cboLanguage.Text;
            PrintSettings();
        }

        private void cboWordLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWordLength = cboWordLength.Text;
            PrintSettings();
        }

        private void chkHardMode_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.DisableHardMode)
            {
                chkHardMode.Checked = Program.IsHardMode;
                lblHardModeInfo.Visible = true;
            }
            else
            {
                Program.IsHardMode = chkHardMode.Checked;    
            }
            PrintSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!Program.IsInGame)
            {
                Program.Language = SetLanguage;
                Program.WordLength = Convert.ToInt32(SetWordLength);
            }
            else if (SetLanguage != Program.Language || SetWordLength != Program.WordLength.ToString())
            {
                using (var formConfirmSettings = new FormConfirmSettings())
                {
                    formConfirmSettings.StartPosition = FormStartPosition.CenterParent;
                    var result = formConfirmSettings.ShowDialog();

                    // restart the game with new changes
                    if (result == DialogResult.OK)
                    {
                        Program.Language = SetLanguage;
                        Program.WordLength = Convert.ToInt32(SetWordLength);

                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }
            this.Close();
        }
    }
}
