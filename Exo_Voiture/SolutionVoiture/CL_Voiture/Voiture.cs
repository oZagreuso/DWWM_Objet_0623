using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Voiture.ElementsVoiture;

namespace CL_Voiture
{
    public class Voiture
    {
        //Attribut Variable
        private string marqueVoiture;      

        //Attribut Objet
        private Roue[] sesQuatresRoues;
        private Moteur sonMoteur;

        //getter setter

        public string MarqueVoiture { get => marqueVoiture; private set => marqueVoiture = value; }
        public Roue[] SesQuatresRoues { get => sesQuatresRoues; private set => sesQuatresRoues = value; }
        public Moteur SonMoteur { get => sonMoteur; private set => sonMoteur = value; }

        //Constructeur par défaut

        public Voiture()
        {
            marqueVoiture = " Tesla ";         
            sesQuatresRoues = new Roue[4] { new Roue(), new Roue(), new Roue(), new Roue() };
            sonMoteur = new Moteur();
        }
        //ConstructeurCLassique
        public Voiture(string _marqueVoiture, Roue[] _sesQuatresRoues, Moteur _sonMoteur)
        {
            this.marqueVoiture = _marqueVoiture;            
            this.sesQuatresRoues = _sesQuatresRoues;
            this.sonMoteur = _sonMoteur;
        }
        //Constructeur par clonage
        public Voiture(Voiture cloneVoiture)
        {
            this.marqueVoiture = cloneVoiture.marqueVoiture;           
            this.sesQuatresRoues = cloneVoiture.sesQuatresRoues;
            this.sonMoteur = cloneVoiture.sonMoteur;
        }
        public bool Demarrer()
        {
            return sonMoteur.DemarrerMoteur();
        }
        public bool Eteindre()
        {
            return sonMoteur.ArreterMoteur();
        }
        public bool Avancer()
        {
            return sonMoteur.EntrainerRoue(sesQuatresRoues[0], sesQuatresRoues[1]);
        }
    }
}
