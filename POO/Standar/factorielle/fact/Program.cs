using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriele
{
    class Program
    {

        static void Main(string[] args)
        {
            int n,f;
            Console.WriteLine("entre un nomber");
            n = int.Parse(Console.ReadLine());
            f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;

            }
            Console.WriteLine("la fact est :" + f);
            Console.Read();
        }
    }
}
