using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__3
{
    class Stagiaire
    {
        public Byte numero { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String filiere { get; set; }
        public int groupe { get; set; }
        public DateTime dateNaissance { get; set; }
        public Stagiaire()
        {
            this.numero = 0;
            this.nom = "";
            this.prenom = "";
            this.filiere = "";
            this.groupe = 0;
            this.dateNaissance = new DateTime();
        }
    }

}
