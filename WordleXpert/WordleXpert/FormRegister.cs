using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordleXpert
{
    public partial class FormRegister : Form
    {
        private const string AccFilePath = "accounts.txt";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private bool Register(string username, string pwd)
        {
            var lines = File.ReadAllLines(AccFilePath);
            if (lines.Any(line => line.Split('|')[0] == username))
            {
                return false;
            }

            File.AppendAllText(AccFilePath, $"{username}|{pwd}{Environment.NewLine}");
            return true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            lblReg.Text = "";

            string username = usrText.Text.Trim();
            string pwd = pwdText.Text.Trim();
            string pwd2 = pwdText2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(pwd2))
            {
                lblReg.Text = "Please fill in all fields.";
                return;
            }

            if (!pwd.Equals(pwd2))
            {
                lblReg.Text = "Passwords do not match. Please try again.";
                return;
            }

            if (Register(username, pwd))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.User = username;
                Program.TotalGamesPlayed = 0;
                Program.TotalWins = 0;
                Program.WinPercentage = 0;
                Program.SaveUserStats();
                this.Close();
            }
            else
            {
                lblReg.Text = "Username already exists.";
            }
        }

        private void pwdText_TextChanged(object sender, EventArgs e)
        {
            TextBox pwdTextBox = sender as TextBox;
            if (pwdTextBox != null)
            {
                pwdTextBox.PasswordChar = '*';
            }
        }

        private void pwdText2_TextChanged(object sender, EventArgs e)
        {
            TextBox pwdTextBox = sender as TextBox;
            if (pwdTextBox != null)
            {
                pwdTextBox.PasswordChar = '*';
            }
        }
    }
}
