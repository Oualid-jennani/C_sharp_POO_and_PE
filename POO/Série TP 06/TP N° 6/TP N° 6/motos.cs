using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__6
{
    public class Motos: Vehicules
    {
        public int prixvignette { get; set; }
        public int longueur { get; set; }
        public Motos()
        {
            this.prixvignette = 0;
            this.longueur = 0;
        }
        public Motos(string marque, string modele, string color, int km, int vitesse,int prixvignette,int longueur) : base(marque, modele, color, km, vitesse)
        {
            this.vitesseMaximale = 160;
            this.prixvignette = prixvignette;
            this.longueur = longueur;
        }
        public override string ToString()
        {
            return base.ToString() + "\nprixvignettel : " + this.prixvignette + "\nlongueur : " + this.longueur
              + "\n-----------------------------------------------------------\n"; ;
        }
    }
}
