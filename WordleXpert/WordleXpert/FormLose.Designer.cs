namespace WordleXpert
{
    partial class FormLose
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Home;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHome.Location = new System.Drawing.Point(129, 137);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(103, 36);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAnswer.Location = new System.Drawing.Point(107, 89);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(84, 24);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer: ";
            // 
            // FormLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.Lose;
            this.ClientSize = new System.Drawing.Size(377, 202);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnHome);
            this.Name = "FormLose";
            this.Text = "You Lose!";
            this.Load += new System.EventHandler(this.FormLose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAnswer;
    }
}