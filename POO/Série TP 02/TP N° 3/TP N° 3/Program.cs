using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__3
{
    class Program
    {
        struct stagaire
        {
            public string nom;
            public string prenom;
        }
        static  List<stagaire> list = new List<stagaire>();
        static void Ajouter()
        {
            stagaire person = new stagaire();
            Console.Write("tapez le nom du stagaire: ");
            person.nom = Console.ReadLine();
            Console.Write("tapez le prenom du stagaire: ");
            person.prenom = Console.ReadLine();
            int comp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].nom.ToLower() == person.nom.ToLower() && list[i].prenom.ToLower() == person.prenom.ToLower())
                    comp++;
            }
            if (comp >0) Console.WriteLine("le stagaire existe dèjà!!!");
            else list.Add(person);
        }
        static void Supprimer_stagiaire()
        {
            stagaire person = new stagaire();
            Console.WriteLine("Entrer le nom et prenom du stagaire à supprimer:");
            Console.Write("tapez le nom:");
            person.nom = Console.ReadLine();
            Console.Write("tapez le prenom:");
            person.prenom = Console.ReadLine();
            int comp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].nom.ToLower() == person.nom.ToLower() && list[i].nom.ToLower() == person.prenom.ToLower())
                {
                    list.Remove(list[i]);
                    comp++;
                }
            }        
            if (comp == 0) Console.WriteLine("le nom pas trouve dans la liste du stagaire!!!");
        }
        static void Modifier_stagiaire()
        {
            stagaire person = new stagaire();
            Console.WriteLine("Entrer le nom et prenom du stagaire à modifier");
            Console.Write("tapez le nom:");
            person.nom = Console.ReadLine();
            Console.Write("tapez le prenom:");
            person.prenom = Console.ReadLine();
            int comp = 0, choix;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].nom.ToLower() == person.nom.ToLower() && list[i].prenom.ToLower() == person.prenom.ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n");
                    Console.WriteLine("\t\t\t*******Options*******");
                    Console.WriteLine("\t\t\t1-Modifier le nom:   ");
                    Console.WriteLine("\t\t\t2-Modifier le prenom:");
                    Console.WriteLine("\t\t\t3-Modifier le N et P:");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.Clear();
                        Console.Write("Donner le nouveau nom: ");
                        person.nom = Console.ReadLine();
                        Console.WriteLine("\t\t\t\tla modification est terminer");
                    }
                    else if (choix == 2)
                    {
                        Console.Clear();
                        Console.Write("Donner le nouveau prenom: ");
                        person.prenom = Console.ReadLine();
                        Console.WriteLine("\t\t\t\tla modification est terminer");
                    }
                    else if (choix == 3)
                    {
                        Console.Clear();
                        Console.Write("Donner le nouveau nom: ");
                        person.nom = Console.ReadLine();
                        Console.Write("Donner le nouveau prenom: ");
                        person.prenom = Console.ReadLine();
                        Console.WriteLine("\t\t\t\tla modification est terminer");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Choix invalide");
                    }
                    list[i] = person;
                    comp++;
                }
            }
            if (comp == 0) Console.WriteLine("le nom pas trouve dans la liste du stagaire!!!");
        }
        public static void RechercherStagiaire(string stagiaire)
        {
            if (stagiaire.Contains(stagiaire))
            {
                Console.WriteLine("Ce stagiaire existe dans la liste.");
            }
            else
            {
                Console.WriteLine("Ce stagiaire n'existe pas dans la liste.");
            }
        }
        static void Afficher_liste()
        {
            Console.Write("la liste des stagiaires est :\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (stagaire P in list)
            {
                Console.WriteLine("- {0} {1}",P.nom,P.prenom);
            }
        }


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            
            int choix;
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n                Menu                      ");
                Console.WriteLine("        1-Ajouter un stagaire               ");
                Console.WriteLine("        2-Supprimer un stagaire             ");
                Console.WriteLine("        3-Modifier un stagaire              ");
                Console.WriteLine("        4-Rechercher un stagaire            ");
                Console.WriteLine("        5-Afficher tous les nom du stagaires");
                Console.WriteLine("              6-Quitter                     ");

                Console.Write("\n\n\n\t\t\tDonner votre choix: ");

                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1: Console.Clear(); Ajouter(); Console.Clear(); break;
                    case 2: Console.Clear(); Supprimer_stagiaire(); break;
                    case 3: Console.Clear(); Console.Clear(); Modifier_stagiaire(); break;
                    case 4: Console.Clear(); RechercherStagiaire(Console.ReadLine()); break;
                    case 5: Console.Clear(); Afficher_liste();break;
                    case 6: Console.Clear(); Console.WriteLine("Fin du programme");break;
                    default: Console.Clear(); Console.WriteLine("Default case");break;
                }
            } while (choix != 6);
            Console.ReadKey();
        }
    }
}
