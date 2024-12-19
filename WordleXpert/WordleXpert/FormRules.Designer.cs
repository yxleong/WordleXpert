namespace WordleXpert
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.lblRule = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.buttonLan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRule.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRule.Location = new System.Drawing.Point(12, 69);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(330, 252);
            this.lblRule.TabIndex = 15;
            this.lblRule.Text = resources.GetString("lblRule.Text");
            // 
            // picTitle
            // 
            this.picTitle.BackgroundImage = global::WordleXpert.Properties.Resources.howToPlay_label;
            this.picTitle.Location = new System.Drawing.Point(23, 30);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(196, 22);
            this.picTitle.TabIndex = 16;
            this.picTitle.TabStop = false;
            // 
            // buttonLan
            // 
            this.buttonLan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLan.Location = new System.Drawing.Point(263, 25);
            this.buttonLan.Name = "buttonLan";
            this.buttonLan.Size = new System.Drawing.Size(50, 30);
            this.buttonLan.TabIndex = 17;
            this.buttonLan.Text = "中";
            this.buttonLan.UseVisualStyleBackColor = false;
            this.buttonLan.Click += new System.EventHandler(this.buttonLan_Click);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 356);
            this.Controls.Add(this.buttonLan);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.lblRule);
            this.Name = "FormRules";
            this.Text = "How To Play";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button buttonLan;
    }
}