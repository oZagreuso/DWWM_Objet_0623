using CL_Point;
namespace ConsoleAppPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0.2, 0.4);
            point1.SeDeplacer(0.4, 0.8);
            point1.PermuterDeuxPoints();
            point1.creerPointSymetriqueAxeAbscisse();
            point1.creerPointSymetriqueAxeOrdonnee();
            point1.creerPointSymetriqueOrigine();
        }
    }
}