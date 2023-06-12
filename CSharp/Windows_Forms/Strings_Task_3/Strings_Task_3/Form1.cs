using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Check_Click(object sender, EventArgs e)
        {
            if (emailCheck(TB_Input.Text) == false)
                TB_Input.BackColor = Color.Red;
            else 
                TB_Input.BackColor = Color.Green;
        }

        private bool emailCheck(string Input)
        {
            int AtControl = 0, PointControl = 0;
            bool GapCheck = false;

            if (Input[0] == '@')
                return false;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == '@')
                    AtControl++;

                if (AtControl == 1)
                {
                    if (Input[i] == '.')
                        PointControl++;
                    if (Input[i] == '@' && Input[i+1] != '.')
                        GapCheck = true;
                }
            }

            if (AtControl == 1 && PointControl > 0 && GapCheck == true)
                return true; 
            else return false;
        }
    }
}
