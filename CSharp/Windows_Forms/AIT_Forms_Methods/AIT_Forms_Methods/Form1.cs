using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AIT_Forms_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void straftarbeit(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TB_Anzahl.Text);
            output(TB_Name.Text, TB_Straftext.Text, i);
            fileoutput(TB_Straftext.Text, i);
        }

        private void output(string pName, string pText, int pCount)
        {
            if (LB_Output.Items.Count > 0)
                LB_Output.Items.Clear();

            LB_Output.Items.Add(pName);
            
            for (int i = 0; i < pCount; i++)
                LB_Output.Items.Add(pText);
        }

        private void fileoutput(string pText, int pCount)
        {
            StreamWriter writer = new StreamWriter("strafarbeit.txt");

            for (int i = 0; i < pCount; i++)
            {
                writer.WriteLine(pText);
            }

            writer.Close(); 
        }
    }
}
