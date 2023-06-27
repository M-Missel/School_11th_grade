using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insertionsort
{
    public partial class Form1 : Form
    {
        private int[] ints = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Init_Array_Click(object sender, EventArgs e)
        {
            initArray();
        }

        private void BTN_Insertionsort_Click(object sender, EventArgs e)
        {
            Insertionsort();
        }

        private void BTN_PrintOut_Click(object sender, EventArgs e)
        {
            printOut(); 
        }

        private void initArray()
        {
            Random rnd = new Random();

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(0,101);
            }
        }

        private void printOut()
        {
            LB_output.Items.Clear();
            for (int i = 0; i < ints.Length; i++)
            {
                LB_output.Items.Add(ints[i]);
            }
        }

        private void Insertionsort()
        {
            for (int i = 0; i < ints.Length -1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (ints[j-1] > ints[j])
                    {
                        swap(j-1, j);
                    }
                }

            }
        }

        private void swap(int index_a, int index_b)
        {
            int temp = ints[index_a];
            ints[index_a] = ints[index_b];
            ints[index_b] = temp;
        }
    }
}
