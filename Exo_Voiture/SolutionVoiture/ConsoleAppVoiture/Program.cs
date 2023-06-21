using CL_Voiture.ElementsVoiture;

namespace ConsoleAppVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue roue1 = new Roue(false);
            bool tournerRoue = roue1.TournerRoue();
            Console.WriteLine(" Roue Tourne Ok ");
            bool arreterRoue = roue1.ArreterRoue();
            Console.WriteLine(" Roue Arret Ok ");

            Roue roue2 = new Roue(true);
            bool tournerRoue2 = roue2.TournerRoue();
            bool arreterRoue2 = roue2.ArreterRoue();

            Moteur moteur1 = new Moteur(true);
            bool demarrerMoteur = moteur1.DemarrerMoteur();
            bool arreterMoteur = moteur1.ArreterMoteur();
            bool entrainerRoue = moteur1.EntrainerRoue(roue1, roue2);


            Moteur moteur2 = new Moteur(false);
            bool demarrerMoteur2 = moteur2.DemarrerMoteur();
            bool arreterMoteur2 = moteur2.ArreterMoteur();
            bool entrainerRoue2 = moteur2.EntrainerRoue(roue1, roue2);

            Moteur moteur3 = new Moteur(false);
            bool demarrerRoue3 = moteur3.DemarrerMoteur();
            bool entrainerRoue3 = moteur3.EntrainerRoue(roue1, roue2);

            Moteur moteur4 = new Moteur(false);
            bool arreterRoue4 = moteur4.ArreterMoteur();
            bool entrainerRoue4 = moteur4.EntrainerRoue(roue1, roue2);

            Moteur moteur5 = new Moteur(true);
            bool arreterRoue5 = moteur5.ArreterMoteur();
            bool entrainerRoue5 = moteur5.EntrainerRoue(roue1, roue2);

        }
    }
}