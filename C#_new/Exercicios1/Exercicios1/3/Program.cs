using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber o seu fatorial: ");
            var fatorial = int.Parse(Console.ReadLine());
            var resultado = 1;

            for (int i = 1; i <= fatorial; i++)
            {
                resultado = i * resultado;
            }

            Console.WriteLine("O fatorial de " + fatorial + " é: " + resultado);
            
            Console.ReadKey();
            
        }
    }
}
