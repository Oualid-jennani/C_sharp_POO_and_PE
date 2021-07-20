using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__6
{
    public class Camions:Vehicules
    {
        public int chargemaximal { get; set; }
        public int hauteur { get; set; }
        public Camions()
        {
            this.chargemaximal = 0;
            this.hauteur = 0;
        }
        public Camions(string marque, string modele, string color, int km, int vitesse,int chargemaximal, int hauteur) : base(marque, modele, color, km, vitesse)
        {
            this.vitesseMaximale = 140;
            this.chargemaximal = chargemaximal;
            this.hauteur = hauteur;
        }
        public override string ToString()
        {
            return base.ToString() + "\nchargemaximal : " + this.chargemaximal + "\nhauteur : " + this.hauteur
              + "\n-----------------------------------------------------------\n"; ;
        }
    }
}
