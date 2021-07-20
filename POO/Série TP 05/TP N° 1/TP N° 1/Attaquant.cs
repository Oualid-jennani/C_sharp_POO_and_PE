using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    class Attaquant
    {
        public int vie { get; set; }
        public string nom { get; set; }
        public Attaquant()
        {
            vie = 0;
            nom = "";
        }

        public Attaquant(int vie, string nom)
        {
            this.k = 100;
            this.vie = vie;
            this.nom = nom;
        }
        public int Attaque(Attaquant a)
        {
            a.vie--;
            return a.vie;
        }
        public int AttaqueSpeciale(Attaquant a)
        {
            a.vie = a.vie - 5;
            if (a.vie < 0)
                a.vie = 0;
            return a.vie;
        }
        public void Affvie()
        {
            Console.Write(nom+" : ");
            if(vie==0) Console.Write("0");
            else
            for (int i = 0; i < vie; i++)
            {
                Console.Write("|");

            }
        }
    }
}
