using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuDeLaGuerre
{
    internal abstract class Arme
    {
        private uint puissanceArme;

        public uint PuissanceArme { get => puissanceArme; set => puissanceArme = value; }
        public Arme(uint _puissanceArme)
        {
            this.puissanceArme = _puissanceArme;
        }
    }
}
