using System;

namespace RPG
{
    public class Heros : Personnage
    {
        public int Experience;
        public int Or;

        public Heros(String nom, int pointsVieMax, int pointsVie, int attaque, int armure, int vitesse, int niveau, int experience, int or) :
        base(nom, pointsVieMax, pointsVie, attaque, armure, vitesse, niveau)
        {
            this.Nom = nom;
            this.PointsVieMax = pointsVieMax;
            this.PointsVie = pointsVie;
            this.Attaque = attaque;
            this.Armure = armure;
            this.Vitesse = vitesse;
            this.Niveau = niveau;
            this.Experience = experience;
            this.Or = or;
        }

        public void afficherStats() {
            Console.WriteLine("Points de vie : "+this.PointsVieMax);
            Console.WriteLine("Points d'attaque : "+this.Attaque);
            Console.WriteLine("Points d'armure : "+this.Armure);
            Console.WriteLine("Points de vitesse : "+this.Vitesse);
        }
    }
}