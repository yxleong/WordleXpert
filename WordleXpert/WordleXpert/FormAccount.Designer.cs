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
            this.usrText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrText
            // 
            this.usrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrText.Location = new System.Drawing.Point(160, 101);
            this.usrText.Name = "usrText";
            this.usrText.Size = new System.Drawing.Size(275, 29);
            this.usrText.TabIndex = 4;
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pwdText.Location = new System.Drawing.Point(161, 140);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(275, 29);
            this.pwdText.TabIndex = 5;
            this.pwdText.TextChanged += new System.EventHandler(this.pwdText_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Login;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(85, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 40);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Register;
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReg.Location = new System.Drawing.Point(259, 217);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(109, 40);
            this.btnReg.TabIndex = 10;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLogin.Location = new System.Drawing.Point(174, 181);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 16);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "label1";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.White;
            this.lblReg.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReg.Location = new System.Drawing.Point(289, 260);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 16);
            this.lblReg.TabIndex = 11;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.bg_Account;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.usrText);
            this.Name = "FormAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usrText;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblReg;
    }
}