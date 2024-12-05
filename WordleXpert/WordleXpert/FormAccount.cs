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

namespace WordleXpert
{
    public partial class FormAccount : Form
    {
        private const string FilePath = "accounts.txt";

        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
        }

        private bool Login(string username, string email)
        {
            var lines = File.ReadAllLines(FilePath);
            return lines.Any(line => line == $"{username}|{email}");
        }

        private bool Register(string username, string email)
        {
            var lines = File.ReadAllLines(FilePath);
            if (lines.Any(line => line.Split('|')[0] == username || line.Split('|')[1] == email))
            {
                return false;
            }

            File.AppendAllText(FilePath, $"{username}|{email}{Environment.NewLine}");
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "";
            lblReg.Text = "";

            string username = usrText.Text.Trim();
            string email = emailText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                lblLogin.Text = "Please fill in all fields.";
                return;
            }

            if (Login(username, email))
            {
                lblLogin.Text = "Login successful!";
                Program.User = username;
                this.Close();

            }
            else
            {
                lblLogin.Text = "Invalid username or email.";
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "";
            lblReg.Text = "";

            string username = usrText.Text.Trim();
            string email = emailText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                lblReg.Text = "Please fill in all fields.";
                return;
            }

            if (!IsValidEmail(email))
            {
                lblReg.Text = "Please enter a valid email address.";
                return;
            }

            if (Register(username, email))
            {
                lblReg.Text = "Registration successful!";
                Program.User = username;
                this.Close();
            }
            else
            {
                lblReg.Text = "Username or email already exists.";
            }

        }
    }
}
