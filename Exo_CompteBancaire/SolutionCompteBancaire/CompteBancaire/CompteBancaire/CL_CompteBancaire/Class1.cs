namespace CL_CompteBancaire
{
    public class CompteBancaire
    {
        //Attributs
        private string nomProprietaireCompte;
        private uint numeroCompte;
        private double saisieMontant;
        private double soldeCompte;
        private int soldeMinimum;
        private bool debiterOk;

        //Constructeur par défaut

        public CompteBancaire()
            : this("Cagnetta", 696969, 400, 250, -300, true)
        {

        }

        //Constructeur classique

        public CompteBancaire(string _nomProprietaireCompte, uint _numeroCompte, double _saisieMontant, double _soldeCompte, int _soldeMinimum, bool debiterOk)
        {
            this.nomProprietaireCompte = _nomProprietaireCompte;
            this.numeroCompte = _numeroCompte;
            this.saisieMontant = _saisieMontant;
            this.soldeCompte = _soldeCompte;
            this.soldeMinimum = _soldeMinimum;
            this.debiterOk = debiterOk;
        }

        //Constructeur par clonage

        public CompteBancaire(CompteBancaire cloneCompteBancaire)
            : this(cloneCompteBancaire.nomProprietaireCompte, cloneCompteBancaire.numeroCompte, cloneCompteBancaire.saisieMontant, cloneCompteBancaire.soldeCompte, cloneCompteBancaire.soldeMinimum, cloneCompteBancaire.debiterOk)
        {

        }

        //Getter-Setter

        public string NomProprietaireCompte {  get => nomProprietaireCompte; set => nomProprietaireCompte = value; }
        public uint NumeroCompte { get => numeroCompte; set => numeroCompte = value; }
        public double SaisieMontant { get => saisieMontant; set => saisieMontant = value; }
        public double SoldeCompte { get => soldeCompte; set => soldeCompte = value; }
        public int SoldeMinimum { get => soldeMinimum; set => soldeMinimum = value; }
        
        //Méthodes


       
        public bool DebiterCompte()
        {
            if (this.debiterOk)
            {
                debiterOk = true;
                return true;
            }
            else
            {
                debiterOk = false;
                return false;
            }
        }

    }
}