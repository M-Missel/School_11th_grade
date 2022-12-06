using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Dollar(object sender, EventArgs e)
        {
            if (T_ExchangeRate.Text.Count() == 0)
                T_Dollar.Text = Convert.ToString(Convert.ToDouble(T_Euro.Text) * 1.4);
            else
                T_Dollar.Text = Convert.ToString(Convert.ToDouble(T_Euro.Text) * Convert.ToDouble(T_ExchangeRate.Text));
        }

        private void Exit_Application(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
