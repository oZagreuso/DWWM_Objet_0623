using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere.StadeMetamorphose
{
    internal class Papillon : Stade
    {

        public override void SeDeplacer()
        {
            Console.WriteLine(" Le Papillon vol ");
        }

        public override Stade SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
