using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__6
{
    public class Vehicules
    {
        public string marque { get; set; }
        public string modele { get; set; }
        public string color { get; set; }
        public int km { get; set; }
        public int vitesse { get; set; }
        public int vitesseMaximale { get; set; }
        public Vehicules()
        {
            this.marque = "";
            this.modele = "";
            this.color = "";
            this.km = 0;
            this.vitesse = 0;
            this.vitesseMaximale = 0;
        }
        public Vehicules(string marque , string modele ,string color,int km , int vitesse )
        {
            this.marque = marque;
            this.modele = modele;
            this.color = color;
            this.km = km;
            this.vitesse = vitesse;
            this.vitesseMaximale = vitesseMaximale;
        }
        
        public override string ToString()
        {
            return "marque : " + this.marque + "\nmodele : " + this.modele+"\ncolor : "+this.color+"\nkm : "+this.km+"\nvitesse : "+this.vitesse+"\nvitesse MX : "+this.vitesseMaximale;
        }

    }
}
