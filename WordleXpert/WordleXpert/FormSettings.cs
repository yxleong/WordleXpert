﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleXpert
{
    public partial class FormSettings : Form
    {
        private static string SetLanguage;
        private static string SetWordLength;
        private static bool SetHardMode;
        private static bool SetDebugging;
        private static bool SetDark;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            SetLanguage = Program.Language;
            SetWordLength = Program.WordLength.ToString();
            SetHardMode = Program.IsHardMode;
            SetDebugging = Program.IsDebugging;
            SetDark = Program.IsDark;

            cboLanguage.Text = SetLanguage;
            cboWordLength.Text = SetWordLength;

            lblHardModeInfo.Visible = false;
            checkBoxHD.Checked = Program.IsHardMode;
            checkBoxTheme.Checked = Program.IsDark;
            checkBoxDebug.Checked = Program.IsDebugging;
            
            PrintSettings();

            // normal mode
            txtTest.Visible = false;
        }

        private void PrintSettings()
        {
            txtTest.Text = Program.Language + " (" + SetLanguage + ") | ";
            txtTest.Text += Program.WordLength.ToString() + " (" + SetWordLength + ") | ";
            txtTest.Text += "Hard Mode: " + Program.IsHardMode.ToString() + " | ";
            txtTest.Text += "Debug: " + Program.IsDebugging.ToString();
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLanguage = cboLanguage.Text;
            PrintSettings();
        }

        private void cboWordLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWordLength = cboWordLength.Text;
            PrintSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!Program.IsInGame)
            {
                Program.Language = SetLanguage;
                Program.WordLength = Convert.ToInt32(SetWordLength);
                Program.IsHardMode = SetHardMode;
                Program.IsDebugging = SetDebugging;
                Program.IsDark = SetDark;
            }
            else if (SetLanguage != Program.Language || SetWordLength != Program.WordLength.ToString() ||
                SetDark != Program.IsDark || SetDebugging != Program.IsDebugging)
            {
                using (var formConfirmSettings = new FormConfirmSettings())
                {
                    formConfirmSettings.StartPosition = FormStartPosition.CenterParent;
                    var result = formConfirmSettings.ShowDialog();

                    // restart the game with new changes
                    if (result == DialogResult.OK)
                    {
                        Program.Language = SetLanguage;
                        Program.WordLength = Convert.ToInt32(SetWordLength);
                        Program.IsHardMode = SetHardMode;
                        Program.IsDebugging = SetDebugging;
                        Program.IsDark = SetDark;

                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }
            else
            {
                Program.IsHardMode = SetHardMode;
            }
            this.Close();
        }

        private void checkBoxHD_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.DisableHardMode)
            {
                checkBoxHD.Checked = Program.IsHardMode;
                lblHardModeInfo.Visible = true;
            }
            else
            {
                SetHardMode = checkBoxHD.Checked;
            }
            PrintSettings();
        }

        private void checkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            SetDebugging = checkBoxDebug.Checked;
            PrintSettings();
        }

        private void checkBoxTheme_CheckedChanged(object sender, EventArgs e)
        {
            SetDark = checkBoxTheme.Checked;
        }
    }
}
