using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordleXpert
{
    public partial class Word5Letters : UserControl
    {
        public Word5Letters()
        {
            InitializeComponent();
            int letterCount = 0;

            HandleLetterFocus(letterCount);
        }

        private void HandleLetterFocus(int letterCount)
        {
            txtLetter1.ReadOnly = !(letterCount == 0);
            txtLetter2.ReadOnly = !(letterCount == 1);
            txtLetter3.ReadOnly = !(letterCount == 2);
            txtLetter4.ReadOnly = !(letterCount == 3);
            txtLetter5.ReadOnly = !(letterCount == 4);

            switch (letterCount)
            {
                case 0: txtLetter1.Focus(); break;
                case 1: txtLetter2.Focus(); break;
                case 2: txtLetter3.Focus(); break;
                case 3: txtLetter4.Focus(); break;
                case 4: txtLetter5.Focus(); break;
                default: break;
            }
        }
    }
}
