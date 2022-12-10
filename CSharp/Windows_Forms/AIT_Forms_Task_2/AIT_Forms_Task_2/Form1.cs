using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Area(object sender, EventArgs e)
        {
            T_Area.Text = Convert.ToString(Convert.ToDouble(T_Length.Text) * Convert.ToDouble(T_Width.Text));
        }
    }
}
