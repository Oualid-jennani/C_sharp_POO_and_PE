using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t= new int[10];
            int max;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("tapez le num fe l'ndice "+ (i+1));
                t[i] = int.Parse(Console.ReadLine());
             }
            max = t[0];
            for (int i = 0; i < 10; i++)
            {
                if (t[i] >= max)
                    max = t[i];
            }
            foreach(int n in t)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n\nle max est"+max);
            Console.ReadKey();
        }
    }
}
