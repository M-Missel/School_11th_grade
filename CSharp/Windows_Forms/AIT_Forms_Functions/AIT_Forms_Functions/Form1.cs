using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            TB_Erge.Text = Convert.ToString(add_1_n(Convert.ToInt32(TB_Obgr.Text)));
        }

        private void Add_Random(object sender, EventArgs e)
        {
            int p = 0;
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                p = random.Next(1, 1001);
                LB_Output.Items.Add($"Obergrenze {p} -> Summe: {Convert.ToString(add_1_n(p))}");
            }
        }

        /* Task 1
        private int add_1_20()
        {
            int output = 0;

            for (int i = 0; i <= 10; i++)
            {
                output += i;
            }

            return output;
        }
        */

        private int add_1_n(int pGrenz)
        {
            int output = 0;

            for (int i = 0; i <= pGrenz; i++)
            {
                output += i;
            }

            return output;
        }
    }
}
