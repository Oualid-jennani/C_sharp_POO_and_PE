using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    class Stagiaire
    {
        public Byte numero { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String filiere { get; set; }
        public Byte groupe { get; set; }
        public float[] notes { get; set; }


        public float CalculMoy()
        {
            float somme = 0;
            for (int i = 0; i < this.notes.Length; i++)
            {
                somme += this.notes[i];
            }
            return somme / (this.notes.Length);
        }
        public Stagiaire()
        {
            this.numero = 0;
            this.nom = "";
            this.prenom = "";
            this.filiere = "";
            this.groupe = 0;
            this.notes = new float[5];
        }
    }
    class Program

    {

        static void Main(string[] args)
        {
            Console.Write("Entrer le nombre du stagiaire :");
            int n = int.Parse(Console.ReadLine());
            Stagiaire[] stg = new Stagiaire[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                stg[i] = new Stagiaire();
                Console.WriteLine("entrer le numero du stagiaire " + (i + 1));
                stg[i].numero = Byte.Parse(Console.ReadLine());
                Console.WriteLine("entrer le nom du stagiaire " + (i + 1));
                stg[i].nom = (Console.ReadLine());
                Console.WriteLine("entrer le prenom du stagiaire " + (i + 1));
                stg[i].prenom = (Console.ReadLine());
                Console.WriteLine("entrer le filiere du stagiaire " + (i + 1));
                stg[i].filiere = (Console.ReadLine());
                Console.WriteLine("entrer le groupe du stagiaire " + (i + 1));
                stg[i].groupe = Byte.Parse(Console.ReadLine());
                for (int j = 0; j < 5; j++)
                {
                    stg[i].notes[j] = rnd.Next(0, 20);
                }
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("------------------Stagiaire" + (i + 1) + "------------------");
                Console.WriteLine("Numero : " + stg[i].numero);
                Console.WriteLine("Nom:" + stg[i].nom);
                Console.WriteLine("Prenom" + stg[i].prenom);
                Console.WriteLine("Filiere" + stg[i].filiere);
                Console.WriteLine("Groupe" + stg[i].groupe);
                Console.WriteLine("Moyenne" + stg[i].CalculMoy());
            }
            Console.ReadKey();
        }
    }
}
