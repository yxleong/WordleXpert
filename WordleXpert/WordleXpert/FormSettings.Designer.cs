namespace WordleXpert
{
    partial class FormSettings
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
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboWordLength = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picWord = new System.Windows.Forms.PictureBox();
            this.picLanguage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBoxHD = new System.Windows.Forms.CheckBox();
            this.checkBoxTheme = new System.Windows.Forms.CheckBox();
            this.pictureBoxDebug = new System.Windows.Forms.PictureBox();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.lblHardModeInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebug)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Melayu"});
            this.cboLanguage.Location = new System.Drawing.Point(308, 36);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(121, 21);
            this.cboLanguage.TabIndex = 5;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // cboWordLength
            // 
            this.cboWordLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWordLength.FormattingEnabled = true;
            this.cboWordLength.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboWordLength.Location = new System.Drawing.Point(308, 89);
            this.cboWordLength.Name = "cboWordLength";
            this.cboWordLength.Size = new System.Drawing.Size(121, 21);
            this.cboWordLength.TabIndex = 6;
            this.cboWordLength.SelectedIndexChanged += new System.EventHandler(this.cboWordLength_SelectedIndexChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(33, 287);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(389, 20);
            this.txtTest.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_btn_confirm;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(77, 320);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 50);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_btn_cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picWord
            // 
            this.picWord.BackgroundImage = global::WordleXpert.Properties.Resources.wordLength_label;
            this.picWord.Location = new System.Drawing.Point(33, 89);
            this.picWord.Name = "picWord";
            this.picWord.Size = new System.Drawing.Size(197, 22);
            this.picWord.TabIndex = 10;
            this.picWord.TabStop = false;
            // 
            // picLanguage
            // 
            this.picLanguage.BackgroundImage = global::WordleXpert.Properties.Resources.language_label;
            this.picLanguage.Location = new System.Drawing.Point(35, 35);
            this.picLanguage.Name = "picLanguage";
            this.picLanguage.Size = new System.Drawing.Size(141, 25);
            this.picLanguage.TabIndex = 10;
            this.picLanguage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WordleXpert.Properties.Resources.hdMode_label;
            this.pictureBox1.Location = new System.Drawing.Point(35, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WordleXpert.Properties.Resources.dark_label;
            this.pictureBox3.Location = new System.Drawing.Point(35, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 26);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // checkBoxHD
            // 
            this.checkBoxHD.AutoSize = true;
            this.checkBoxHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxHD.Location = new System.Drawing.Point(403, 152);
            this.checkBoxHD.Name = "checkBoxHD";
            this.checkBoxHD.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHD.TabIndex = 11;
            this.checkBoxHD.UseVisualStyleBackColor = true;
            this.checkBoxHD.CheckedChanged += new System.EventHandler(this.checkBoxHD_CheckedChanged);
            // 
            // checkBoxTheme
            // 
            this.checkBoxTheme.AutoSize = true;
            this.checkBoxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxTheme.Location = new System.Drawing.Point(403, 203);
            this.checkBoxTheme.Name = "checkBoxTheme";
            this.checkBoxTheme.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTheme.TabIndex = 11;
            this.checkBoxTheme.UseVisualStyleBackColor = true;
            this.checkBoxTheme.CheckedChanged += new System.EventHandler(this.checkBoxTheme_CheckedChanged);
            // 
            // pictureBoxDebug
            // 
            this.pictureBoxDebug.BackgroundImage = global::WordleXpert.Properties.Resources.debug_label;
            this.pictureBoxDebug.Location = new System.Drawing.Point(35, 246);
            this.pictureBoxDebug.Name = "pictureBoxDebug";
            this.pictureBoxDebug.Size = new System.Drawing.Size(174, 21);
            this.pictureBoxDebug.TabIndex = 10;
            this.pictureBoxDebug.TabStop = false;
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxDebug.Location = new System.Drawing.Point(403, 250);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDebug.TabIndex = 11;
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
            // 
            // lblHardModeInfo
            // 
            this.lblHardModeInfo.AutoSize = true;
            this.lblHardModeInfo.Location = new System.Drawing.Point(35, 177);
            this.lblHardModeInfo.Name = "lblHardModeInfo";
            this.lblHardModeInfo.Size = new System.Drawing.Size(262, 13);
            this.lblHardModeInfo.TabIndex = 12;
            this.lblHardModeInfo.Text = "Hard mode can only be enabled at the start of a round";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.Setting_Background;
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.lblHardModeInfo);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.checkBoxTheme);
            this.Controls.Add(this.checkBoxHD);
            this.Controls.Add(this.picLanguage);
            this.Controls.Add(this.pictureBoxDebug);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.cboWordLength);
            this.Controls.Add(this.cboLanguage);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboWordLength;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picWord;
        private System.Windows.Forms.PictureBox picLanguage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBoxHD;
        private System.Windows.Forms.CheckBox checkBoxTheme;
        private System.Windows.Forms.PictureBox pictureBoxDebug;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.Label lblHardModeInfo;
    }
}