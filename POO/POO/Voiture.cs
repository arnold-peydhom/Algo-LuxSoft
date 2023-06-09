using System;

namespace App
{
     class Voiture
    {
        public string couleur;

        public string modele;

        public Voiture(string couleur,string modele)
        {
            this.couleur = couleur;
            this.modele = modele;
        }

        public void GetText()
        {
            Console.WriteLine ($"j ai une voiture {couleur} et de modele {modele}");
        }
    }
}