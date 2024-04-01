using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI_Study
{
    public class Program
    {
        public enum tipoDeAnimal {Mamiferos, Passaros, Peixes, Repteis, Anfibios};
        public enum tipoDeMamifero { canino, felino};
        static void Main(string[] args)
        {
            Mamiferos animais = new Tigre();
            
        }

        public void Atacar(Mamiferos mamiferos)
        {
            mamiferos.Atacar();
        }
    }
}
