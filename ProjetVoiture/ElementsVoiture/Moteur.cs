using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{

    public class Moteur
    {
        //Attribut

        private bool estOn;
               
        public bool EstOn { get => estOn; private set => estOn = value; }

        //Constructeur
        public Moteur(bool _estOn) => this.estOn = _estOn;

        //Méthodes

        public bool DemarrerMoteur()
        {
            if (estOn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ArreterMoteur()
        {
            if (estOn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FaireTournerRoue(bool RoueAvantGauche, bool RoueAvantDroite)
        {
            if (estOn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool StopTournerRoue(bool RoueAvantGauche, bool RoueAvantDroite)
        {
            if (estOn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }


}
