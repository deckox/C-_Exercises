using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaParImpar = new List<int>();
            var opcao = "";
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
                        ListaParImpar.Add(int.Parse(opcao));
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Valor inválido! \n");
                }

            }

            for (int i = 0; i < ListaParImpar.Count(); i++)
            {
                if (ListaParImpar[i] % 2 == 0 && ListaParImpar[i] == ListaParImpar[ListaParImpar.Count - 1])
                {
                    numerosPares = numerosPares + ListaParImpar[i] + "";
                    break;
                }

                if (ListaParImpar[i] % 2 == 1 && ListaParImpar[i] == ListaParImpar[ListaParImpar.Count - 1])
                {
                    numerosImpares = numerosImpares + ListaParImpar[i] + "";
                    break;
                }


                if (ListaParImpar[i] % 2 == 0)
                {
                    numerosPares = numerosPares + ListaParImpar[i] + " , ";
                }

                else
                {
                    numerosImpares = numerosImpares + ListaParImpar[i] + " , ";
                }
                
            }

            Console.WriteLine("\nNumeros Pares: " + numerosPares);
            Console.WriteLine("\nNumeros Impares: " + numerosImpares);
            Console.Read();

            /*
             Crie uma aplicação que irá ler um numero informado pelo usuario e inforar todos os numeros pares no 
             intervalo de 1 até o numero informado e depois os numeros impares.
   
	         ex: 10
	             Resultado:
		         Numeros pares: 2, 4, 6, 8, 10
	        	 Numeros impares: 1, 3, 5, 7, 9
			*/

        }
    }
}
