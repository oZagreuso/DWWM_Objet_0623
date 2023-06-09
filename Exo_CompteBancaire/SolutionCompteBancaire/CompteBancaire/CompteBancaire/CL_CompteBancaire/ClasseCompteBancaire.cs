﻿namespace CL_CompteBancaire
{
    public class CompteBancaire
    {
        //Attributs
        private string nomProprietaireCompte;
        private uint numeroCompte;
        private double soldeCompte;
        private int soldeMinimum;


        //Constructeur par défaut

        public CompteBancaire()
            : this("Cagnetta", 696969, 250, -300)
        {

        }

        //Constructeur classique

        public CompteBancaire(string _nomProprietaireCompte, uint _numeroCompte, double _soldeCompte, int _soldeMinimum)
        {
            this.nomProprietaireCompte = _nomProprietaireCompte;
            this.numeroCompte = _numeroCompte;
            this.soldeCompte = _soldeCompte;
            this.soldeMinimum = _soldeMinimum;
        }

        //Constructeur par clonage

        public CompteBancaire(CompteBancaire cloneCompteBancaire)
            : this(cloneCompteBancaire.nomProprietaireCompte, cloneCompteBancaire.numeroCompte, cloneCompteBancaire.soldeCompte, cloneCompteBancaire.soldeMinimum)
        {

        }

        //Getter-Setter

        public string NomProprietaireCompte { get => nomProprietaireCompte; private set => nomProprietaireCompte = value; }
        public uint NumeroCompte { get => numeroCompte; private set => numeroCompte = value; }
        public double SoldeCompte { get => soldeCompte; private set => soldeCompte = value; }
        public int SoldeMinimum { get => soldeMinimum; private set => soldeMinimum = value; }

        //Méthodes

        public void CrediterCompte(double saisieMontant)
        {
            this.soldeCompte = soldeCompte + saisieMontant;
            //Console.WriteLine(" Le solde du compte est de " + soldeCompte);
        }

        public bool DebiterOK(double saisieMontant)
        {
            bool debiterOk = true;
            if (soldeCompte - saisieMontant < soldeMinimum)
            {
                debiterOk = false;
            }
            else //if (soldeCompte - saisieMontant > soldeMinimum)
            {
                debiterOk = true;

            }
            return debiterOk;
        }

        public bool DebiterCompte(double saisieMontant)
        {
            bool okDebiter = false;
            if (DebiterOK(saisieMontant))
            {
                soldeCompte = soldeCompte - saisieMontant;
                okDebiter = true;
                //Console.WriteLine(" Le solde du compte est de " + soldeCompte);
            }
            else
            {
                okDebiter = false;
            }
            return okDebiter;
        }

        public bool TransfererMontant(double saisieMontant, CompteBancaire compteDestinataire)
        {
            if (DebiterOK(saisieMontant))
            {
                compteDestinataire.CrediterCompte(saisieMontant);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SoldeSuperieur(CompteBancaire compte2)
        {
            if (this.soldeCompte > compte2.soldeCompte)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}