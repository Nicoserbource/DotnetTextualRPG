using System;

namespace RPG
{
    public static class Combat
    {
        public static void combattre(Heros pj, Monstre ia)
        {
            Random random = new Random();
            int degatsPj;
            int degatsIa;
            int attaquePj;
            int attaqueIa;
            pj.PointsVie = pj.PointsVieMax;
            ia.PointsVie = ia.PointsVieMax;
            Console.WriteLine("Un "+ia.Nom+" ennemi se trouve sur votre chemin.");
            while (pj.PointsVie>0 && ia.PointsVie>0)
            {
                if (pj.Vitesse>=ia.Vitesse)
                {
                    Console.WriteLine("Vous attaquez le " + ia.Nom + " ennemi !");
                    attaquePj = random.Next(1, pj.Attaque);
                    degatsPj = (attaquePj)-(ia.Armure);
                    if (degatsPj<=0)
                    {
                        degatsPj = 1;
                    }
                    ia.PointsVie -= degatsPj;
                    Console.WriteLine("Le "+ia.Nom+" ennemi perd "+degatsPj+" points de vie, il lui reste "+ia.PointsVie+" points de vie.");
                    if (ia.PointsVie<=0)
                    {
                        Console.WriteLine("Vous avez vaincu le "+ia.Nom+" ennemi !");
                        pj.Experience += (ia.Niveau*20);
                        pj.Or += (int)Math.Pow(random.Next(1, 10+ia.Niveau), 2);
                        Console.WriteLine("Vous disposez de "+pj.Experience+" points d'expérience et de "+pj.Or+" pièces d'or.");
                        if (pj.Experience >= (10*(int)Math.Pow(2, pj.Niveau)))
                        {
                            pj.PointsVieMax += 5;
                            pj.Attaque++;
                            pj.Armure++;
                            pj.Vitesse++;
                            pj.Niveau++;
                            Console.WriteLine("Vous passez au niveau "+pj.Niveau+" !");
                            pj.afficherStats();
                        }
                        break;
                    }
                    Console.WriteLine("Le " + ia.Nom + " ennemi vous attaque !");
                    attaqueIa = random.Next(1, ia.Attaque);
                    degatsIa = (attaqueIa)-(pj.Armure);
                    if (degatsIa<=0)
                    {
                        degatsIa = 1;
                    }
                    pj.PointsVie -= degatsIa;
                    Console.WriteLine("Vous perdez "+degatsIa+" points de vie, il vous reste "+pj.PointsVie+" points de vie.");
                    if (pj.PointsVie<=0)
                    {
                        Console.WriteLine("Vous avez été vaincu par le "+ia.Nom+" ennemi !");
                        break;
                    }
                }
                else if (pj.Vitesse<ia.Vitesse)
                {
                    Console.WriteLine("Le " + ia.Nom + " ennemi vous attaque !");
                    attaqueIa = random.Next(1, ia.Attaque);
                    degatsIa = (attaqueIa)-(pj.Armure);
                    if (degatsIa<=0)
                    {
                        degatsIa = 1;
                    }
                    pj.PointsVie -= degatsIa;
                    Console.WriteLine("Vous perdez "+degatsIa+" points de vie, il vous reste "+pj.PointsVie+" points de vie.");
                    if (pj.PointsVie<=0)
                    {
                        Console.WriteLine("Vous avez été vaincu par le "+ia.Nom+" ennemi !");
                        break;
                    }
                    Console.WriteLine("Vous attaquez le " + ia.Nom + " ennemi !");
                    attaquePj = random.Next(1, pj.Attaque);
                    degatsPj = (attaquePj)-(ia.Armure);
                    if (degatsPj<=0)
                    {
                        degatsPj = 1;
                    }
                    ia.PointsVie -= degatsPj;
                    Console.WriteLine("Le "+ia.Nom+" ennemi perd "+degatsPj+" points de vie, il lui reste "+ia.PointsVie+" points de vie.");
                    if (ia.PointsVie<=0)
                    {
                        Console.WriteLine("Vous avez vaincu le "+ia.Nom+" ennemi !");
                        pj.Experience += (ia.Niveau*20);
                        pj.Or += (int)Math.Pow(random.Next(1, 10+ia.Niveau), 2);
                        Console.WriteLine("Vous disposez de "+pj.Experience+" points d'expérience et de "+pj.Or+" pièces d'or.");
                        if (pj.Experience >= (10*(int)Math.Pow(2, pj.Niveau)))
                        {
                            pj.PointsVieMax += 5;
                            pj.Attaque++;
                            pj.Armure++;
                            pj.Vitesse++;
                            pj.Niveau++;
                            Console.WriteLine("Vous passez au niveau "+pj.Niveau+" !");
                            pj.afficherStats();
                        }
                        break;
                    }
                }
            }
        }
    }
}