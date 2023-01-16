using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Arrays_LBs
{
    public partial class Form1 : Form
    {
        int[] ints = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_FILL_ARRAY(object sender, EventArgs e)
        {
            fillArray(ints);
        }

        public void BTN_SHOW_LB(object sender, EventArgs e)
        {
            fillListBox(ints);
        }

        public void BTN_SHOW_GREATEST_VALUE(object sender, EventArgs e)
        {
            maxSearch();
        }

        public void BTN_SHOW_LEAST_VALUE(object sender, EventArgs e)
        {
            minSearch();
        }

        static int[] fillArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,51);
            }

            return array;
        }

        private void fillListBox(int[] array)
        {
            if (LB_OUTPUT.Items.Count > 0)
            {
                LB_OUTPUT.Items.Clear();
            }

            for (int i = 0; i < array.Length; i++)
            {
                LB_OUTPUT.Items.Add($"Elementnr. {i} : {array[i]}");
            }
        }

        private void maxSearch()
        {
            int maxValue = ints[0], pos = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (maxValue < ints[i])
                {
                    maxValue = ints[i];
                    pos = i;
                }
            }

            MessageBox.Show($"The Object with the searched Value is in position {pos} and has the Value {maxValue}");
        }

        private void minSearch()
        {
            int minValue = ints[0], pos = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (minValue > ints[i])
                {
                    minValue = ints[i];
                    pos = i;
                }
            }

            MessageBox.Show($"The Object with the searched Value is in position {pos} and has the Value {minValue}");
        }
    }
}
