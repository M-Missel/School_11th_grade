using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Amicable_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calc(object sender, EventArgs e)
        {
            amicable_numbers(Convert.ToInt32(TB_Input.Text));
        }

        private void amicable_numbers(int number)
        {
            int ets1 = 0, ets2 = 0; 
            for (int i = 2; i <= number; i++) 
            {
                ets1 = calc_ets(i);
                ets2 = calc_ets(ets1);
                if (i == ets2 && ets1 != ets2)
                {
                    LB_Output.Items.Add(ets1 + " " + ets2);
                }
            }
        }

        private int calc_ets(int number)
        {
            int output = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    output += i;
                }
            }

            return output;
        }
    }
}
