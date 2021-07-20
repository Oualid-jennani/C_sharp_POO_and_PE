using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Stagiaire s = new Stagiaire();
			bool error = false;

			do
			{
				error = false;
				Console.Write("Entrer le numéro du stagiaire: ");
				try
				{
					s.Numero = byte.Parse(Console.ReadLine());

					if ( ! (s.Numero >= 1 && s.Numero <= 30) )
					{
						throw new NumInvalidException();
					}
				}
				catch (NumInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			do
			{
				error = false;
				Console.Write("Entrer le nom du stagiaire: ");
				try
				{
					s.Nom = Console.ReadLine();
					char[] nomLetters = s.Nom.ToCharArray();

					foreach (char letter in nomLetters)
					{
						if ( ! ( (letter >= 65 && letter <= 91) || (letter >= 97 && letter <= 123) ) )
						{
							throw new NomOrPrenomInvalidException();
						}
					}
				}
				catch (NomOrPrenomInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			do
			{
				error = false;
				Console.Write("Entrer le prénom du stagiaire: ");

				try
				{
					s.Prenom = Console.ReadLine();
					char[] prenomLetters = s.Prenom.ToCharArray();

					foreach (char letter in prenomLetters)
					{
						if (!((letter >= 65 && letter <= 91) || (letter >= 97 && letter <= 123)))
						{
							throw new NomOrPrenomInvalidException();
						}
					}
				}
				catch (NomOrPrenomInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			do
			{
				error = false;
				Console.Write("Entrer la filière du stagiaire: ");

				try
				{
					s.Filiere = Console.ReadLine();
					s.Filiere = s.Filiere.ToUpper();

					if ( s.Filiere != "TDI" && s.Filiere != "TRI" && s.Filiere != "TDM" )
					{
						throw new FiliereInvalidException();
					}
				}
				catch (FiliereInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			do
			{
				error = false;
				Console.Write("Entrer le groupe du stagiaire: ");

				try
				{
					s.Groupe = short.Parse(Console.ReadLine());

					if (! (s.Groupe >= 101 && s.Groupe <= 399))
					{
						throw new GroupeInvalidException();
					}
				}
				catch (GroupeInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			do
			{
				error = false;
				Console.Write("Entrer la date de naissance du stagiaire (Format dd/mm/yyyy): ");

				try
				{
					s.dateNaissance = Console.ReadLine();
					string[] dateParts = s.dateNaissance.Split('/');

					if (!((int.Parse(dateParts[0]) >= 1 && int.Parse(dateParts[0]) <= 31) && (int.Parse(dateParts[1]) >= 1 && int.Parse(dateParts[1]) <= 12) && (int.Parse(dateParts[2]) >= DateTime.Now.Year - 28 && int.Parse(dateParts[2]) <= DateTime.Now.Year - 17)))
					{
						throw new DateInvalidException();
					}
				}
				catch (DateInvalidException e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
				catch (Exception e)
				{
					error = true;
					Console.WriteLine(e.Message);
				}
			} while (error);

			Console.ReadLine();
		}
	}
}