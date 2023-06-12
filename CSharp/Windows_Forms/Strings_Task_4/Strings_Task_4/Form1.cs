using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Count_Vowels_Click(object sender, EventArgs e)
        {
            L_Output.Text = $"The sentence contains {countVowels(TB_Input.Text)} vowels";
        }

        private int countVowels(string Input)
        {
            Input = Input.ToLower();
            int Output = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == 0x61 || Input[i] == 0x65 || Input[i] == 0x69 || Input[i] == 0x6F || Input[i] == 0x75)
                    Output++;
            }

            return Output;
        }
    }
}
