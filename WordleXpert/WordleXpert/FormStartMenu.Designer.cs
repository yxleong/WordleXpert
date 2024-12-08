namespace WordleXpert
{
    partial class FormStartMenu
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCheckStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelTitle.Location = new System.Drawing.Point(266, 144);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(262, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "WordleXpert";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnStart.Location = new System.Drawing.Point(320, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSettings.Location = new System.Drawing.Point(320, 317);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(158, 61);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAccount.Location = new System.Drawing.Point(525, 235);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(184, 43);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Login/Register";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCheckStats
            // 
            this.btnCheckStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCheckStats.Location = new System.Drawing.Point(525, 317);
            this.btnCheckStats.Name = "btnCheckStats";
            this.btnCheckStats.Size = new System.Drawing.Size(184, 43);
            this.btnCheckStats.TabIndex = 4;
            this.btnCheckStats.Text = "Check";
            this.btnCheckStats.UseVisualStyleBackColor = true;
            this.btnCheckStats.Click += new System.EventHandler(this.btnCheckStats_Click);
            // 
            // FormStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckStats);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormStartMenu";
            this.Text = "WordleXpert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCheckStats;
    }
}