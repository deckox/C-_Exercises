using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI_Study
{
    class Guepardo : Mamiferos
    {
        public string Nome { get; set; }
        public int PesoMedio { get; set; }
        public string NomeCientifico { get; set; }
        public string PaisTipico { get; set; }
        public string TipodeMamifero { get; set; }
        public string TipodeAnimal { get; set; }

        public void Atacar()
        {

        }

        public void Defender()
        {

        }

        public void Procriar()
        {
            new Guepardo();
        }

    }
}
