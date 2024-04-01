using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaParImpar = new List<int>();
            var opcao = "";
            var numeroArmazenado = 0;
            var numerosPares = "";
            var numerosImpares = "";

            while (opcao.ToLower() != "parimpar")
            {
                try
                {
                    Console.WriteLine("Digite o numero desejado ou digite parimpar para descobrir quais os numeros: ");
                    opcao = Console.ReadLine();

                    if (opcao == "sair")
                    {
                        Environment.Exit(0);
                    }

                    if (opcao.ToLower() != "parimpar")
                    {
                        numeroArmazenado = int.Parse(opcao);
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Valor inválido! \n");
                }

            }

             for (int i = 0; i < numeroArmazenado; i++)
            {
                if (i % 2 == 0 && i == numeroArmazenado - 1)
                {
                    numerosPares = numerosPares + i + "";
                    break;
                }

                if (i % 2 == 1 && i == numeroArmazenado - 1)
                {
                    numerosImpares = numerosImpares + i + "";
                    break;
                }


                if (i % 2 == 0)
                {
                    numerosPares = numerosPares + i + " , ";
                }

                else
                {
                    numerosImpares = numerosImpares + i + " , ";
                }
                
            }

            Console.WriteLine("\nNumeros Pares: " + numerosPares);
            Console.WriteLine("\nNumeros Impares: " + numerosImpares);
            Console.Read();
        }
    }

}
