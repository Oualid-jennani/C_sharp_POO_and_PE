using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N__1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("joueur 1 entrer votre nom ");
            string Nom1 = Console.ReadLine();
            Console.WriteLine("joueur 2 entrer votre nom ");
            string Nom2 = Console.ReadLine();
            Attaquant Hercule = new Attaquant(10, Nom1);
            Attaquant Fabios = new Attaquant(10, Nom2);
            Console.Clear();
            Console.WriteLine("vie de : " + Nom1 + "est:"+Hercule.vie+" \t \t \t \t  vie de : " + Nom2+"est:"+Fabios.vie+"\n");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Fabios.Affvie(); Console.Write("\t\t\t\t\t\t\t"); Hercule.Affvie();
                Console.ResetColor();
                Console.Write("\nNommez l'attaquant :");
                string pers=Console.ReadLine();
                if (pers == Nom1)
                {
                    Console.WriteLine("choi de ataque entrer A pour ataque special entrer AS ");
                    string att = Console.ReadLine();
                    if (att == "AS")
                    {
                        Hercule.AttaqueSpeciale(Fabios);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Fabios.Affvie();Console.Write("\t\t\t\t\t\t\t");Hercule.Affvie();
                        Console.ResetColor();

                        Console.WriteLine("\n");
                        Console.Clear();
                    }
                    if (att == "A")
                    {
                        Hercule.Attaque(Fabios);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Fabios.Affvie(); Console.Write("\t\t\t\t\t\t\t"); Hercule.Affvie();
                        Console.ResetColor();

                        Console.WriteLine("\n");
                        Console.Clear();
                    }
                }
                else if (pers == Nom2)
                {
                    Console.WriteLine("choi de ataque entrer A pour ataque special entrer AS ");
                    string att = Console.ReadLine();
                    if (att == "AS")
                    {
                        Fabios.AttaqueSpeciale(Hercule);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Fabios.Affvie(); Console.Write("\t\t\t\t\t\t\t"); Hercule.Affvie();
                        Console.ResetColor();

                        Console.WriteLine("\n");
                        Console.Clear();
                    }
                    if (att == "A")
                    {

                        Fabios.Attaque(Hercule);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Fabios.Affvie(); Console.Write("\t\t\t\t\t\t\t"); Hercule.Affvie();
                        Console.ResetColor();

                        Console.WriteLine("\n");
                        Console.Clear();
                    }
                }
                else Console.WriteLine("Il n'y a pas d'attaquant de ce nom");
            } while (Fabios.vie > 0 && Hercule.vie > 0);

            Console.WriteLine("\n\n\n\n");
            if (Hercule.vie == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t game over : "+Nom1);
            }
            if (Fabios.vie == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t game over : "+Nom2);
            }
            Console.ReadKey();

        }
    }
}

