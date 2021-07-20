using System;
namespace Test
{
	public class Voiture : Vehicule
	{
		public Voiture() : base()
		{
			this.vitesseMax = 200;
		}

		public Voiture(string marque, string model, string couleur, short km, short vitesse, short vitesseMax, byte puissanceFiscal, byte nbPlaces) : base(marque, model, couleur, km, vitesse, vitesseMax)
		{
			this.vitesseMax = 200;
			this.puissanceFiscal = puissanceFiscal;
			this.nbPlaces = nbPlaces;
		}

		public byte puissanceFiscal { get; set; }
		public byte nbPlaces { get; set; }

		public override string ToString()
		{
			return string.Format("[Voiture: Marque: {0} - Modél: {1}, Couleur: {2}, km: {3}, vitesse: {4}, vitesseMax: {5}, nbPlaces={6}, Puissance Fiscal: {7}]", this.marque, this.model, this.couleur, this.km, this.vitesse, this.vitesseMax, this.nbPlaces, this.puissanceFiscal);
		}
	}
}
