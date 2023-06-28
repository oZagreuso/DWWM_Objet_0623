namespace CL_Fraction
{
    public class Fraction
    {
        //Attributs

        private int numerateur;
        private int denominateur;
        private int pgcd;

        //Getter Setter

        public int Numerateur { get => numerateur; private set => numerateur = value; }
        public int Denominateur { get => denominateur; private set => denominateur = value; }      
        public int Pgcd { get => pgcd; private set => pgcd = value; }

        // Constructeur Classique

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;            
        }

        // Constructeur par Clonage

        public Fraction(Fraction cloneFraction)
            : this(cloneFraction.numerateur, cloneFraction.denominateur) { }

        //Constructeur par défaut

        public Fraction()
            : this(12, 7) { }

        public void Oppose()
        {
             new Fraction(numerateur * -1, denominateur * -1);
        }

        public void Inverse()
        {
            int temp;
            temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }
    }
}