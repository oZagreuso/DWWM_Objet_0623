using CL_Bouteille;

namespace ProjetBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleBiereGuiGui = new Bouteille(" Bouteille biere de tata Guillaume ", " Verre ", 40, 0.25, " Bière ", true);
            string nomBouteille = bouteilleBiereGuiGui.GetNomBouteille();
            string matiereBouteille = bouteilleBiereGuiGui.GetMatiereBouteille();
            double contenanceBouteille = bouteilleBiereGuiGui.GetContenanceBouteilleEnLitres();
            double contenuBouteille = bouteilleBiereGuiGui.GetContenuBouteilleEnLitres();
            bool fermerBouteille = bouteilleBiereGuiGui.FermerBouteille();
            bool ouvrirBouteille = bouteilleBiereGuiGui.OuvrirBouteille();
            bool remplirTout = bouteilleBiereGuiGui.RemplirTout();
            bool viderTour = bouteilleBiereGuiGui.ViderTout();
            bool remplirBouteille = bouteilleBiereGuiGui.RemplirBouteille(0.5);
            bool viderBouteille = bouteilleBiereGuiGui.ViderBouteille(0.3);
        }
    }
}