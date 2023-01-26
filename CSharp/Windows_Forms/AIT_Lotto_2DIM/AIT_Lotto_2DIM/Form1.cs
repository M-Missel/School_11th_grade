using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Lotto_2DIM
{
    public partial class Form1 : Form
    {
        int[,] lotto = new int[7, 7], ints = new int[7,7];

        public Form1()
        {
            InitializeComponent();
        }

        public void btn_init_array(object sender, EventArgs e)
        {
            lotto = init_array(lotto);
        }

        public void btn_input_numbers(object sender, EventArgs e)
        {
            lotto = testfiels(lotto);
        }

        public void btn_output_number(object sender, EventArgs e)
        {
            outputStringGrid();
        }

        public void btn_lotto_number(object sender, EventArgs e)
        {
            outputLottoNumbers(lotto);
        }

        public void btn_play_lotto(object sender, EventArgs e)
        {
            ints = init_array(ints);
            ints = addLottoNumbers(ints);
            outputLottoNumbers(ints);
        }

        private int[,] init_array(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int k = 0; k < array.GetLength(0); k++)
                {
                    array[i, k] = 1;
                }
            }

            return array;
        }

        private int[,] testfiels(int[,] array)
        {
            array[0, 0] = -1;
            array[1, 1] = -1;
            array[2, 2] = -1;
            array[3, 3] = -1;
            array[4, 4] = -1;
            array[5, 5] = -1;

            return array;
        }

        private void outputStringGrid()
        {
            for (int i = 0; i < lotto.GetLength(0); i++)
            {
                for (int k = 0; k < lotto.GetLength(1); k++)
                {
                    if (lotto[k,i] != -1)
                    {
                        ST_OUTPUT[k, i] = calcCell(i, k).ToString();
                    }
                    else
                    {
                        ST_OUTPUT[k, i] = "-1";
                    }
                }
            }
        }

        private void outputLottoNumbers(int[,] array)
        {
            LB_LOTTO_NUMMERN.Items.Clear();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[k, i] == -1)
                    {
                        LB_LOTTO_NUMMERN.Items.Add(calcCell(i,k));
                    }
                }
            }
        }

        private int[,] addLottoNumbers(int[,] array)
        {
            int count = 0, xValue, yValue;
            Random random = new Random();
            
            while (count < 6)
            {
                xValue = random.Next(0, 6);
                yValue = random.Next(0, 6);

                if (array[yValue,xValue] == 1)
                {
                    array[yValue,xValue] = -1;
                    count++;
                }
            }

            return array;
        }

        private int calcCell(int y, int x)
        {
            int output;

            output = y * 7 + x + 1;

            return output;
        }
    }
}
