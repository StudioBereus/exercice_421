using System;

namespace exercice_421
{
    class Program
    {
        static void Main(string[] args)
        {
            int lancers;
            int capitalPoints;
            Console.WriteLine("Bienvenue dans le jeu du 421 \nVeuillez choisir le nombre de lancers que vous souhaitez faire");
            lancers = int.Parse(Console.ReadLine());
            capitalPoints = lancers * 10;
            Console.WriteLine("Vous avez " + capitalPoints + "points");
            manche421 m1 = new manche421();
            m1.demarrer();
            

        }
    }
}
