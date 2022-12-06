using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            int Red = 0, Green = 0, Blue = 0;

            if (T_EditRed.Text.ToLower() == "ff")
            {
                Red = Convert.ToInt32(T_EditRed.Text, 16);
            }
            if (T_EditGreen.Text.ToLower() == "ff")
            {
                Green = Convert.ToInt32(T_EditGreen.Text, 16);
            }
            if (T_EditBlue.Text.ToLower() == "ff")
            {
                Blue = Convert.ToInt32(T_EditBlue.Text, 16);
            }

            BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void ShowTbs(object sender, EventArgs e)
        {
            T_EditRed.Visible = true;
            T_EditGreen.Visible = true;
            T_EditBlue.Visible = true;
        }

        private void HideTbs(object sender, EventArgs e)
        {
            T_EditRed.Visible = false;
            T_EditGreen.Visible = false;
            T_EditBlue.Visible = false;
        }
    }
}
