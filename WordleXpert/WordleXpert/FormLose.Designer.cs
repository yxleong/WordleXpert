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
            this.lblLose = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblLose.Location = new System.Drawing.Point(107, 35);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(216, 51);
            this.lblLose.TabIndex = 0;
            this.lblLose.Text = "You Lose!";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHome.Location = new System.Drawing.Point(142, 150);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(138, 57);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAnswer.Location = new System.Drawing.Point(148, 99);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(84, 24);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer: ";
            // 
            // FormLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 241);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblLose);
            this.Name = "FormLose";
            this.Text = "You Lose!";
            this.Load += new System.EventHandler(this.FormLose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAnswer;
    }
}