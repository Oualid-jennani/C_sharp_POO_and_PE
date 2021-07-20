using System;
namespace Test
{
	public class Moto : Vehicule
	{
		public Moto() : base()
		{
			this.vitesseMax = 160;
		}

		public Moto(string marque, string model, string couleur, short km, short vitesse, short vitesseMax, float prixVignette, float longeur) : base(marque, model, couleur, km, vitesse, vitesseMax)
		{
			this.vitesseMax = 200;
			this.prixVignette = prixVignette;
			this.longeur = longeur;
		}

		public float prixVignette { get; set; }
		public float longeur { get; set; }

		public override string ToString()
		{
			return string.Format("[Moto: Marque: {0} - Modél: {1}, Couleur: {2}, km: {3}, vitesse: {4}, vitesseMax: {5}, Prix vignette={6}, Longueur: {7}]", this.marque, this.model, this.couleur, this.km, this.vitesse, this.vitesseMax, this.prixVignette, this.longeur);
		}
	}
}
