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
    public partial class FormLose : Form
    {
        private static string Answer;
        public FormLose(string answer)
        {
            InitializeComponent();

            Answer = answer;
        }

        private void FormLose_Load(object sender, EventArgs e)
        {
            lblAnswer.Text += Answer;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}