using CL_Voiture;
using CL_Voiture.ElementsVoiture;
namespace ConsoleRoue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Roue roue1 = new Roue(false);
            bool tournerRoue = roue1.TournerRoue();
            Console.WriteLine(" La Roue Tourne ");
            bool arreterRoue = roue1.ArreterRoue();
            Console.WriteLine(" La Roue s'arrête ");
        }
    }
}