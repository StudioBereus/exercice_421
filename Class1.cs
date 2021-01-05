using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_421
{
    class De
    {
        private int valeur;
        private int jet = 0;
        //constructeurs 
        public void de()
        {
            int De = 0;
            De++;
        }
        //Methodes
        public int lancer()
        {
            jet++;
            Random aleatoire = new Random();
            valeur = aleatoire.Next(1, 7);
            return valeur;
        }

    }
    class manche421
    {
        int nombre = 0;
        public int demarrer()
        {
            nombre++;
            return nombre;
        }
    }
    class Partie
    {

    }
}
