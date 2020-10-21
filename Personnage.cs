using System;

namespace RPG
{
    public class Personnage
    {
        public String Nom { get; set; }
        public int PointsVieMax { get; set; }
        public int PointsVie { get; set; }
        public int Attaque { get; set; }
        public int Armure { get; set; }
        public int Vitesse { get; set; }
        public int Niveau { get; set; }
        
        public Personnage(String nom, int pointsVieMax, int pointsVie, int attaque, int armure, int vitesse, int niveau)
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