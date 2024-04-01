using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    class Program
    {
        public string Tabuada(int numerotabuada)
        {
            var resultadoTabuada = 0;
            var resultado = "";

            for (var i = 1; i <= 10; i++)
            {
                resultadoTabuada = i * numerotabuada;
                Console.WriteLine(numerotabuada + "x" + i + "=" + resultadoTabuada);
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber a tabuada");

            var numerotabuada = int.Parse(Console.ReadLine());
           

            Tabuada(numerotabuada);

            Console.ReadKey();
        }
    }
}
