using System;
namespace ConsoleApplication1
{
	public class NumInvalidException : Exception
	{
		public NumInvalidException() : base("Le numéro du stagiaire doit être compris entre 1 et 30 !") {}
	}

	public class NomOrPrenomInvalidException : Exception
	{
		public NomOrPrenomInvalidException() : base("Le nom et prénom du stagiaire ne doivent contenir que des lettres !") {}
	}

	public class FiliereInvalidException : Exception
	{
		public FiliereInvalidException() : base("La filière est invalide, les filières accéptées sont: TDI, TRI et TDM") {}
	}

	public class GroupeInvalidException : Exception
	{
		public GroupeInvalidException() : base("Le groupe est invalid, le groupe doit avoir 3 chiffres et doit commencer par 1, 2 ou 3") {}
	}

	public class DateInvalidException : Exception
	{
		public DateInvalidException() : base("La date entrée est invalide !") {}
	}
}
