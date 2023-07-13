using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Rekursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TB_Input_TextChanged(object sender, EventArgs e)
        {
            TB_Output.Text = createCharSet(Convert.ToInt32(TB_Input.Text));
        }

        private string createCharSet(int n)
        {
            if (n == 0)
                return "0";
            else
                return createCharSet(n - 1) + " " + n;

        }
    }
}
