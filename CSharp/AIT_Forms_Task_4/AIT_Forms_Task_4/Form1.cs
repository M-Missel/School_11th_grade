using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Fahrenheit(object sender, EventArgs e)
        {
            T_Fahrenheit.Text = Convert.ToString(Math.Round(Convert.ToDouble(T_Celcuis.Text) * 1.8 +32, 2));
        }

        private void Exit_Application(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
