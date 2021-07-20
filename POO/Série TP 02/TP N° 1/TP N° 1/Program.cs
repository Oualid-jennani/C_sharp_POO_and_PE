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
            Console.WriteLine("tapez la taille du tableaux");
            int N=int.Parse(Console.ReadLine());
            int[] T= new int[N];
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("tapez la valeur lindce " + k );
                T[k]= int.Parse(Console.ReadLine());

            }

            Console.WriteLine("tapez lindce ");
            int i= int.Parse(Console.ReadLine());

            Console.WriteLine("taprz la valeur de lindice");
            int X = int.Parse(Console.ReadLine());
            Array.Resize(ref T, N+1);

            for (int k = T.Length-1; k > i; k--)
            {
                T[k] = T[k - 1];
            }
            T[i] = X;

            Console.WriteLine("le tableaux est \n\n");
            foreach(int n in T)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
           
        }
    }
}
