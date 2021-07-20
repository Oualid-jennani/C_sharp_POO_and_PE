using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("avent");
                string chaine = "dix";
                int valeur = Convert.ToInt32(chaine);
                Console.WriteLine("apres crach");
            }
            catch (Exception)
            {
                Console.WriteLine("Ereur");
            }
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
