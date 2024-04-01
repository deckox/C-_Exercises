using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI_Study
{
    class Lobo : Mamiferos
    {
        public override void Atacar()
        {
           
        }

        public override void Defender()
        {
           
        }

        public override Mamiferos Procriar()
        {
            return new Lobo();
        }
    }
    /*public class SeiLa
    {
        public void Procriar()
        {
            var lobo = new Lobo();
            Lobo lobinho = lobo.Procriar();
        }
    }*/
}
