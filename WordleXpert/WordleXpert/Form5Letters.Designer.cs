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
            this.word1 = new WordleXpert.Word5Letters();
            this.word2 = new WordleXpert.Word5Letters();
            this.word3 = new WordleXpert.Word5Letters();
            this.word4 = new WordleXpert.Word5Letters();
            this.word5 = new WordleXpert.Word5Letters();
            this.word6 = new WordleXpert.Word5Letters();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(688, 418);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 0;
            // 
            // word1
            // 
            this.word1.Location = new System.Drawing.Point(261, 30);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(270, 38);
            this.word1.TabIndex = 32;
            // 
            // word2
            // 
            this.word2.Location = new System.Drawing.Point(261, 74);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(270, 38);
            this.word2.TabIndex = 33;
            // 
            // word3
            // 
            this.word3.Location = new System.Drawing.Point(261, 118);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(270, 38);
            this.word3.TabIndex = 34;
            // 
            // word4
            // 
            this.word4.Location = new System.Drawing.Point(261, 162);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(270, 38);
            this.word4.TabIndex = 35;
            // 
            // word5
            // 
            this.word5.Location = new System.Drawing.Point(261, 206);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(270, 38);
            this.word5.TabIndex = 36;
            // 
            // word6
            // 
            this.word6.Location = new System.Drawing.Point(261, 250);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(270, 38);
            this.word6.TabIndex = 37;
            // 
            // Form5Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}