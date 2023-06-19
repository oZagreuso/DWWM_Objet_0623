using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere.StadeMetamorphose
{
    internal class Chenille : Stade
    {
        public override void SeDeplacer()
        {
            Console.WriteLine(" La chenille peut se déplacer ");
        }

        public override Stade SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
