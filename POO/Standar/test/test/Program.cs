using System;
using System.Collections.Generic;

namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<Vehicule> vList = new List<Vehicule>();

			Voiture v1 = new Voiture( "Ford", "Fiesta", "Noir", 17, 60, 220, 7, 5 );
			Voiture v2 = new Voiture( "Renault", "Clio", "Gris", 15000, 60, 220, 6, 5);

			Moto m1 = new Moto( "Yamaha", "Yazaki", "Rouge", 150, 120, 240, 750, 2 );
			Moto m2 = new Moto( "Harly Davidson", "H15", "Vert pistache", 3000, 100, 250, 750, 2);

			Camion c1 = new Camion( "Mercedes", "Transit", "Bleu", 1609, 80, 180, 3, 2 );
			Camion c2 = new Camion( "Renault", "Scania", "Noir", 1609, 70, 200, 3, 2);

			vList.Add(v1);
			vList.Add(v2);
			vList.Add(m1);
			vList.Add(m2);
			vList.Add(c1);
			vList.Add(c2);

			v1.rouler(100, 1400);
			v2.rouler(120, 900);
			m1.rouler(80, 4600);
			m2.rouler(95, 200);
			c1.rouler(160, 1700);
			c2.rouler(130, 1900);

			Console.WriteLine("Affichage de toutes les véhicules: ");
			afficherListeVehicules(vList);

			Console.WriteLine("Affichage de toutes les véhicules de couleur Noir: ");
			afficherListeVehicules(vList, "Noir");

			Console.WriteLine("Affichage de toutes les véhicules de la marque Renault: ");
			afficherListeVehicules(vList, "", "Renault");

			Console.ReadLine();
		}

		public static void afficherListeVehicules(List<Vehicule> vList, string couleur = "", string marque = "", string model = "")
		{
			foreach (Vehicule v in vList)
			{
				bool include = true;

				if ( couleur != "" && v.couleur != couleur )
				{
					include = false;
				}

				if (marque != "" && v.marque != marque)
				{
					include = false;
				}

				if (model != "" && v.model != model)
				{
					include = false;
				}

				if ( include )
				{
					v.ToString();
				}
			}
		}
	}
}