using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI_Study
{
    class Onca : Mamiferos
    {
        public override void Atacar()
        {
            
        }

        public override void Defender()
        {
           
        }

        public override Mamiferos Procriar()
        {
            return new Onca();
        }
    }
}
