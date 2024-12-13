using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Security.Principal;

namespace WordleXpert
{
    public partial class FormAccount : Form
    {
        private const string AccFilePath = "accounts.txt";

        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AccFilePath))
            {
                File.Create(AccFilePath).Close();
            }
        }

        private bool Login(string username, string pwd)
        {
            var lines = File.ReadAllLines(AccFilePath);
            return lines.Any(line => line == $"{username}|{pwd}");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "";
            lblReg.Text = "";

            string username = usrText.Text.Trim();
            string pwd = pwdText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                lblLogin.Text = "Please fill in all fields.";
                return;
            }

            if (Login(username, pwd))
            {
                lblLogin.Text = "Login successful!";
                Program.User = username;
                Program.LoadUserStats();
                this.Close();
            }
            else
            {
                lblLogin.Text = "Invalid username or password.";
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            lblLogin.Text = "";
            lblReg.Text = "";

            string username = usrText.Text.Trim();
            string pwd = pwdText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
=======
            using (var formRegister = new FormRegister())
>>>>>>> Stashed changes
            {
                formRegister.StartPosition = FormStartPosition.CenterParent;
                formRegister.ShowDialog();
            }

<<<<<<< Updated upstream
            if (Register(username, pwd))
            {
                lblReg.Text = "Registration successful!";
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
=======
            //lblLogin.Text = "";
            //lblReg.Text = "";

            //string username = usrText.Text.Trim();
            //string email = emailText.Text.Trim();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            //{
            //    lblReg.Text = "Please fill in all fields.";
            //    return;
            //}

            //if (!IsValidEmail(email))
            //{
            //    lblReg.Text = "Please enter a valid email address.";
            //    return;
            //}

            //if (Register(username, email))
            //{
            //    lblReg.Text = "Registration successful!";
            //    Program.User = username;
            //    this.Close();
            //}
            //else
            //{
            //    lblReg.Text = "Username or email already exists.";
            //}
>>>>>>> Stashed changes

        }
    }
}
