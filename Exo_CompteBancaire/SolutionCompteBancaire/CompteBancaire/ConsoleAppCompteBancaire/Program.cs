using CL_CompteBancaire;
namespace ConsoleAppCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire("Olivier", 838383, 500, -200);
            CompteBancaire compte2 = new CompteBancaire("Claudio", 696969, 50, -100);
            bool okDebit1 = compte1.DebiterCompte(600);
            compte1.CrediterCompte(800);
            bool okDebit2 = compte1.DebiterCompte(3000);
            compte1.CrediterCompte(5000);
            bool okTransfr1 = compte1.TransfererMontant(100, compte2);
            bool okTransfr2 = compte1.SoldeSuperieur(compte2);
            
        }
    }
}