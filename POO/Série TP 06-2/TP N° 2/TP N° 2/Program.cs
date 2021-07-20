using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__2
{
    public class NoSuchElementException : Exception
    {
        public NoSuchElementException():base("Au revoir ! ")
        {

        }
    }
    class Program
    {
        static int Recherch(int[] tab,int x)
        {
            int Index=-1;
            for (int i=0;i<tab.Length;i++)
            {
                if (x == tab[i])
                {
                   Index = i;
                    break;
                }
            }
            return Index;
        }
        static int[] tableau = new int[] { 17, 12, 15, 38, 29, 12, 89, -22, 0, 5 };
        static void Main(string[] args)
        {
            try
            {
                int CHERCH;
                Console.WriteLine("Tapez le numéro que vous recherchez: ");
                int x = int.Parse(Console.ReadLine());
                CHERCH = Recherch(tableau, x);
                if (CHERCH != -1)
                {
                    Console.WriteLine("la valeur il existe dans la case N°" + CHERCH);
                }
                else throw new NoSuchElementException();
            }
            catch(NoSuchElementException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
