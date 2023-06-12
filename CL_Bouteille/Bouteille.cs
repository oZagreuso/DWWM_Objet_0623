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
        private double contenuBouteilleEnLitres;
        private string typeNomContenuBouteille;       
        private bool estFermee;

       


        public string NomBouteille { get => nomBouteille; set => nomBouteille = value; }
        public string MatiereBouteille { get => matiereBouteille; set => matiereBouteille = value; }
        public double ContenanceBouteilleEnLitres { get => contenanceBouteilleEnLitres; set => contenanceBouteilleEnLitres = value; }
        public double ContenuBouteilleEnLitres { get => contenuBouteilleEnLitres; set => contenuBouteilleEnLitres = value; }
        public string TypeNomContenuBouteille { get => typeNomContenuBouteille; set => typeNomContenuBouteille = value; }
        public bool EstFermee { get => estFermee; private set => estFermee = value; }
        




        //Constructeurs (avec trois constructeurs, polymorphisme de constructeur)

        //Par défaut

        public Bouteille()
            :this("Pepsi Max", "Plastique", 1.25, 0.75, "soda", true)
        {
            /*nomBouteille = " Pepsi Max ";
            matiereBouteille = " Plastique ";
            contenanceBouteilleEnLitres = 1.25;
            contenuBouteilleEnLitres = 0.75;
            typeNomContenuBouteille = " soda ";            
            estFermee = true;
            //estVide = false;*/
        }

        //Classique

        public Bouteille(string _nomBouteille, string _matiereBouteille, double _contenanceBouteilleEnLitres, double _contenuBouteilleEnLitres, string _typeNomContenuBouteille, bool _estFermee)
        {
            this.nomBouteille = _nomBouteille;
            this.matiereBouteille = _matiereBouteille;
            this.contenanceBouteilleEnLitres = _contenanceBouteilleEnLitres;
            this.contenuBouteilleEnLitres = _contenuBouteilleEnLitres;
            this.typeNomContenuBouteille = _typeNomContenuBouteille;            
            this.estFermee = _estFermee;
            
        }

        //Par clonage

        public Bouteille(Bouteille cloneBouteille)
            :this(cloneBouteille.nomBouteille, cloneBouteille.matiereBouteille, cloneBouteille.contenanceBouteilleEnLitres, cloneBouteille.contenuBouteilleEnLitres, cloneBouteille.typeNomContenuBouteille, cloneBouteille.estFermee)
        {
            /*this.nomBouteille = cloneBouteille.nomBouteille;
            this.matiereBouteille = cloneBouteille.matiereBouteille;
            this.contenanceBouteilleEnLitres = cloneBouteille.contenanceBouteilleEnLitres;
            this.contenuBouteilleEnLitres = cloneBouteille.contenuBouteilleEnLitres;
            this.typeNomContenuBouteille = cloneBouteille.typeNomContenuBouteille;            
            this.estFermee = cloneBouteille.estFermee;*/
        }

        //Methodes
        /*public string GetNomBouteille()
        {
            return this.nomBouteille;
        }

        public string GetMatiereBouteille()
        {
            return this.matiereBouteille;
        }

        public double GetContenanceBouteilleEnLitres()
        {
            return this.contenanceBouteilleEnLitres;
        }
        public double GetContenuBouteilleEnLitres()
        {
            return this.contenuBouteilleEnLitres;
        }
        public string GetTypeNomContenuBouteille()
        {
            return this.typeNomContenuBouteille;
        }
        */
        public bool FermerBouteille()
        {
            if (this.estFermee)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool OuvrirBouteille()
        {
            if (this.estFermee)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemplirTout()
        {
            if (this.estFermee = false && this.contenuBouteilleEnLitres < this.contenanceBouteilleEnLitres)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ViderTout()
        {
            if (this.estFermee = false && this.contenuBouteilleEnLitres > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemplirBouteille(double quantiteEnLitres)
        {
            if (this.estFermee)
            {
                return false;
            }
            else
            {
                if (this.contenuBouteilleEnLitres < this.contenanceBouteilleEnLitres)
                {
                    this.contenuBouteilleEnLitres = this.contenuBouteilleEnLitres + quantiteEnLitres;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool ViderBouteille(double quantiteEnLitres)
        {
            if (this.estFermee)
            {
                return false;
            }
            else
            {
                if (this.contenuBouteilleEnLitres > 0)
                {
                    this.contenuBouteilleEnLitres = this.contenuBouteilleEnLitres - quantiteEnLitres;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
    }
}





