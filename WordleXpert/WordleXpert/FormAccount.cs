using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            using (var formRegister = new FormRegister())
            {
                formRegister.StartPosition = FormStartPosition.CenterParent;
                formRegister.ShowDialog();
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
    }
}
