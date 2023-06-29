using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_JeuDeLaGuerre;

namespace CL_JeuDeLaGuerre
{
    internal class Medecin
    {
        private uint tagPseudo;

        public uint TagPseudo { get => tagPseudo; private set => tagPseudo = value; }
    }
    public Medecin (uint _tagPseudo)
    {
        this.tagPseudo = _tagPseudo;
    }
}
