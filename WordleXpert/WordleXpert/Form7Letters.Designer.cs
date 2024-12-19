namespace WordleXpert
{
    partial class Form7Letters
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
            this.word1 = new WordleXpert.Word7Letters();
            this.word2 = new WordleXpert.Word7Letters();
            this.word3 = new WordleXpert.Word7Letters();
            this.word4 = new WordleXpert.Word7Letters();
            this.word5 = new WordleXpert.Word7Letters();
            this.word6 = new WordleXpert.Word7Letters();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.pictureTheme = new System.Windows.Forms.PictureBox();
            this.pictureHow = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(573, 367);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtAnswer.TabIndex = 41;
            // 
            // word1
            // 
            this.word1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word1.Location = new System.Drawing.Point(168, 151);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(356, 35);
            this.word1.TabIndex = 42;
            this.word1.WordEntered += new System.EventHandler(this.word1_WordEntered);
            // 
            // word2
            // 
            this.word2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word2.Location = new System.Drawing.Point(168, 191);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(356, 35);
            this.word2.TabIndex = 43;
            this.word2.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word3
            // 
            this.word3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word3.Location = new System.Drawing.Point(168, 232);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(356, 35);
            this.word3.TabIndex = 44;
            this.word3.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word4
            // 
            this.word4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word4.Location = new System.Drawing.Point(168, 273);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(356, 35);
            this.word4.TabIndex = 45;
            this.word4.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word5
            // 
            this.word5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word5.Location = new System.Drawing.Point(168, 313);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(356, 35);
            this.word5.TabIndex = 46;
            this.word5.WordEntered += new System.EventHandler(this.word_WordEntered);
            // 
            // word6
            // 
            this.word6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.word6.Location = new System.Drawing.Point(168, 354);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(356, 35);
            this.word6.TabIndex = 47;
            this.word6.WordEntered += new System.EventHandler(this.word6_WordEntered);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnM.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(467, 532);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(41, 48);
            this.btnM.TabIndex = 85;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(420, 532);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(41, 48);
            this.btnN.TabIndex = 86;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnB.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(373, 532);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(41, 48);
            this.btnB.TabIndex = 87;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnV.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(326, 532);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(41, 48);
            this.btnV.TabIndex = 88;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnC.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(277, 532);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(41, 48);
            this.btnC.TabIndex = 80;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnX.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(230, 532);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(41, 48);
            this.btnX.TabIndex = 81;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBS.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.Location = new System.Drawing.Point(511, 532);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(66, 48);
            this.btnBS.TabIndex = 84;
            this.btnBS.Text = "←";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(111, 532);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(66, 48);
            this.btnEnter.TabIndex = 83;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZ.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(183, 532);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(41, 48);
            this.btnZ.TabIndex = 82;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnL.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(514, 478);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(41, 48);
            this.btnL.TabIndex = 74;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnK.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(467, 478);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(41, 48);
            this.btnK.TabIndex = 75;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJ.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(420, 478);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(41, 48);
            this.btnJ.TabIndex = 76;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnH.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(373, 478);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(41, 48);
            this.btnH.TabIndex = 77;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnG.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(326, 478);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(41, 48);
            this.btnG.TabIndex = 78;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnF.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(279, 478);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(41, 48);
            this.btnF.TabIndex = 79;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnD.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(230, 478);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(41, 48);
            this.btnD.TabIndex = 71;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnS.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(183, 478);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(41, 48);
            this.btnS.TabIndex = 72;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnA.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(136, 478);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(41, 48);
            this.btnA.TabIndex = 73;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnP.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(536, 424);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(41, 48);
            this.btnP.TabIndex = 66;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnO.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(489, 424);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(41, 48);
            this.btnO.TabIndex = 64;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnI.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(442, 424);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(41, 48);
            this.btnI.TabIndex = 65;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnU.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(395, 424);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(41, 48);
            this.btnU.TabIndex = 68;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnY.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(348, 424);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(41, 48);
            this.btnY.TabIndex = 67;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnT.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(301, 424);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(41, 48);
            this.btnT.TabIndex = 69;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnR.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(254, 424);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(41, 48);
            this.btnR.TabIndex = 70;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnE.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(205, 424);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(41, 48);
            this.btnE.TabIndex = 62;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnW.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(158, 424);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(41, 48);
            this.btnW.TabIndex = 63;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQ.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(111, 424);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(41, 48);
            this.btnQ.TabIndex = 61;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btn_OnScreen_Entered);
            // 
            // pictureTheme
            // 
            this.pictureTheme.BackgroundImage = global::WordleXpert.Properties.Resources.Change_color;
            this.pictureTheme.Location = new System.Drawing.Point(97, 98);
            this.pictureTheme.Name = "pictureTheme";
            this.pictureTheme.Size = new System.Drawing.Size(25, 26);
            this.pictureTheme.TabIndex = 89;
            this.pictureTheme.TabStop = false;
            this.pictureTheme.Click += new System.EventHandler(this.pictureTheme_Click);
            // 
            // pictureHow
            // 
            this.pictureHow.BackgroundImage = global::WordleXpert.Properties.Resources.HowToPlay;
            this.pictureHow.Location = new System.Drawing.Point(61, 99);
            this.pictureHow.Name = "pictureHow";
            this.pictureHow.Size = new System.Drawing.Size(24, 24);
            this.pictureHow.TabIndex = 91;
            this.pictureHow.TabStop = false;
            this.pictureHow.Click += new System.EventHandler(this.pictureHow_Click);
            // 
            // picSetting
            // 
            this.picSetting.BackgroundImage = global::WordleXpert.Properties.Resources.Setting;
            this.picSetting.Location = new System.Drawing.Point(24, 98);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(25, 26);
            this.picSetting.TabIndex = 92;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTime.Location = new System.Drawing.Point(507, 99);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(62, 24);
            this.labelTime.TabIndex = 93;
            this.labelTime.Text = "Timer";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Window;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUser.Location = new System.Drawing.Point(507, 77);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 24);
            this.lblUser.TabIndex = 94;
            this.lblUser.Text = "Guest";
            // 
            // Form7Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordleXpert.Properties.Resources.Play_Background_7;
            this.ClientSize = new System.Drawing.Size(715, 604);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureTheme);
            this.Controls.Add(this.pictureHow);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.word6);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.txtAnswer);
            this.Name = "Form7Letters";
            this.Text = "WordleXpert";
            this.Load += new System.EventHandler(this.Form7Letters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnswer;
        private Word7Letters word1;
        private Word7Letters word2;
        private Word7Letters word3;
        private Word7Letters word4;
        private Word7Letters word5;
        private Word7Letters word6;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.PictureBox pictureTheme;
        private System.Windows.Forms.PictureBox pictureHow;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label lblUser;
    }
}