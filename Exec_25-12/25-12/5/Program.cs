using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        enum QuatroEstacoes { Verao, Outono, Inverno, Primaveira };

        static void Main(string[] args)
        {

            QuatroEstacoes EstacoesDoAno = QuatroEstacoes.Verao;

            Console.WriteLine("A estação corrente é: " + EstacoesDoAno);
            Console.Read();

        }



    }
}
