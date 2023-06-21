using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Voiture
    {
        //Attribut
        private string marqueVoiture;
        private bool estDemarre;

        public string MarqueVoiture { get => marqueVoiture; private set => marqueVoiture = value; }
        public bool EstDemarre { get => estDemarre; set => estDemarre = value; }

        //Constructeur
        public Voiture(string _marqueVoiture, bool _estDemarre)
        {
            this.marqueVoiture = _marqueVoiture;
            this.estDemarre = _estDemarre;
        }
        public bool Demarrer()
        {
            if (estDemarre)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Eteindre()
        {
            if (estDemarre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Avancer()
        {
            if (!estDemarre)
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
