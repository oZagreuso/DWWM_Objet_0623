
using CL_Lepidoptere.StadeMetamorphose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    public class Lepidoptere
    {
        //Attribut

        private Stade stadeCourant;

        //Constructeur

        public Lepidoptere()
        {
            this.stadeCourant = new Oeuf();
        }

        //Methodes
        public void SeDeplacer()
        {
            this.stadeCourant.SeDeplacer();
        }
        public void SeMetamorphoser()
        {
            this.stadeCourant = stadeCourant.SeMetamorphoser();
        }
    }
}


