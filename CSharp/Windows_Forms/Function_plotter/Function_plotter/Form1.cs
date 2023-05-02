using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_plotter
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Brushes.Red, 2), gutter_pen;
        Graphics graphics;

        coordsystem coordsystems = new coordsystem(-5, 5, -5, 5);
        graph drawGraph = new graph();

        public Form1()
        {
            InitializeComponent();

            gutter_pen = Pens.Gray;
            graphics = P_FunctionPlotter.CreateGraphics();
        }

        /// <BTN_Functions>
        /// 
        /// BTN_Coord_System()
        ///     Check the extrem Values for the X & Y Axis
        ///     resets the Coordsystem
        ///     Print the new Coordsystem
        /// 
        /// BTN_DrawPoint_Click()
        ///     Check the Values of X & Y => defautlt 0,0
        ///     print the Point
        ///     
        /// BTN_Draw_Graph()
        ///     Calls the Calculation and Draw-Function
        /// 
        /// BTN_Draw_Grid()
        ///     Calls the Draw-Function
        /// 
        /// BTN_Call_Clear_Grid()
        ///     Calls the Clear-Funtion
        /// 
        /// </BTN_Functions>

        private void BTN_Coord_System(object sender, EventArgs e)
        {
            if (TB_X_Begin.Text.Length > 0)
                coordsystems.xmin = Convert.ToInt16(TB_X_Begin.Text);
            if(TB_X_End.Text.Length > 0)
                coordsystems.xmax = Convert.ToInt16(TB_X_End.Text);
            if (TB_Y_Begin.Text.Length > 0)
                coordsystems.ymin = Convert.ToInt16(TB_Y_Begin.Text);
            if (TB_Y_End.Text.Length > 0)
                coordsystems.ymax = Convert.ToInt16(TB_Y_End.Text);

            Draw_Coord_System();
        }

        private void BTN_DrawPoint_Click(object sender, EventArgs e)
        {
            if (TB_XPoint.Text.Length == 0)
                TB_XPoint.Text = "0";
            if (TB_YPoint.Text.Length == 0)
                TB_YPoint.Text = "0";

            graphics.DrawRectangle(pen, x_koord2pixel(Convert.ToInt16(TB_XPoint.Text)), y_koord2pixel(Convert.ToInt16(TB_YPoint.Text)), 2, 2);
        }

        private void BTN_Draw_Graph(object sender, EventArgs e)
        {
            if(TB_A_Value.Text.Length > 0)
                drawGraph.a = Convert.ToDouble(TB_A_Value.Text);
            if(TB_B_Value.Text.Length > 0)
                drawGraph.b = Convert.ToDouble(TB_B_Value.Text);
            if (TB_C_Value.Text.Length > 0)
                drawGraph.c = Convert.ToDouble(TB_C_Value.Text);

            fkt_value();

            printGraph();
        }

        private void BTN_Draw_Grid_Extened(object sender, EventArgs e)
        {
            if (TB_X_Grid.Text.Length > 0)
                coordsystems.x_grid = Convert.ToDouble(TB_X_Grid.Text);
            if (TB_Y_Grid.Text.Length > 0)
                coordsystems.y_grid = Convert.ToDouble(TB_Y_Grid.Text);

            Draw_Coord_System_Extended();

            Draw_Coord_Labels();
        }

        private void BTN_Call_Clear_Grid(object sender, EventArgs e)
        {
            resetCoordsystem();
        }

        /// <Coordsystem>
        /// 
        /// All Functions below are for the Coordsystem
        /// 
        /// resetCoordsystem()
        ///     Reset the hole UI
        ///    
        /// Draw_Coord_System()
        ///     Draw the Y and X-Axis to the UI
        /// 
        /// Draw_Coord_System_Extended()
        ///     Draw the Lines between the extreme values
        ///     
        /// Draw_Coord_Labels()
        ///     Draws the Labels to all Int Numbers
        ///
        /// printGraph()
        ///     Draws the graph in the Coordsystem
        ///     
        /// </Coordsystem>

        private void resetCoordsystem()
        {
            graphics.Clear(Color.White);
        }

        private void Draw_Coord_System()
        {
            graphics.DrawLine(pen, x_koord2pixel(0), y_koord2pixel(coordsystems.ymax), x_koord2pixel(0), y_koord2pixel(coordsystems.ymin));
            graphics.DrawLine(pen, x_koord2pixel(coordsystems.xmin), y_koord2pixel(0), x_koord2pixel(coordsystems.xmax), y_koord2pixel(0));
        }

        private void Draw_Coord_System_Extended()
        {
            double repeat = (Math.Abs(coordsystems.xmin) + Math.Abs(coordsystems.xmax)) / (coordsystems.x_grid);
            double x_coords = coordsystems.xmin;
            double y_coords = coordsystems.ymin;

            for (int i = 1; i < repeat; i++)
            {
                graphics.DrawLine(gutter_pen, x_koord2pixel(x_coords + coordsystems.x_grid), y_koord2pixel(coordsystems.ymax), x_koord2pixel(x_coords + coordsystems.x_grid), y_koord2pixel(coordsystems.ymin));
                x_coords += coordsystems.x_grid;
            }

            for (int i = 1; i < repeat; i++)
            {
                graphics.DrawLine(gutter_pen, x_koord2pixel(coordsystems.xmax), y_koord2pixel(y_coords + coordsystems.y_grid), x_koord2pixel(coordsystems.xmin), y_koord2pixel(y_coords + coordsystems.y_grid));
                y_coords += coordsystems.y_grid;
            }
        }

        private void Draw_Coord_Labels()
        {
            int repeat = Math.Abs(coordsystems.xmin) + Math.Abs(coordsystems.xmax);
            int x_coords = coordsystems.xmin +1, y_coords = coordsystems.ymin +1;

            for (int i = 1; i < repeat; i++)
            {
                graphics.DrawLine(pen, x_koord2pixel(x_coords), y_koord2pixel(-0.3), x_koord2pixel(x_coords), y_koord2pixel(0.3));
                x_coords += 1;
            }

            for (int i = 1; i < repeat; i++)
            {
                graphics.DrawLine(pen, x_koord2pixel(-0.3), y_koord2pixel(y_coords), x_koord2pixel(0.3), y_koord2pixel(y_coords));

                y_coords += 1;
            }
        }

        private void printGraph()
        {
            double x = (Math.Abs(coordsystems.xmax) + Math.Abs(coordsystems.xmin)) / 100;

            for (int i = 0; i < 99; i++)
            {
                graphics.DrawLine(pen, x_koord2pixel(coordsystems.xmin + x), y_koord2pixel(drawGraph.yValues[i]), x_koord2pixel(coordsystems.xmin + x + 0.1), y_koord2pixel(drawGraph.yValues[i + 1]));
                x += 0.1;
            }
        }

        /// <X & Y 2 pixel>
        /// 
        /// x_koord2pixel()
        ///     X Value to pixel-Value
        /// 
        /// y_koord2pixel()
        ///     Y Value to pixel-Value
        /// 
        /// fkt_value()
        ///     Current Y Value to X Value from a graph
        /// </summary>

        private int x_koord2pixel(double x)
        {
            return Convert.ToInt32((x - coordsystems.xmin) * (600 / (coordsystems.xmax - coordsystems.xmin)));
        }

        private int y_koord2pixel(double y)
        {
            return Convert.ToInt32(400 - (y - coordsystems.ymin) * (400 / (coordsystems.ymax - coordsystems.ymin)));
        }

        private void fkt_value()
        {
            double x = coordsystems.xmin;
            double y = Math.Abs(coordsystems.xmin) + Math.Abs(coordsystems.xmax);

            for (int i = 0; i < 100; i++)
            {
                drawGraph.yValues[i] = drawGraph.a * Math.Pow(x,2) + drawGraph.b * x + drawGraph.c;
                x += y / 100;
            }
        }
    }
}
