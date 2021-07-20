using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__6
{
    public class Voitures : Vehicules
    {
        public int puissanceFiscal{ get; set; }
        public int NombreDePlaces { get; set; }

        public Voitures()
        {
            this.puissanceFiscal = 0;
            this.NombreDePlaces = 0;
        }
        public Voitures(string marque, string modele, string color, int km, int vitesse, int puissanceFiscal, int NombreDePlaces) : base( marque, modele,color,km,vitesse)
        {
            this.vitesseMaximale = 200;
            this.puissanceFiscal = puissanceFiscal;
            this.NombreDePlaces = NombreDePlaces;
        }
        public override string ToString()
        {
            return base.ToString() + "\npuissance fisical : " + this.puissanceFiscal + "\nnombre de places : " + this.NombreDePlaces
              + "\n-----------------------------------------------------------\n";
        }
    }
}
