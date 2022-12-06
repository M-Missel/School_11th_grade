using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Background_Red(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Background_Green(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Background_Blue(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
