using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Forms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CB_ActivateAusgabe_CheckedChanged(object sender, EventArgs e)
        {
            if (T_TestAusgabe.Enabled == false)
            {
                T_TestAusgabe.Enabled = true;
            }
            else
            {
                T_TestAusgabe.Enabled = false;
            }
        }

        private void B_SetAusgabe_Click(object sender, EventArgs e)
        {
            T_TestAusgabe.Text = "Hello World";
        }

        private void T_Ausgabe_Click(object sender, EventArgs e)
        {
            T_TestAusgabe.Text = "Hello World2";
        }
    }
}
