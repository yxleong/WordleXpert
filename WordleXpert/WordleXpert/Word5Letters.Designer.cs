namespace WordleXpert
{
    partial class Word5Letters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLetter5 = new System.Windows.Forms.TextBox();
            this.txtLetter4 = new System.Windows.Forms.TextBox();
            this.txtLetter3 = new System.Windows.Forms.TextBox();
            this.txtLetter2 = new System.Windows.Forms.TextBox();
            this.txtLetter1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLetter5
            // 
            this.txtLetter5.Enabled = false;
            this.txtLetter5.Location = new System.Drawing.Point(218, 9);
            this.txtLetter5.MaxLength = 1;
            this.txtLetter5.Name = "txtLetter5";
            this.txtLetter5.ReadOnly = true;
            this.txtLetter5.Size = new System.Drawing.Size(24, 20);
            this.txtLetter5.TabIndex = 15;
            this.txtLetter5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter5.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this.txtLetter5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetter5_KeyDown);
            this.txtLetter5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter5_KeyPress);
            // 
            // txtLetter4
            // 
            this.txtLetter4.Enabled = false;
            this.txtLetter4.Location = new System.Drawing.Point(172, 9);
            this.txtLetter4.MaxLength = 1;
            this.txtLetter4.Name = "txtLetter4";
            this.txtLetter4.ReadOnly = true;
            this.txtLetter4.Size = new System.Drawing.Size(24, 20);
            this.txtLetter4.TabIndex = 14;
            this.txtLetter4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter4.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this.txtLetter4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetter_KeyDown);
            this.txtLetter4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // txtLetter3
            // 
            this.txtLetter3.Enabled = false;
            this.txtLetter3.Location = new System.Drawing.Point(122, 9);
            this.txtLetter3.MaxLength = 1;
            this.txtLetter3.Name = "txtLetter3";
            this.txtLetter3.ReadOnly = true;
            this.txtLetter3.Size = new System.Drawing.Size(24, 20);
            this.txtLetter3.TabIndex = 13;
            this.txtLetter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter3.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this.txtLetter3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetter_KeyDown);
            this.txtLetter3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // txtLetter2
            // 
            this.txtLetter2.Enabled = false;
            this.txtLetter2.Location = new System.Drawing.Point(74, 9);
            this.txtLetter2.MaxLength = 1;
            this.txtLetter2.Name = "txtLetter2";
            this.txtLetter2.ReadOnly = true;
            this.txtLetter2.Size = new System.Drawing.Size(24, 20);
            this.txtLetter2.TabIndex = 12;
            this.txtLetter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter2.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this.txtLetter2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetter_KeyDown);
            this.txtLetter2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // txtLetter1
            // 
            this.txtLetter1.Enabled = false;
            this.txtLetter1.Location = new System.Drawing.Point(28, 9);
            this.txtLetter1.MaxLength = 1;
            this.txtLetter1.Name = "txtLetter1";
            this.txtLetter1.ReadOnly = true;
            this.txtLetter1.Size = new System.Drawing.Size(24, 20);
            this.txtLetter1.TabIndex = 11;
            this.txtLetter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter1.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this.txtLetter1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // Word5Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLetter5);
            this.Controls.Add(this.txtLetter4);
            this.Controls.Add(this.txtLetter3);
            this.Controls.Add(this.txtLetter2);
            this.Controls.Add(this.txtLetter1);
            this.Name = "Word5Letters";
            this.Size = new System.Drawing.Size(270, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter5;
        private System.Windows.Forms.TextBox txtLetter4;
        private System.Windows.Forms.TextBox txtLetter3;
        private System.Windows.Forms.TextBox txtLetter2;
        private System.Windows.Forms.TextBox txtLetter1;
    }
}
