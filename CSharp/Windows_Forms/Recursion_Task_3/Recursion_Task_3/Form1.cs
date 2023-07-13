using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion_Task_3
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Fibo_Click(object sender, EventArgs e)
        {
            LB_Output.Items.Add(fib(Convert.ToInt32(TB_Upper_Limit.Text)));
            MessageBox.Show(count.ToString());
        }

        private int fib(int number)
        {
            count++;
            if (number == 0) return 0;
            if (number == 1) return 1;

            return fib(number - 1) + fib(number - 2);
        }
    }
}
