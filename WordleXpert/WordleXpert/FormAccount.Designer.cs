namespace WordleXpert
{
    partial class FormAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLanguage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.usrText = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblLanguage.Location = new System.Drawing.Point(177, 39);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(156, 44);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(47, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pwdText.Location = new System.Drawing.Point(150, 166);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(275, 29);
            this.pwdText.TabIndex = 2;
            this.pwdText.TextChanged += new System.EventHandler(this.pwdText_TextChanged);
            // 
            // usrText
            // 
            this.usrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrText.Location = new System.Drawing.Point(150, 115);
            this.usrText.Name = "usrText";
            this.usrText.Size = new System.Drawing.Size(275, 29);
            this.usrText.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(99, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReg.Location = new System.Drawing.Point(262, 259);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(116, 40);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLogin.Location = new System.Drawing.Point(105, 302);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(116, 40);
            this.lblLogin.TabIndex = 11;
            // 
            // lblReg
            // 
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReg.Location = new System.Drawing.Point(268, 302);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(116, 40);
            this.lblReg.TabIndex = 12;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.usrText);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLanguage);
            this.Name = "FormAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.TextBox usrText;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblReg;
    }
}