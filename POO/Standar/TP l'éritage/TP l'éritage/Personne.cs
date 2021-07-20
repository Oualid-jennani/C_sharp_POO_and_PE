using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_l_éritage
{
    public class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string telephone { get; set; }
        public DateTime DateNaissance { get; set; }
        public Personne()
        {
            this.nom = "";
            this.nom = "";
            this.telephone = "";
            this.DateNaissance = new DateTime();
        }
        public void Affichier()
        {
            Console.WriteLine("Nom:"+this.nom);
            Console.WriteLine("Prenom"+this.prenom);
            Console.WriteLine("N° tel :"+this.telephone);
            Console.WriteLine("Date Naissance :"+this.DateNaissance);
        }
    }
}
