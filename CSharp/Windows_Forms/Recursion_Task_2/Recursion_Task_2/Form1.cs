using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Fac_Click(object sender, EventArgs e)
        {
            if(RB_Iterative.Checked)
                calcFacIterative(Convert.ToInt32(TB_Input.Text));
            else
            {
                messageOutput(calcFacRecursive(Convert.ToInt32(TB_Input.Text)));
            }
        }

        private void calcFacIterative(int repeat)
        {
            int output = 1;

            for (int i = 1; i <= repeat; i++)
            {
                output *= i;
            }

            messageOutput(output);
        }

        private int calcFacRecursive(int fac)
        {
            if (fac == 1)
                return 1;
            else
                return fac * calcFacRecursive(fac - 1);
        }

        private void messageOutput(int output)
        {
            MessageBox.Show($"The Faculty from {TB_Input.Text} is {output}");
        }

        private void messageOutput(int output, int repeat)
        {
            MessageBox.Show($"The Faculty from {TB_Input.Text} is {output} and it takes {repeat} functions call to calculate");
        }
    }
}
