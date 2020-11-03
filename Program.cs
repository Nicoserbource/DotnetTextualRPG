using System;
using System.Collections;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenue, aventurier ! Quel est ton nom ?");
            String nomJoueur = Console.ReadLine();
            Heros joueur = new Heros(nomJoueur, 5, 5, 1, 0, 1, 1, 0, 0);
            joueur.afficherStats();
            Console.WriteLine($"\nBienvenue, {nomJoueur} ! Vous pouvez commencer votre aventure.");

            ArrayList monstres = new ArrayList();

            Monstre rat = new Monstre("rat", 1, 1, 1, 0, 1, 1);
            Monstre loup = new Monstre("loup", 5, 5, 1, 0, 1, 1);
            Monstre bandit = new Monstre("bandit", 5, 5, 2, 1, 2, 1);

            monstres.Add(rat);
            monstres.Add(loup);
            monstres.Add(bandit);

            foreach (Monstre monstre in monstres)
            {
                Console.WriteLine("Un "+monstre.Nom+" ennemi se trouve sur votre chemin.");
                Console.WriteLine("A : Combat automatique | M : Combat manuel");
                string playerChoice = Console.ReadLine();
                switch(playerChoice)
                {
                case "A":
                    Combat.combattreAuto(joueur, monstre);
                    break;
                case "M":
                    Combat.combattreManuel(joueur, monstre);
                    break;
                default:
                    Console.WriteLine("A : Combat automatique | M : Combat manuel");
                    playerChoice = Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
