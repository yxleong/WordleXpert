﻿namespace WordleXpert
{
    partial class Form6Letters
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
            this.word1 = new WordleXpert.Word6Letters();
            this.word2 = new WordleXpert.Word6Letters();
            this.word3 = new WordleXpert.Word6Letters();
            this.word4 = new WordleXpert.Word6Letters();
            this.word5 = new WordleXpert.Word6Letters();
            this.word6 = new WordleXpert.Word6Letters();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(688, 418);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // word1
            // 
            this.word1.Location = new System.Drawing.Point(240, 30);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(321, 38);
            this.word1.TabIndex = 2;
            this.word1.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(240, 74);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(321, 38);
            this.word2.TabIndex = 3;
            this.word2.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word3
            // 
            this.word3.Location = new System.Drawing.Point(240, 118);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(321, 38);
            this.word3.TabIndex = 4;
            this.word3.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word4
            // 
            this.word4.Location = new System.Drawing.Point(240, 162);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(321, 38);
            this.word4.TabIndex = 5;
            this.word4.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word5
            // 
            this.word5.Location = new System.Drawing.Point(240, 206);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(321, 38);
            this.word5.TabIndex = 6;
            this.word5.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word6
            // 
            this.word6.Location = new System.Drawing.Point(240, 250);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(321, 38);
            this.word6.TabIndex = 7;
            this.word6.WordEntered += new System.EventHandler(this.word6_WordEntered);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 39;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form6Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.word6);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.txtAnswer);
            this.Name = "Form6Letters";
            this.Text = "WordleXpert";
            this.Load += new System.EventHandler(this.Form6Letters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private Word6Letters word1;
        private Word6Letters word2;
        private Word6Letters word3;
        private Word6Letters word4;
        private Word6Letters word5;
        private Word6Letters word6;
        private System.Windows.Forms.Button btnSettings;
    }
}