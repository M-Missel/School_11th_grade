using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectionsort
{
    public partial class Form1 : Form
    {
        private int[] daten = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Init_Array_Click(object sender, EventArgs e)
        {
            initArray();
        }

        public void BTN_Output_Array_Click(object sender, EventArgs e)
        {
            printOut();
        }

        public void BTN_Selection_Sort_Click(object sender, EventArgs e)
        {
            SelectionSort();
        }

        private void initArray()
        {
            Random random = new Random();
            for (int i = 0; i < daten.Length; i++)
            {
                daten[i] = random.Next(1, 101);
            }
        }

        private void printOut()
        {
            LB_Output.Items.Clear();
            for (int i = 0; i < daten.Length; i++)
            {
                LB_Output.Items.Add(daten[i]);
            }
        }

        private void SelectionSort()
        {
            int min, temp;
            for (int i = 0; i < daten.Length; i++)
            {
                min = i;
                for (int k = i +1; k < daten.Length; k++)
                {
                    if (daten[k] < daten[min])
                        min = k;
                }

                temp = daten[min];
                daten[min] = daten[i];
                daten[i] = temp;
            }
        }
    }
}
