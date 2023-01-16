using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Array_Sort
{
    public partial class Form1 : Form
    {
        int[] array = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            L_Array.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1,101);
                L_Array.Items.Add(array[i]);
            }
        }

        private void Output(object sender, EventArgs e) {
            RTB_Ausgabe.Text = "-1";
            for (int i = 0; i < array.Length; i++)
            {
                if (Convert.ToInt32(T_Suchwert.Text) == array[i])
                    RTB_Ausgabe.Text = "Der Wert " + T_Suchwert.Text + " ist im Element z[" + i + "]";
            }
        }
    }
}
