using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere.StadeMetamorphose
{
    internal class Chrysalide : Stade
    {

        public override void SeDeplacer()
        {
            Console.WriteLine(" La Chrysalide ne peut pas se déplacer ");
        }

        public override Stade SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
