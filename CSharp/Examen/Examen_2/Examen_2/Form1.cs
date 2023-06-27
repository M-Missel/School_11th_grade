using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Examen_2
{
    public partial class Form1 : Form
    {
        string qm_string = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Create_QM_String_Click(object sender, EventArgs e)
        {
            if (testeExponent(TB_Exponent.Text) == false)
                MessageBox.Show("Fehler: Der Exponent darf nur aus den Ziffern 0 und 1 bestehen");
            else
            {
                qm_string = qm_String(TB_Exponent.Text);
                TB_QM_String.Text = qm_string;
            }
        }

        private void BTN_x_pow_k_Click(object sender, EventArgs e)
        {
            TB_X_Times_Expo.Text = $"{qm_Exponent(qm_string, Convert.ToInt16(TB_X_Value.Text))}";
        }

        private void BTN_Calc_Decimal_Click(object sender, EventArgs e)
        {
            TB_Output_X_K.Text = $"{TB_X_Value.Text} hoch {toDezimal(TB_Exponent.Text)} = {qm_Exponent(qm_string, Convert.ToInt16(TB_X_Value.Text))}";
        }

        private bool testeExponent(string exponent)
        {
            bool output = true;

            for (int i = 0; i < qm_string.Length; i++)
            {
                if (exponent[i] != '0' || exponent[i] != '1')
                    return false;
            }

            return output;
        }

        private string qm_String(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                    qm_string += "QM";
                else
                    qm_string += "Q";
            }

            return qm_string;
        }

        private int qm_Exponent(string qm_string, int k)
        {
            double output = 1;

            for (int i = 0; i < qm_string.Length; i++)
            {
                if (qm_string[i] == 'Q')
                    output = Math.Pow(output, 2);
                else
                    output = output * k;
            }

            return (int)output;
        }

        private int toDezimal(string bin_str)
        {
            int output = 0;
            int k = bin_str.Length - 1;

            for (int i = 0; i < bin_str.Length; i++)
            {
                if (bin_str[i] == '1')
                    output += Convert.ToInt16(Math.Pow(2,k));
                k--;
            }

            return output;
        }
    }
}
