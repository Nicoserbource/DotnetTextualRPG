using System;

namespace RPG
{
    public class Monstre : Personnage
    {
        public Monstre(String nom, int pointsVieMax, int pointsVie, int attaque, int armure, int vitesse, int niveau) :
        base(nom, pointsVieMax, pointsVie, attaque, armure, vitesse, niveau)
        {
            this.Nom = nom;
            this.PointsVieMax = pointsVieMax;
            this.PointsVie = pointsVie;
            this.Attaque = attaque;
            this.Armure = armure;
            this.Vitesse = vitesse;
            this.Niveau = niveau;
        }
    }
}