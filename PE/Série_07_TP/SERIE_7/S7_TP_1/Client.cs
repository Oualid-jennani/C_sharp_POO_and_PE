using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace S7_TP_1
{
    [Serializable]
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Client()
        {
            this.Nom = String.Empty;
            this.Prenom = String.Empty;
            this.DateNaissance = new DateTime();
            this.Adresse = String.Empty;
            this.Email = String.Empty;
            this.Telephone = String.Empty;
        }
    }
}
