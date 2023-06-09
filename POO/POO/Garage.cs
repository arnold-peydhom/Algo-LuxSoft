using App;
using System;

namespace POO
{
    class Garage : Voiture
    {
        public string name;

        public string localisation;

        public Garage(string name, string localisation)
        {
            this.name = name;
            this.localisation = localisation;
        }
    }

    
}
