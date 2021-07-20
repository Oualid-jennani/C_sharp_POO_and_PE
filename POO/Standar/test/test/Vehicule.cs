using System;
namespace Test
{
	public class Vehicule
	{
		public Vehicule()
		{
			this.marque = "";
			this.model = "";
			this.couleur = "";
			this.km = 0;
			this.vitesse = 0;
			this.vitesseMax = 0;
		}

		public Vehicule(string marque, string model, string couleur, short km, short vitesse, short vitesseMax)
		{
			this.marque = marque;
			this.model = model;
			this.couleur = couleur;
			this.km = km;
			this.vitesse = vitesse;
			this.vitesseMax = vitesseMax;
		}

		public string marque { get; set; }
		public string model { get; set; }
		public string couleur { get; set; }
		public short km { get; set; }
		public short vitesse { get; set; }
		public short vitesseMax { get; set; }

		public void rouler( short vitesse, short distance ) 
		{
			this.vitesse = vitesse;
			this.km += distance;
		}

		public override string ToString()
		{
			return string.Format("[Vehicule: marque={0}]", marque);
		}
	}
}
