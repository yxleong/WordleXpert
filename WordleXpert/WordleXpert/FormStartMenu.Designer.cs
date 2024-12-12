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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::WordleXpert.Properties.Resources.StartMenu_buttom_play;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnStart.Location = new System.Drawing.Point(400, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::WordleXpert.Properties.Resources.StartMenu_buttom_settings;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSettings.Location = new System.Drawing.Point(400, 361);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(113, 46);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FormStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.StartMenu_bg1;
            this.ClientSize = new System.Drawing.Size(894, 512);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStart);
            this.Name = "FormStartMenu";
            this.Text = "WordleXpert";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSettings;
    }
}