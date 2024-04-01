using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {


        static void Main(string[] args)
        {

            try
            {
                int numeroDigitado = 0;
                Console.Write("Digite o numero para saber a somatoria: ");
                numeroDigitado = int.Parse(Console.ReadLine());
                Console.Write("A somatoria de " + numeroDigitado + " é " + Somatoria(numeroDigitado));
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.Write("Digite apenas numeros!");
                Console.ReadLine();
            }


        }

        public static int Somatoria(int numeroDigitado)
        {
            if (numeroDigitado == 0)
            {
                return 0;
            }

            else
            {
                return Somatoria(numeroDigitado - 1) + numeroDigitado;
            }


        }

        //8) Crie um programa que recebe um numero e calcula o somatorio do mesmo usando uma função recursiva
    }
}
