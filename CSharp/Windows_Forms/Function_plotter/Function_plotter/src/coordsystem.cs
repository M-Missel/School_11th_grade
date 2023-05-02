using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_plotter
{
    public sealed class coordsystem
    {
        public coordsystem(int xmin, int xmax, int ymin, int ymax)
        {
            this.xmin = xmin;
            this.xmax = xmax;
            this.ymin = ymin;
            this.ymax = ymax;
            this.x_grid = 0.5;
            this.y_grid = 0.5;
        }

        public int xmin { get; set; }
        public int xmax { get; set; }
        public int ymin { get; set; }
        public int ymax { get; set; }

        public double x_grid { get; set; }
        public double y_grid { get; set; }


    }
}
