namespace WordleXpert
{
    partial class Form5Letters
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.word6 = new WordleXpert.Word5Letters();
            this.word5 = new WordleXpert.Word5Letters();
            this.word4 = new WordleXpert.Word5Letters();
            this.word3 = new WordleXpert.Word5Letters();
            this.word2 = new WordleXpert.Word5Letters();
            this.word1 = new WordleXpert.Word5Letters();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(281, 415);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(145, 78);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 21);
            this.btnSettings.TabIndex = 38;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color;
            this.pictureBox5.Location = new System.Drawing.Point(105, 74);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 26);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WordleXpert.Properties.Resources.Report;
            this.pictureBox4.Location = new System.Drawing.Point(74, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 26);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay;
            this.pictureBox3.Location = new System.Drawing.Point(43, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WordleXpert.Properties.Resources.Setting;
            this.pictureBox2.Location = new System.Drawing.Point(12, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WordleXpert.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 53);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // word6
            // 
            this.word6.Location = new System.Drawing.Point(74, 352);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(270, 35);
            this.word6.TabIndex = 37;
            this.word6.WordEntered += new System.EventHandler(this.word6_WordEntered);
            // 
            // word5
            // 
            this.word5.Location = new System.Drawing.Point(74, 311);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(270, 35);
            this.word5.TabIndex = 36;
            this.word5.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word4
            // 
            this.word4.Location = new System.Drawing.Point(74, 271);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(270, 35);
            this.word4.TabIndex = 35;
            this.word4.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word3
            // 
            this.word3.Location = new System.Drawing.Point(74, 230);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(270, 35);
            this.word3.TabIndex = 34;
            this.word3.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(74, 189);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(270, 35);
            this.word2.TabIndex = 33;
            this.word2.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word1
            // 
            this.word1.Location = new System.Drawing.Point(74, 149);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(270, 35);
            this.word1.TabIndex = 32;
            this.word1.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // Form5Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 626);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.word6);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.txtAnswer);
            this.Name = "Form5Letters";
            this.Text = "WordleXpert";
            this.Load += new System.EventHandler(this.Form5Letters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.word6 = new WordleXpert.Word5Letters();
            this.word5 = new WordleXpert.Word5Letters();
            this.word4 = new WordleXpert.Word5Letters();
            this.word3 = new WordleXpert.Word5Letters();
            this.word2 = new WordleXpert.Word5Letters();
            this.word1 = new WordleXpert.Word5Letters();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(688, 418);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 38;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // word6
            // 
            this.word6.Location = new System.Drawing.Point(261, 250);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(270, 38);
            this.word6.TabIndex = 37;
            this.word6.WordEntered += new System.EventHandler(this.word6_WordEntered);
            // 
            // word5
            // 
            this.word5.Location = new System.Drawing.Point(261, 206);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(270, 38);
            this.word5.TabIndex = 36;
            this.word5.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word4
            // 
            this.word4.Location = new System.Drawing.Point(261, 162);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(270, 38);
            this.word4.TabIndex = 35;
            this.word4.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word3
            // 
            this.word3.Location = new System.Drawing.Point(261, 118);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(270, 38);
            this.word3.TabIndex = 34;
            this.word3.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(261, 74);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(270, 38);
            this.word2.TabIndex = 33;
            this.word2.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word1
            // 
            this.word1.Location = new System.Drawing.Point(261, 30);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(270, 38);
            this.word1.TabIndex = 32;
            this.word1.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // Form5Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.word6);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.txtAnswer);
            this.Name = "Form5Letters";
            this.Text = "WordleXpert";
            this.Load += new System.EventHandler(this.Form5Letters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private Word5Letters word1;
        private Word5Letters word2;
        private Word5Letters word3;
        private Word5Letters word4;
        private Word5Letters word5;
        private Word5Letters word6;
      
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
      
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
    }
}