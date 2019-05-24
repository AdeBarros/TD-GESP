using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PubLinkLib;

namespace PubLinkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection listeLien = new Collection(); ;
            listeLien.Ajouter(new Lien("Hacker News", "https://news.ycombinator.com"));
            listeLien.Ajouter(new Lien("Reddit", "https://reddit.com"));
            listeLien.Ajouter(new Lien("Boing Boing", "boingboing.net"));

            string choix = "";
            while (choix != "0")
            {
                string choixPossibles = "";

                choixPossibles += "\n3 : Supprimer un lien";
                choixPossibles += "\n2 : Ajouter un lien";
                choixPossibles += "\n1 : Lister les liens";
                choixPossibles += "\n0 : Quitter";

                Console.WriteLine("Choisissez une action : " + choixPossibles);
                choix = Console.ReadLine();

                switch (choix)//Remplacer par if?
                {
                    case "1":
                        Console.WriteLine(listeLien.ToString());
                        break;

                    case "2":
                        Console.WriteLine("Nom du lien ?");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Url du lien ?");
                        string url = Console.ReadLine();
                        listeLien.Ajouter(new Lien(nom, url));
                        Console.WriteLine("Votre lien a bien été ajouté !");
                        break;

                    case "3":
                        Console.WriteLine(listeLien.ToString());
                        if (listeLien.Compte < 1)
                        {
                            Console.Write("Entrez l'indice du lien à supprimer : ");
                            int indice = int.Parse(Console.ReadLine()) - 1;
                            listeLien.Supprimer(indice);
                        }
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Au revoir !");

            Console.ReadKey();
        }
    }
}
