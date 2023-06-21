using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CL_Voiture.ElementsVoiture
{
    public class Roue
    {
        //Attribut
        private bool tourne;

        //Constructeur par défaut
        public Roue()
        {
            tourne = false;
        }
        //Constructeur Classique
        public Roue(bool _tourne)
        {
            this.tourne = _tourne;
        }
        //Constructeur par Clonage
        public Roue(Roue cloneRoue)
        {
            this.tourne = cloneRoue.tourne;
        }
        public bool TournerRoue()
        {
            if (this.tourne)
            {
                Console.WriteLine(" La roue tourne déjà ");
                return false;
            }
            else
            {
                this.tourne = true;
                Console.WriteLine(" La roue tourne ");
                return true;
            }
        }
        public bool ArreterRoue()
        {
            if (this.tourne)
            {
                this.tourne = false;
                Console.WriteLine(" La roue s'arrête ");
                return true;
            }
            else
            {
                Console.WriteLine(" La roue est déjà à l'arrêt ");
                return false;
            }
        }


    }
}
