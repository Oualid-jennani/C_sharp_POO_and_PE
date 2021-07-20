using System;
namespace Test
{
	public class Camion : Vehicule
	{
		public Camion() : base()
		{
			this.vitesseMax = 140;
		}

		public Camion(string marque, string model, string couleur, short km, short vitesse, short vitesseMax, float chargeMax, float hauteur) : base(marque, model, couleur, km, vitesse, vitesseMax)
		{
			this.vitesseMax = 200;
			this.chargeMax = chargeMax;
			this.hauteur = hauteur;
		}

		public float chargeMax { get; set; }
		public float hauteur { get; set; }

		public override string ToString()
		{
			return string.Format("[Camion: Marque: {0} - Modél: {1}, Couleur: {2}, km: {3}, vitesse: {4}, vitesseMax: {5}, Charge max={6}, Hauteur: {7}]", this.marque, this.model, this.couleur, this.km, this.vitesse, this.vitesseMax, this.chargeMax, this.hauteur);
		}
	}
}
