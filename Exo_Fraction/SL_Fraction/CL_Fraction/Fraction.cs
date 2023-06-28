namespace CL_Fraction
{
    public class Fraction
    {
        //Attributs

        private int numerateur;
        private int denominateur;       

        //Getter Setter

        public int Numerateur { get => numerateur; private set => numerateur = value; }
        public int Denominateur { get => denominateur; private set => denominateur = value; }           

        // Constructeurs Classiques

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;            
        }

        public Fraction(int _numerateur)
        {
            Numerateur = _numerateur;
        }

        // Constructeur par Clonage

        public Fraction(Fraction cloneFraction)
            : this(cloneFraction.numerateur, cloneFraction.denominateur) { }

        //Constructeur par défaut

        public Fraction()
            : this(12, 7) { }

        public void Oppose()
        {
            numerateur = numerateur * -1;
            denominateur = denominateur * -1;
        }

        public void Inverse()
        {
            int temp;
            temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        public void Plus(Fraction _autreFraction)
        {
            numerateur = (this.numerateur * _autreFraction.denominateur) + (this.denominateur * _autreFraction.numerateur);
            denominateur = (this.denominateur * _autreFraction.denominateur);            
        }
            /*public static int Pgcd(int denominteur, int denominateur)
            {
               
            }*/
        
    }
}