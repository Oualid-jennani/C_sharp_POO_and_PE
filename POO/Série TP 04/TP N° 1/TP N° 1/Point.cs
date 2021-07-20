using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    public class Point
    {

        public short X { get; set; }
        public short Y { get; set; }
        public Point()
        {
            this.Y = 0;
            this.X = 0;
        }
        public Point(short x, short y, Plan p)
        {
            this.Y = y;
            this.X = x;
            p.grille[9 - Y, X] = "*";
        }
    }
}
