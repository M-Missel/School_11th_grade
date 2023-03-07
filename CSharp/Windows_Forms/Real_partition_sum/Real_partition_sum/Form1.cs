using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_partition_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calc_Ets(object sender, EventArgs e)
        {
            TB_Output.Text = Convert.ToString(calc_ets(Convert.ToInt32(TB_Number.Text)));
        }

        private void BTN_Calc_Ets_Numbers(object sender, EventArgs e)
        {
            for (int i = 2; i <= Convert.ToInt32(TB_Number.Text); i++)
            {
                LB_Output.Items.Add(calc_ets(i));
            }
        }

        private int calc_ets(int number)
        {
            int output = 0;

            for (int i = 1; i <= number/2; i++)
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
