using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Forms_Arrays_Min_Max
{
    public partial class Form1 : Form
    {
        int[] ints = new int[10];
        int[,] ints2d = new int[10,10];

        public Form1()
        {
            InitializeComponent();

            ints = fill_Array(ints);
            ints2d = fill_Array(ints2d);

            Elements2List(ints);
            Elements2List(ints2d);
        }

        private void Min_Search(object sender, EventArgs e)
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

            Output_Message(pos, minValue);
        }

        private void Min_Search2D(object sender, EventArgs e)
        {
            int[] pos = { -1, -1 };
            int minValue = ints2d[0, 0];

            for (int i = 0; i < ints2d.GetLength(0); i++)
            {
                for (int k = 0; k < ints2d.GetLength(1); k++)
                {
                    if (minValue > ints2d[i, k])
                    {
                        minValue = ints2d[i, k];
                        pos[0] = i;
                        pos[1] = k;
                    }
                }
            }

            Output_Message(pos[0], pos[1], minValue);
        }

        private void Max_Search(object sender, EventArgs e)
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

            Output_Message(pos, maxValue);
        }

        private void Max_Search2D(object sender, EventArgs e)
        {
            int[] pos = { -1, -1 };
            int maxValue = ints2d[0, 0];

            for (int i = 0; i < ints2d.GetLength(0); i++)
            {
                for (int k = 0; k < ints2d.GetLength(1); k++)
                {
                    if (maxValue < ints2d[i, k])
                    {
                        maxValue = ints2d[i, k];
                        pos[0] = i;
                        pos[1] = k;
                    }
                }
            }

            Output_Message(pos[0], pos[1], maxValue);
        }

        public void Elements2List(int[] array)
        {
            foreach(int i in array)
            {
                LB_OUTPUT.Items.Add(i);
            }
        }

        public void Elements2List(int[,] array)
        {
            foreach (int i in array)
            {
                LB_OUTPUT.Items.Add(i);
            }
        }

        public int[] fill_Array(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,51);
            }

            return array;
        }

        public int[,] fill_Array(int[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = random.Next(0, 51);
                }
            }

            return array;
        }

        private void Output_Message(int pos, int value)
        {
            MessageBox.Show($"The Object with the searched Value is in position {pos} and has the Value {value}");
        }

        private void Output_Message(int xpos, int ypos, int value)
        {
            MessageBox.Show($"The Object with the searched Value is in position {xpos} | {ypos} and has the Value {value}");
        }
    }
}
