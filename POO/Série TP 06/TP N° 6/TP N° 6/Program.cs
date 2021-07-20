using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicules> list = new List<Vehicules> ();
            Voitures voit1 = new Voitures("dasia", "logan", "red", 30000, 160, 200, 5);
            list.Add(voit1);
            Voitures voit2 = new Voitures("ur4", "fakrona", "bleu", 20000, 100, 120, 4);
            list.Add(voit2);
            Voitures voit3 = new Voitures("mo9atila", "504", "black", 40000, 250, 200,20);
            list.Add(voit3);
            Motos moto1 = new Motos("c100", "becan", "black", 2000, 90, 800, 2);
            list.Add(moto1);
            Camions cam1 = new Camions("volvo", "isusi", "green", 4000, 140, 500, 3);
            list.Add(cam1);
            foreach (Vehicules N in list)
            {
                    Console.WriteLine(N.marque+"  "+N.modele);
            }
            Console.WriteLine("\n\n");
            foreach (Vehicules N in list)
            {
                if(N.color=="red")
                Console.WriteLine(N.ToString());
            }
            foreach (Vehicules N in list)
            {
                if (N.marque == "volvo" && N.modele=="isusi")
                    Console.WriteLine(N.ToString());
            }
            Console.ReadKey();

        }
    }
}
