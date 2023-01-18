using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Array_StringGrid
{
    public partial class Form1 : Form
    {
        int[,] ints = new int[10,10];

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_INIT_ARRAY(object sender, EventArgs e)
        {
            fillArray(ints);
            showArray(ints);
        }

        public void BTN_SEARCH_MAX(object sender, EventArgs e)
        {
            searchMax(ints);
        }

        public void BTN_SEARCH_MIN(object sender, EventArgs e)
        {
            searchMin(ints);
        }

        private void searchMax(int[,] array)
        {
            int controll = array[0,0];
            int[] xypos = { -1, -1 };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i,k] > controll)
                    {
                        controll = array[i,k];
                        xypos[0] = i;
                        xypos[1] = k;
                    }
                }
            }

            Output_Message(xypos[0], xypos[1], controll);
        }

        private void searchMin(int[,] array)
        {
            int[] xypos = { -1, -1 };
            int minValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (minValue > array[i, k])
                    {
                        minValue = array[i, k];
                        xypos[0] = i;
                        xypos[1] = k;
                    }
                }
            }

            Output_Message(xypos[0], xypos[1], minValue);
        }

        private int[,] fillArray(int[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = random.Next(0,51);
                }
            }

            return array;
        }

        private void showArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    SG_OUTPUT[i, k] = array[i, k].ToString();
                }
            }
        }

        private void Output_Message(int xpos, int ypos, int value)
        {
            MessageBox.Show($"The Object with the searched Value is in position {xpos} | {ypos} and has the Value {value}");
        }
    }
}
