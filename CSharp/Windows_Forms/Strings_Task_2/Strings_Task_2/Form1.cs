using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Click_reverse(object sender, EventArgs e)
        {
            TB_Output.Text = reverseString(TB_Input.Text);
        }

        private string reverseString(string Input)
        {
            char[] chars = new char[Input.Length];
            int k = 0;

            for (int i = Input.Length -1; i >= 0; i--)
            {
                chars[k++] = Input[i];
            }

            return new string(chars);
        }
    }
}
