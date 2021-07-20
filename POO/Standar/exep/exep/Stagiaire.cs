using System;

namespace ConsoleApplication1
{
	public class Stagiaire
	{
		// Constructeur par défaut
		public Stagiaire()
		{
			this.Numero = 0;
			this.Nom = "";
			this.Prenom = "";
			this.Filiere = "";
			this.Groupe = 0;
			this.dateNaissance = "";
			this.Notes = new float[5];
		}

		// Constructeur avec paramètres
		public Stagiaire(byte num, string nom, string prenom, string filiere, short groupe, string dateNaissance)
		{
			this.Numero = num;
			this.Nom = nom;
			this.Prenom = prenom;
			this.Filiere = filiere;
			this.Groupe = groupe;
			this.dateNaissance = dateNaissance;
			this.Notes = new float[5];
		}

		// Les getters et les setters (auto propriétés)
		public byte Numero { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Filiere { get; set; }
		public short Groupe { get; set; }
		public string dateNaissance { get; set; }
		public float[] Notes { get; set; }

		public float CalculMoy()
		{
			float moy = 0;

			foreach ( float note in this.Notes )
			{
				moy += note;
			}

			return moy / this.Notes.Length;
		}

		public override string ToString()
		{
			return string.Format("[Stagiaire N° {0}, Nom={1}, Prenom={2}, Filière={3}, Moyenne={4}]", this.Numero, this.Nom, this.Prenom, this.Filiere, this.CalculMoy());
		}
	}
}
