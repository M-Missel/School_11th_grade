using StringGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int[,] spielplan = new int[3, 3];
        int spieler = 0, spielzeuge = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Enable(object sender, EventArgs e)
        {
            initArray();
            aktualisiereStringGrid();
            spieler = ermittleStartSpieler();
            schreibeInSpielerlabel(gibSpielerName());
            spielzeuge = 0;
            SG_Output.Enabled = true;
        }

        public void SB_Spielbrett_SelectCell(object sender, StringGrid.SelectCellEventArgs e)
        {
            int x_pos = e.ACol, y_pos = e.ARow;

            if (istFrei(x_pos, y_pos))
            {
                spielplan[x_pos, y_pos] = spieler;
                spielzeuge++;
                aktualiesiereSGZelle(x_pos, y_pos);
                if (pruefeGewonnen(x_pos, y_pos))
                {
                    MessageBox.Show($"Der Spieler {gibSpielerName()} hat das Spiel gewonnen");
                    SG_Output.Enabled = false;
                }
                else
                {
                    if (spielzeuge <= 9)
                    {
                        wechsleSpieler();
                        schreibeInSpielerlabel(gibSpielerName());
                    }
                    else
                    {
                        schreibeInSpielerlabel("Unentschieden");
                        SG_Output.Enabled = false;
                    }
                }
            }
        }

        private void initArray()
        {
            for (int i = 0; i < spielplan.GetLength(0); i++)
            {
                for (int k = 0; k < spielplan.GetLength(1); k++)
                {
                    spielplan[i, k] = -1;
                }
            }
        }

        private int ermittleStartSpieler()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }

        private void wechsleSpieler()
        {
            spieler = (spieler == 0) ? 1 : 0;
        }

        private void aktualiesiereSGZelle(int x, int y)
        {
            SG_Output[x, y] = (spielplan[x, y] == -1) ? "_" : (spielplan[x, y] == 0) ? "0" : "1";
        }

        private void aktualisiereStringGrid()
        {
            for (int i = 0; i < spielplan.GetLength(0); i++)
            {
                for (int k = 0; k < spielplan.GetLength(1); k++)
                {
                    aktualiesiereSGZelle(i, k);
                }
            }
        }

        private void schreibeInSpielerlabel(string text)
        {
            LB_Next_Player.Text = text;
        }

        private bool pruefeZeile(int y)
        {
            return (spielplan[0,y] == spielplan[1,y]) ? (spielplan[0,y] == spielplan[2,y]) : false;
        }

        private bool pruefeSpalte(int x)
        {
            return (spielplan[x, 0] == spielplan[x, 1]) ? (spielplan[x, 0] == spielplan[x, 2]) : false;
        }

        private bool pruefeDiagonal()
        {
            if (spielplan[1, 1] == -1)
                return false;
            else if (spielplan[0, 0] == spielplan[1, 1] && spielplan[1, 1] == spielplan[2, 2])
                return true;
            else if (spielplan[2, 0] == spielplan[1, 1] && spielplan[1, 1] == spielplan[0, 2])
                return true;
            else
                return false;
        }

        private bool pruefeGewonnen(int x, int y)
        {
            return (pruefeZeile(y) || pruefeSpalte(x) || pruefeDiagonal());
        }

        private bool istFrei(int x, int y)
        {
            return (spielplan[x, y] == -1);
        }

        private string gibSpielerName()
        {
            return (spieler == 0) ? "Tic(O)" : "Tac(X)";
        }
    }
}
