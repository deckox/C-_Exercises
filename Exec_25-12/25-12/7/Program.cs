using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcao = "";

            while (opcao.ToLower() != "sim")
            {
                int numeroDigitado = 0;
                long resultado = 1;
               
                try
                {
                   
                    Console.Write("Digite um numero para saber o fatorial: ");
                    numeroDigitado = int.Parse(Console.ReadLine());


                    if (numeroDigitado != 0)
                    {
                        for (var i = numeroDigitado; i > 0; i--)
                        {
                            resultado = resultado * i;
                        }
                    }

                    Console.Write("O fatorial de " + numeroDigitado + " é " + resultado);
                    Console.ReadLine();
                    Console.Write("Deseja Sair? (Digite SIM para sair) : ");

                    opcao = Console.ReadLine();
                    resultado = 0;
                }

                catch (Exception)
                {
                    Console.WriteLine("O numero não pode ser em branco ou digitar apenas numeros!");
                    Console.ReadLine();
                }
            }

            /*7) Crie uma aplicação que ira ler um numero e o programa devera exibir o seu fatorial,
             * ou seja a soma da multiplicação de um número (n) vezes, onde n é o número lido.
	        ex: usuario informa 5
	        resultado esperado :
		    5! =  120*/

        }
    }
}
