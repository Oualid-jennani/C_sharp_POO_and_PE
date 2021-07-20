using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static float[] tableau = new float[] { 17, 12, 15, 38, 29, 157, 89, -22, 0, 5 };
        static int z,k,j=0;
        static float division(int indice, int diviseur)
        {
            return tableau[indice] / diviseur;
        }
        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    int x, y;
                    Console.WriteLine("Entrez l’indice de l’entier à diviser: ");
                    x = int.Parse(Console.ReadLine());
                    k = x;
                    Console.WriteLine("Entrez le diviseur: ");
                    y = int.Parse(Console.ReadLine());
                    z = y;
                    if (y == 0)
                        Console.WriteLine("Le résultat de la division est: imposible ");
                    else
                    {
                        Console.WriteLine("Le résultat de la division est: ");
                        Console.WriteLine(division(x, y));
                    }

                }
                catch(ArgumentOutOfRangeException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception y)
                {
                    Console.WriteLine(y.Message);
                }
                finally
                {
                    Console.WriteLine("executed");
                }
                for(int i = 0; i < tableau.Length; i++)
                {
                    if (k == i)
                        j++;
                }

                if (z == 0)
                    Console.WriteLine("tapez nume diferon 0");
                if (j == 0)
                    Console.WriteLine("tappez outre l'andice treouvez dans le tableux");

            } while (z == 0||j==0);
            Console.ReadKey();

        }
    }
}