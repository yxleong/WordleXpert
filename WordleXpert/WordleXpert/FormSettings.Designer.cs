namespace WordleXpert
{
    partial class FormSettings
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
            this.lblWordLength = new System.Windows.Forms.Label();
            this.lblKeyboard = new System.Windows.Forms.Label();
            this.lblHardMode = new System.Windows.Forms.Label();
            this.lblDarkTheme = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboWordLength = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLanguage.Location = new System.Drawing.Point(31, 36);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(95, 24);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language";
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWordLength.Location = new System.Drawing.Point(31, 92);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(119, 24);
            this.lblWordLength.TabIndex = 1;
            this.lblWordLength.Text = "Word Length";
            // 
            // lblKeyboard
            // 
            this.lblKeyboard.AutoSize = true;
            this.lblKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKeyboard.Location = new System.Drawing.Point(31, 203);
            this.lblKeyboard.Name = "lblKeyboard";
            this.lblKeyboard.Size = new System.Drawing.Size(276, 24);
            this.lblKeyboard.TabIndex = 2;
            this.lblKeyboard.Text = "On-screen Keyboard Input Only";
            // 
            // lblHardMode
            // 
            this.lblHardMode.AutoSize = true;
            this.lblHardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHardMode.Location = new System.Drawing.Point(31, 149);
            this.lblHardMode.Name = "lblHardMode";
            this.lblHardMode.Size = new System.Drawing.Size(105, 24);
            this.lblHardMode.TabIndex = 3;
            this.lblHardMode.Text = "Hard Mode";
            // 
            // lblDarkTheme
            // 
            this.lblDarkTheme.AutoSize = true;
            this.lblDarkTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDarkTheme.Location = new System.Drawing.Point(31, 254);
            this.lblDarkTheme.Name = "lblDarkTheme";
            this.lblDarkTheme.Size = new System.Drawing.Size(114, 24);
            this.lblDarkTheme.TabIndex = 4;
            this.lblDarkTheme.Text = "Dark Theme";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Melayu"});
            this.cboLanguage.Location = new System.Drawing.Point(358, 36);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(121, 21);
            this.cboLanguage.TabIndex = 5;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // cboWordLength
            // 
            this.cboWordLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWordLength.FormattingEnabled = true;
            this.cboWordLength.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboWordLength.Location = new System.Drawing.Point(358, 92);
            this.cboWordLength.Name = "cboWordLength";
            this.cboWordLength.Size = new System.Drawing.Size(121, 21);
            this.cboWordLength.TabIndex = 6;
            this.cboWordLength.SelectedIndexChanged += new System.EventHandler(this.cboWordLength_SelectedIndexChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(62, 289);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(389, 20);
            this.txtTest.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(100, 335);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(116, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.cboWordLength);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lblDarkTheme);
            this.Controls.Add(this.lblHardMode);
            this.Controls.Add(this.lblKeyboard);
            this.Controls.Add(this.lblWordLength);
            this.Controls.Add(this.lblLanguage);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblWordLength;
        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.Label lblHardMode;
        private System.Windows.Forms.Label lblDarkTheme;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboWordLength;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}