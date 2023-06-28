namespace CL_Point
{
    public class Point
    {
        //Attributs

        private double positionActuelleX;
        private double positionActuelleY;

        //Getter Setter

        public double PositionActuelleX { get => positionActuelleX; private set => positionActuelleX = value; }
        public double PositionActuelleY { get => positionActuelleY; private set => positionActuelleY = value; }


        //Constructeur Classique

        public Point(double _positionActuelleX, double _positionActuelleY)
        {
            this.positionActuelleX = _positionActuelleX;
            this.positionActuelleY = _positionActuelleY;
        }

        //Constructeur par défaut

        public Point()
            : this(0.0, 0.0)
        {

        }

        //Constructeur par clonage

        public Point(Point clonePoint)
            : this(clonePoint.positionActuelleX, clonePoint.positionActuelleY)
        {

        }

        //Methodes

        public void SeDeplacer(double newY, double newX)
        {
            this.positionActuelleX = newX;
            this.positionActuelleY = newY;

        }

        public void PermuterDeuxPoints()
        {
            double temp;
            temp = positionActuelleX;
            positionActuelleX = positionActuelleY;
            positionActuelleY = temp;

        }

        public Point CreerPointSymetriqueAxeAbscisse()
        {
            return new Point(positionActuelleX, positionActuelleY * -1);
        }

        public Point CreerPointSymetriqueAxeOrdonne()
        {
            return new Point(positionActuelleX * -1, positionActuelleY);
        }

        public Point creerPointSymetriqueOrigine()
        {
            return new Point(positionActuelleX * -1, positionActuelleY * -1);
        }

        public string StatutPosition()
        {
            return (" Position de X " + positionActuelleX + " Position de y " + positionActuelleY);
        }
    }
}