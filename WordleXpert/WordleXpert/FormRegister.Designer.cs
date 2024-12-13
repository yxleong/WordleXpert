namespace WordleXpert
{
    partial class FormRegister
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
            this.lblReg = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.usrText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.pwdText2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReg.Location = new System.Drawing.Point(286, 324);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(116, 40);
            this.lblReg.TabIndex = 21;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReg.Location = new System.Drawing.Point(280, 281);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(116, 40);
            this.btnReg.TabIndex = 25;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // usrText
            // 
            this.usrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrText.Location = new System.Drawing.Point(244, 98);
            this.usrText.Name = "usrText";
            this.usrText.Size = new System.Drawing.Size(200, 29);
            this.usrText.TabIndex = 13;
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pwdText.Location = new System.Drawing.Point(244, 149);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(200, 29);
            this.pwdText.TabIndex = 15;
            this.pwdText.TextChanged += new System.EventHandler(this.pwdText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(136, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(141, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblLanguage.Location = new System.Drawing.Point(196, 26);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(156, 44);
            this.lblLanguage.TabIndex = 14;
            this.lblLanguage.Text = "Account";
            // 
            // pwdText2
            // 
            this.pwdText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pwdText2.Location = new System.Drawing.Point(244, 207);
            this.pwdText2.Name = "pwdText2";
            this.pwdText2.Size = new System.Drawing.Size(200, 29);
            this.pwdText2.TabIndex = 22;
            this.pwdText2.TextChanged += new System.EventHandler(this.pwdText2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(66, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Comfirm Password:";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.pwdText2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.usrText);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLanguage);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox usrText;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox pwdText2;
        private System.Windows.Forms.Label label3;
    }
}