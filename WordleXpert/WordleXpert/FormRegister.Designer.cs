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
            this.pwdText2 = new System.Windows.Forms.TextBox();
            this.usrText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwdText2
            // 
            this.pwdText2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdText2.Location = new System.Drawing.Point(238, 170);
            this.pwdText2.Name = "pwdText2";
            this.pwdText2.Size = new System.Drawing.Size(184, 29);
            this.pwdText2.TabIndex = 0;
            this.pwdText2.TextChanged += new System.EventHandler(this.pwdText2_TextChanged);
            // 
            // usrText
            // 
            this.usrText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrText.Location = new System.Drawing.Point(160, 100);
            this.usrText.Name = "usrText";
            this.usrText.Size = new System.Drawing.Size(262, 29);
            this.usrText.TabIndex = 0;
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdText.Location = new System.Drawing.Point(160, 135);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(262, 29);
            this.pwdText.TabIndex = 0;
            this.pwdText.TextChanged += new System.EventHandler(this.pwdText_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Register;
            this.buttonRegister.Location = new System.Drawing.Point(160, 223);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(106, 40);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.SystemColors.Window;
            this.lblReg.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReg.Location = new System.Drawing.Point(160, 268);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(42, 16);
            this.lblReg.TabIndex = 2;
            this.lblReg.Text = "label1";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.bg_Register;
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.usrText);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.pwdText2);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdText2;
        private System.Windows.Forms.TextBox usrText;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label lblReg;
    }
}