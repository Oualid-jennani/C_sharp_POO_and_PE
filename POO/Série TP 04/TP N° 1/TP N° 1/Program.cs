using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plan plan = new Plan();
            Point p1 = new Point(4, 5, plan);
            Point p2 = new Point(4, 8, plan);
            Point p3 = new Point(6, 8, plan);
            Point p4 = new Point(6, 4, plan);
            Point p5 = new Point(1, 2, plan);
            Point p6 = new Point(7, 2, plan);

            Segment s1 = new Segment(p1, p2, "Red");
            Segment s2 = new Segment(p3, p4, "Yellow");
            Segment s3 = new Segment(p5, p6, "Green");

            Console.Write("\n\n\n\n");
            plan.AddSegment(s1);
            plan.AddSegment(s2);
            plan.AddSegment(s3);
            //plan.RemoveSegment(s3);
            //plan.ClearPlan();
            plan.AffichPlan();

            Console.ReadKey();

        }
    }
}
