using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Task_5
{
    public partial class Form1 : Form
    {
        int certainCharacter = 0, totalCharacter = 0;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = P_ShowPercent.CreateGraphics();
        }

        public void BTN_Execute_Click(object sender, EventArgs e)
        {
            if(CB_Count_Vowels.Checked)
                L_Output.Text = $"The sentence contains {countVowels(TB_Input.Text)} vowels";
            if (CB_Character_Frequency.Checked)
            {
                certainCharacter = countOccurrenceCharacters(TB_Input.Text, Convert.ToChar(TB_Input_Character.Text));
                totalCharacter = determineNumberCharacters(TB_Input.Text);
                g.FillRectangle(Brushes.Red, 0, 100 - frequency(), 30, 100);
                L_Number_Vowels.Text = $"{totalCharacter} Letters in total";
                L_Output_Vowel_Status.Text = $"{frequency()}% Frequency of the Letter {TB_Input_Character.Text}";
            }
                
        }

        private int countVowels(string Input)
        {
            Input = Input.ToLower();
            int output = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == 0x61 || Input[i] == 0x65 || Input[i] == 0x69 || Input[i] == 0x6F || Input[i] == 0x75)
                    output++;
            }

            return output;
        }

        private int countOccurrenceCharacters(string Input, char Character)
        {
            int output = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == Character)
                    output++;
            }

            return output;
        }

        private int determineNumberCharacters(string Input)
        {
            int output = 0;
            Input = Input.ToLower();

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] >= 'a' && Input[i] <= 'z')
                    output++;
            }

            return output;
        }

        private float frequency()
        {
            return (float)certainCharacter / (float)totalCharacter * 100;
        }
    }
}
