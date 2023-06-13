using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_ASCII_Click(object sender, EventArgs e)
        {
            TB_Output.Text = convertStringToHex(TB_Input.Text);
        }

        private string convertStringToHex(string input)
        {
            byte[] bytes = Encoding.Default.GetBytes(input);
            string output = BitConverter.ToString(bytes);

            return output;
        }
    }
}
