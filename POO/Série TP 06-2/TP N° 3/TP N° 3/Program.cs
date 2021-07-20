using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__3
{
    public class NumeroException : Exception
    {
        public NumeroException() : base("Ereur !!!! Ce chiffre n'est pas limité entre 1 et 30 Corrigez l'erreur s'il vous plaît")
        {
        }
    }
    public class FiliereException : Exception
    {
        public FiliereException() : base("Ereur !!!! Cette filiere pas trouve")
        {
        }
    }
    public class GroupeException : Exception
    {
        public GroupeException(string message) : base(message)
        {

        }
    }
    public class DateException : Exception
    {
        public DateException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Stagiaire stg = new Stagiaire();
            int Ereur;
            do
            {
                Ereur = 0;
                try
                {
                    Console.WriteLine("entrer le numero du stagiaire: ");
                    stg.numero = Byte.Parse(Console.ReadLine());
                    if (stg.numero < 1 || stg.numero > 30)
                        throw new NumeroException();
                }
                catch (NumeroException M)
                {
                    Console.WriteLine(M.Message);
                    Ereur++;
                }
            } while (Ereur > 0);

            Console.WriteLine("entrer le nom du stagiaire: ");
            stg.nom = (Console.ReadLine());
            Console.WriteLine("entrer le prenom du stagiaire:");
            stg.prenom = (Console.ReadLine());
            do
            {
                try
                {
                    Ereur = 0;
                    Console.WriteLine("entrer le filiere du stagiaire: ");
                    stg.filiere = (Console.ReadLine());
                    if (stg.filiere != "TDI" && stg.filiere != "TRI" && stg.filiere != "TDM")
                        throw new FiliereException();
                }
                catch (FiliereException M)
                {
                    Console.WriteLine(M.Message);
                    Ereur++;
                }

            } while (Ereur > 0);
            do
            {
                try
                {
                    Ereur = 0;
                    Console.WriteLine("entrer le groupe du stagiaire: ");
                    stg.groupe = int.Parse(Console.ReadLine());
                    if (stg.groupe < 100 || stg.groupe > 399)
                        throw new GroupeException("Il n'y a pas de groupe avec ce numéro");
                }

                catch (GroupeException M)
                {
                    Console.WriteLine(M.Message);
                    Ereur++;
                }

            } while (Ereur > 0);

            do
            {
                Ereur = 0;
                try
                {
                    int AN, JR, Mois;
                    Console.WriteLine("entrer la Date de Naissance:");

                    Console.Write("Anne==>");
                    AN = int.Parse(Console.ReadLine());
                    if (AN < 1 || AN > 9999)
                        throw new DateException("L'anne ne peut pas être représenté\n");

                    Console.Write("mois==>");
                    Mois = int.Parse(Console.ReadLine());
                    if (Mois < 1 || Mois > 12)
                        throw new DateException("le MOIS ne peut pas être représenté\n");

                    Console.Write("jour==>");
                    JR = int.Parse(Console.ReadLine());
                    if (JR < 1 || JR > 31)
                        throw new DateException("le Jour ne peut pas être représenté\n");

                    stg.dateNaissance = new DateTime(AN, Mois, JR);

                }
                catch (DateException M)
                {
                    Console.Write(M.Message);
                    Ereur++;
                }
            } while (Ereur > 0);

            Console.Clear();

            Console.WriteLine("------------------Stagiaire----------------");
            Console.WriteLine("Numero : " + stg.numero);
            Console.WriteLine("Nom:" + stg.nom);
            Console.WriteLine("Prenom:" + stg.prenom);
            Console.WriteLine("Filiere:" + stg.filiere);
            Console.WriteLine("Groupe:" + stg.groupe);
            Console.WriteLine("Date de N est : " + stg.dateNaissance.ToString("dd / MMMM / yyyy") + ".");

            Console.ReadKey();
        }
    }
}
