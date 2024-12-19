namespace WordleXpert
{
    partial class FormConfirmSettings
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Restart;
            this.btnRestart.Location = new System.Drawing.Point(55, 113);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(103, 35);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::WordleXpert.Properties.Resources.btn_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(200, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormConfirmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.Restart;
            this.ClientSize = new System.Drawing.Size(371, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Name = "FormConfirmSettings";
            this.Text = "Restart Game?";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
    }
}