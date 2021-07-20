using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
  public class Plan
    {
        public string[,] grille = new string[10, 10];
        public Plan()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grille[i, j] = ".";
                }
            }
        }
        public void AddSegment(Segment s)
        {
            if (s.p1.Y == s.p2.Y)
            {
                if (s.p1.X < s.p2.X)
                {
                    for (int j = s.p1.X; j < s.p2.X; j++)
                    {
                        grille[9 - s.p1.Y, j] = s.coleur + "horizontaux";
                    }
                    grille[9 - s.p2.Y, s.p2.X] = "-";
                }
                if (s.p2.X < s.p1.X)
                {
                    for (int j = s.p2.X; j < s.p1.X; j++)
                    {
                        grille[9 - s.p1.Y, j] = s.coleur + "horizontaux";
                    }
                    grille[9 - s.p1.Y, s.p1.X] = "-";

                }
            }
            if (s.p1.X == s.p2.X)
            {
                if (s.p1.Y < s.p2.Y)
                {
                    for (int i = 9 - s.p1.Y; i >= 9 - s.p2.Y; i--)
                    {
                        grille[i, s.p1.X] = s.coleur + "verticaux";
                    }

                }
                if (s.p2.Y < s.p1.Y)
                {
                    for (int i = 9 - s.p2.Y; i >= 9 - s.p1.Y; i--)
                    {
                        grille[i, s.p1.X] = s.coleur + "verticaux";
                    }
                }
            }
        }
        public void RemoveSegment(Segment s)
        {
            if (s.p1.Y == s.p2.Y)
            {
                if (s.p1.X < s.p2.X)
                {
                    for (int j = s.p1.X; j <= s.p2.X; j++)
                    {
                        grille[9 - s.p1.Y, j] = ".";
                    }
                }
                if (s.p2.X < s.p1.X)
                {
                    for (int j = s.p2.X; j <= s.p1.X; j++)
                    {
                        grille[9 - s.p1.Y, j] = ".";
                    }
                }
            }
            if (s.p1.X == s.p2.X)
            {
                if (s.p1.Y < s.p2.Y)
                {
                    for (int i = 9 - s.p1.Y; i >= 9 - s.p2.Y; i--)
                    {
                        grille[i, s.p1.X] = ".";
                    }

                }
                if (s.p2.Y < s.p1.Y)
                {
                    for (int i = 9 - s.p2.Y; i >= 9 - s.p1.Y; i--)
                    {
                        grille[i, s.p1.X] = ".";
                    }

                }
            }
        }
        public void AffichPlan()
        {
            Type type = typeof(ConsoleColor);

            for (int i = 0; i < 10; i++)
            {
                Console.ResetColor();
                Console.Write("     [" + (9 - i) + "]   ");
                for (int j = 0; j < 10; j++)
                {
                    if (grille[i, j] != "*" && grille[i, j] != "." && grille[i, j] != "-")
                    {

                        int posV = grille[i, j].IndexOf("verticaux");
                        int posH = grille[i, j].IndexOf("horizontaux");

                        if (posV > 0)
                        {
                            string chars = grille[i, j].Substring(0, posV);
                            Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, chars);
                            grille[i, j] = "|    ";
                        }
                        if (posH > 0)
                        {
                            string chars = grille[i, j].Substring(0, posH);
                            Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, chars);
                            grille[i, j] = "-----";
                        }
                        Console.Write(grille[i, j]);
                    }
                    else if (grille[i, j] == "-") Console.Write(grille[i, j] + "    ");
                    else
                    {
                        Console.ResetColor();
                        Console.Write(grille[i, j] + "    ");
                    }
                }
                Console.Write("\n\n");
            }
            Console.Write("          ");
            for (int i = 0; i < 10; i++)
                Console.Write("[{0}]  ", i);
        }
        public void ClearPlan()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grille[i, j] = ".";
                }
            }
        }
    }
}
