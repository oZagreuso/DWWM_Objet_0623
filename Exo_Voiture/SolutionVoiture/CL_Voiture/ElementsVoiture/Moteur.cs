using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture.ElementsVoiture
{

    public class Moteur
    {
        //Attribut

        private bool estOn;

        public bool EstOn { get => estOn; private set => estOn = value; }

        //Constructeur classique
        public Moteur(bool _estOn) => this.estOn = _estOn;

        //Constructeur par défaut

        public Moteur()
        {
            this.EstOn = false;
        }

        //Constructeur par Clonage

        public Moteur(Moteur cloneMoteur)
        {
            this.EstOn = cloneMoteur.EstOn;
        }

        //Méthodes

        public bool DemarrerMoteur()
        {
            if (estOn)
            {
                return false;
            }
            else
            {
                this.estOn = true;//estOn passe de Faux à Vrai
                return true;
            }
        }
        public bool ArreterMoteur()
        {
            if (estOn)
            {
                this.estOn = false;//estOn passe de Vrai à Faux
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EntrainerRoue(Roue roueAvantGauche, Roue roueAvantDroite)
        {
            if (estOn)
            {
                bool ok1 = roueAvantGauche.TournerRoue();
                bool ok2 = roueAvantDroite.TournerRoue();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool StopEntrainerRoue(Roue roueAvantGauche, Roue roueAvantDroite)
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
