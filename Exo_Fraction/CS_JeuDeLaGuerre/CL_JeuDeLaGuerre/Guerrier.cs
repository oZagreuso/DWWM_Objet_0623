using CL_JeuDeLaGuerre;

namespace CL_JeuDeLaGuerre
{
    public class Guerrier
    {
        private uint tagPseudo;
        private uint niveauVie;
        private uint totalPuissanceArme;

        public uint TagPseudo { get => tagPseudo; private set => tagPseudo = value; }
        public uint NiveauVie { get => niveauVie; private set => niveauVie = value; }

        public Guerrier(uint _tagPseudo, uint _niveauVie, uint _totalPuissanceArme)
        {
            this.tagPseudo = _tagPseudo;
            this.niveauVie = _niveauVie;
            this.totalPuissanceArme = _totalPuissanceArme;
        }
        public Guerrier()
            : this (666, 10, 2)
        {

        }
        public Guerrier(Guerrier cloneGuerrier)
            : this (cloneGuerrier.TagPseudo, cloneGuerrier.niveauVie, cloneGuerrier.totalPuissanceArme)
        {

        }
        public void SeDeplacer()
        {

        }
        public void AjouterUneArme(Arme puissanceArme)
        {
            this.totalPuissanceArme = totalPuissanceArme + Arme puissanceArme;
        }
        public bool AjouterUneVie()
        {
            if (soinOk = true)
            {
                niveauVie++;
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}