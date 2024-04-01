using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RDI_Study.Program;

namespace RDI_Study
{
    public abstract class Mamiferos
    {
        //abstract == cada classe que herda da clase mamiferos deve ter o seu proprio metodo

        public string Nome { get; set; }
        public int PesoMedio { get; set; }
        public string NomeCientifico { get; set; }
        public string PaisTipico { get; set; }
        public tipoDeMamifero TipodeMamifero { get; set; }
        public tipoDeAnimal TipodeAnimal
        {
            get
            {
                return tipoDeAnimal.Mamiferos;
            }
        }

        public abstract void Atacar();

        public abstract void Defender();

        public abstract Mamiferos Procriar();
       
       
    }
}
