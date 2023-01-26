using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_Lotto_1Dim
{
    public partial class Form1 : Form
    {
        bool[] lotto = new bool[50];
        int[] ints = { 1, 3, 5, 7, 9, 11 }, lottonumber = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_INIT_Array(object sender, EventArgs e)
        {
            lotto = setArrayValue(lotto);
        }

        public void BTN_ADD_Numbers(object sender, EventArgs e)
        {
            lotto = setTestValue(lotto, ints);
        }

        public void BTN_OUTPUT_Gamefield(object sender, EventArgs e)
        {
            outputGameField(lotto);
        }

        public void BTN_LOTTO_PLAY(object sender, EventArgs e)
        {
            lottonumber = fillLottoNumber(lottonumber);

        }

        public void BTN_OUTPUT_LN(object sender, EventArgs e)
        {
            outputLottoNumbers(lottonumber);
        }

        private bool[] setArrayValue(bool[] bools)
        {
            for (int i = 1; i < bools.Length; i++)
            {
                bools[i] = false;
            }

            return bools;
        }

        private bool[] setTestValue(bool[] bools, int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                bools[ints[i]] = true;
            }

            return bools;
        }

        private void outputGameField(bool[] bools)
        {
            if (LB_GAMEFIELD_OUTPUT.Items.Count > 0)
            {
                LB_GAMEFIELD_OUTPUT.Items.Clear();
            }

            for (int i = 1; i < bools.Length; i++)
            {
                if (bools[i] == true)
                {
                    LB_GAMEFIELD_OUTPUT.Items.Add($"lotto[{i}]: X");
                }
                else
                {
                    LB_GAMEFIELD_OUTPUT.Items.Add($"lotto[{i}]: O");
                }
            }
        }

        private int[] fillLottoNumber(int[] ints)
        {
            Random random = new Random();
            int count = 0, randomNumber;

            while (count < 6)
            {
                randomNumber = random.Next(1, 50);

                if (lotto[randomNumber] == false)
                {
                    lotto[randomNumber] = true;
                    count++;
                }
            }

            return ints;
        }

        private void outputLottoNumbers(int[] ints)
        {
            foreach (var item in ints)
            {
                LB_LOTTO_NUMBERS.Items.Add(item);
            }
        }
    }
}
