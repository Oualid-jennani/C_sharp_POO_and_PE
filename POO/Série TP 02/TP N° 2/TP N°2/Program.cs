using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tapez la taille du triangle");
            int N = int.Parse(Console.ReadLine());
            int[,] T = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    if (i == j || j == 0)
                    
                        T[i, j] = 1;
                    else
                        T[i, j] = T[i - 1, j] + T[i - 1, j - 1];
                    
                }
            }
            Console.Write("le triyangle est : \n");
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j <=i; j++)
                {               
                    Console.Write("\t" + T[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            //        int taille;

            //        Console.Write("Entrer la taille du triangle de Pascal:");

            //        taille = int.Parse(Console.ReadLine());

            //        printPascalTr(taille);

            //        Console.ReadLine();
            //    }

            //    public static void printPascalTr(int taille)
            //    {

            //        int[,] PascalTr = new int[taille, taille];

            //        int row, col;

            //        // Initialiser le tableau à 0

            //        for (row = 0; row < taille; row++)
            //        {
            //            for (col = 0; col < taille; col++) PascalTr[row, col] = 0;
            //        }

            //        PascalTr[0, 0] = 1;
            //        PascalTr[1, 0] = 1;
            //        PascalTr[1, 1] = 1;

            //        for (row = 2; row < taille; row++)
            //        {
            //            PascalTr[row, 0] = 1;

            //            for (col = 1; col <= row; col++)
            //            {
            //                PascalTr[row, col] = PascalTr[row - 1, col - 1] + PascalTr[row - 1, col];
            //            }
            //        }

            //        for (row = 0; row < taille; row++)
            //        {
            //            for (col = 0; col <= row; col++)
            //            {
            //                Console.Write("{0}\t", PascalTr[row, col]);
            //            }

            //            Console.WriteLine();
            //        }
            //    }
        }
    }
}
