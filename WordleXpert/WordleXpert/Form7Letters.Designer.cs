namespace WordleXpert
{
    partial class Form7Letters
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.word6 = new WordleXpert.Word7Letters();
            this.word5 = new WordleXpert.Word7Letters();
            this.word4 = new WordleXpert.Word7Letters();
            this.word3 = new WordleXpert.Word7Letters();
            this.word2 = new WordleXpert.Word7Letters();
            this.word1 = new WordleXpert.Word7Letters();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 40;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(688, 418);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 41;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUser.Location = new System.Drawing.Point(655, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 40);
            this.lblUser.TabIndex = 39;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 23);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.Text = "Login/Register";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // word6
            // 
            this.word6.Location = new System.Drawing.Point(213, 250);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(377, 38);
            this.word6.TabIndex = 47;
            this.word6.WordEntered += new System.EventHandler(this.word6_WordEntered);
            // 
            // word5
            // 
            this.word5.Location = new System.Drawing.Point(213, 206);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(377, 38);
            this.word5.TabIndex = 46;
            this.word5.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word4
            // 
            this.word4.Location = new System.Drawing.Point(213, 162);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(377, 38);
            this.word4.TabIndex = 45;
            this.word4.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word3
            // 
            this.word3.Location = new System.Drawing.Point(213, 118);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(377, 38);
            this.word3.TabIndex = 44;
            this.word3.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(213, 74);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(377, 38);
            this.word2.TabIndex = 43;
            this.word2.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word1
            // 
            this.word1.Location = new System.Drawing.Point(213, 30);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(377, 38);
            this.word1.TabIndex = 42;
            this.word1.WordEntered += new System.EventHandler(this.word1_WordEntered);
            // 
            // Form7Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.word6);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnSettings);
            this.Name = "Form7Letters";
            this.Text = "WordleXpert";
            this.Load += new System.EventHandler(this.Form7Letters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtAnswer;
        private Word7Letters word1;
        private Word7Letters word2;
        private Word7Letters word3;
        private Word7Letters word4;
        private Word7Letters word5;
        private Word7Letters word6;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
    }
}