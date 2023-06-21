using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CL_Voiture
{
    public class Roue
    {
        //Attributs

        private bool tourneRoueAvantDroite = false;
        private bool tourneRoueAvantGauche = false;

        //Constructeur
        public Roue(bool tourneRoueAvantDroite, bool tourneRoueAvantGauche) => this.tourneRoueAvantDroite=tourneRoueAvantDroite;

        //Méthodes

        public bool RoueTourner()
        {
            if (this.tourneRoueAvantDroite && this.tourneRoueAvantGauche)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool RoueStopper()
        {
            if (this.tourneRoueAvantDroite && this.tourneRoueAvantGauche)
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
