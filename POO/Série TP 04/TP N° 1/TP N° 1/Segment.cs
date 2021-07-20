using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    public class Segment
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public string libelle { get; set; }
        public string coleur { get; set; }
        public Segment()
        {
            this.p1 = new Point();
            this.p2 = new Point();
            this.libelle = "";
            this.coleur = "";
        }
        public Segment(Point p1, Point p2, string color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.coleur = color;
        }
    }
}
