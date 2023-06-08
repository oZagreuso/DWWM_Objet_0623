using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{

    public class Bouteille
    {
        //Attributs

        private string nomBouteille;
        private string matiereBouteille;
        private double contenanceBouteilleEnLitres;
        private double contenuNiveauBouteilleEnLitres;
        private string typeNomContenuBouteille;
        private bool estFermee;
        private bool estVide;

        //Constructeurs (avec trois constructeurs, polymorphisme de constructeur

            //Par défaut

        public Bouteille()
        {
            nomBouteille = " Pepsi Max ";
            matiereBouteille = " Plastique ";
            contenanceBouteilleEnLitres = 1.25;
            contenuNiveauBouteilleEnLitres = 0.75;
            typeNomContenuBouteille = " soda ";
            estFermee = true;
            estVide = false;
        }

            //Classique

        public Bouteille(string _nomBouteille, string _matiereBouteille, double _contenanceBouteilleEnLitres, double _contenuNiveauBouteilleEnLitres, string _typeNomContenuBouteille, bool _estFermee, bool _estVide)
        {
            this.nomBouteille = _nomBouteille;
            this.matiereBouteille = _matiereBouteille;
            this.contenanceBouteilleEnLitres = _contenanceBouteilleEnLitres;
            this.contenuNiveauBouteilleEnLitres = _contenuNiveauBouteilleEnLitres;
            this.typeNomContenuBouteille = _typeNomContenuBouteille;
            this.estFermee= _estFermee;
            this.estVide= _estVide;
        }

            //Par clonage

        public Bouteille(Bouteille cloneBouteille)
        {
            this.nomBouteille = cloneBouteille.nomBouteille;
            this.matiereBouteille = cloneBouteille.matiereBouteille;
            this.contenanceBouteilleEnLitres = cloneBouteille.contenanceBouteilleEnLitres;
            this.contenuNiveauBouteilleEnLitres = cloneBouteille.contenuNiveauBouteilleEnLitres;
            this.typeNomContenuBouteille = cloneBouteille.typeNomContenuBouteille;
            this.estFermee = cloneBouteille.estFermee;
            this.estVide = cloneBouteille.estVide;
        }


        //Methodes

        public string GetNomBouteille;
        public string GetMatiereBouteille;
        public double GetContenanceBouteilleEnLitres;
        private double GetContenuBouteilleEnLitres;
        public bool FermerBouteille;
        public bool OuvrirBouteille;
        public bool RemplirBouteille(double remplirQuantiteEnLitres)
        {
            if (this.estFermee)
            {                
                return false;
            }
            else
            {
                if (this.contenuNiveauBouteilleEnLitres < this.contenanceBouteilleEnLitres)
                {
                    this.contenanceBouteilleEnLitres = this.contenanceBouteilleEnLitres + this.contenuNiveauBouteilleEnLitres;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool ViderBouteille(double viderBouteilleEnLitres)
        {
            if (this.estFermee)
            {
                return false;
            }
            else
            {
                if(this.contenuNiveauBouteilleEnLitres > 0)
                {

                }
            }
            bool viderOk;
            return true;
        }

    }

}
    


