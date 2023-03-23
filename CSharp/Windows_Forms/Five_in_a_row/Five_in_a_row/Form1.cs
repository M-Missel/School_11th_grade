using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Five_in_a_row
{
    public partial class Form1 : Form
    {
        char[,] chars = new char[10, 8];
        char currentPlayer = 'W';

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Start_Click(object sender, EventArgs e)
        {
            startGame();
            SG_Output.Enabled = true;
        }

        private void writeChar(int x_pos, int y_pos, char mark)
        {
            chars[x_pos, y_pos] = mark;
        }

        private char readChar(int x_pos, int y_pos)
        {
            return chars[x_pos, y_pos];
        }

        private void init_Array()
        {
            for (int i = 1; i < chars.GetLength(1); i++)
            {
                for (int k = 1; k < chars.GetLength(0); k++)
                {
                    chars[k, i] = 'F';
                }
            }
        }

        private void writeArrayToStringGrid()
        {
            for (int i = 1; i < chars.GetLength(1); i++)
            {
                for (int k = 1; k < chars.GetLength(0); k++)
                {
                    SG_Output[k,i] = (chars[k, i] != 'F') ? chars[k, i].ToString() : " ";
                }
            }
        }

        private void showPlayer()
        {
            LB_Player_Next.Text = $"The Player {currentPlayer} turn"; 
        }

        private void startGame()
        {
            init_Array();
            writeArrayToStringGrid();
            showPlayer();
        }

        public void setStone(object sender, StringGrid.SelectCellEventArgs e)
        {
            if (readChar(e.ACol, e.ARow) == 'F')
            {
                writeChar(e.ACol, e.ARow, currentPlayer);
                writeArrayToStringGrid();
                if (returnMaxValue(e.ACol, e.ARow) == 5)
                {
                    MessageBox.Show($"The User {currentPlayer} wins the game");
                    SG_Output.Enabled = false;
                }
                else
                {
                    changePlayer();
                    showPlayer();
                }
            }
        }

        private void changePlayer()
        {
            currentPlayer = (currentPlayer == 'W') ? 'S' : 'W';
        }

        private int checkVertical(int x_pos)
        {
            int counter = 0;
            for (int i = 1; i < chars.GetLength(1); i++)
            {
                if (chars[x_pos, i] == currentPlayer)
                {
                    counter++;
                    if (counter == 5)
                        return counter;
                }
                else
                    counter = 0;
            }

            return counter;
        }

        private int checkHorizontal(int y_pos)
        {
            int counter = 0;
            for (int i = 1; i < chars.GetLength(0); i++)
            {
                if (chars[i, y_pos] == currentPlayer)
                {
                    counter++;
                    if (counter == 5)
                        return counter;
                }
                else
                    counter = 0;
            }

            return counter;
        }

        private int checkDiagonalLeft(int x_pos, int y_pos)
        {
            int temp_x_pos = x_pos -1;
            int temp_y_pos = y_pos -1;
            int counter = 0;

            while (temp_x_pos >= 1 && temp_y_pos >= 1)
            {
                if (chars[temp_x_pos, temp_y_pos] == currentPlayer)
                {
                    counter++;
                }
                temp_x_pos--;
                temp_y_pos--;
            }

            while (x_pos <= chars.GetLength(0) -1 && y_pos <= chars.GetLength(1) -1)
            {
                if (chars[x_pos, y_pos] == currentPlayer)
                {
                    counter++;
                }
                x_pos++;
                y_pos++;
            }

            return counter;
        }

        private int checkDiagonalRight(int x_pos, int y_pos)
        {
            int temp_x_pos = x_pos - 1;
            int temp_y_pos = y_pos - 1;
            int counter = 0;

            while (temp_x_pos >= 1 && temp_y_pos <= chars.GetLength(1) - 1)
            {
                if (chars[temp_x_pos, temp_y_pos] == currentPlayer)
                {
                    counter++;
                }
                temp_x_pos--;
                temp_y_pos++;
            }

            while (x_pos <= chars.GetLength(0) - 1 && y_pos >=1)
            {
                if (chars[x_pos, y_pos] == currentPlayer)
                {
                    counter++;
                }
                x_pos++;
                y_pos--;
            }

            return counter;
        }

        private int returnMaxValue(int x_pos, int y_pos)
        {
            return Math.Max(checkHorizontal(y_pos), Math.Max(checkVertical(x_pos), Math.Max(checkDiagonalLeft(x_pos, y_pos), checkDiagonalRight(x_pos, y_pos))));
        }
    }
}
