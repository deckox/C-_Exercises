using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR1
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> Lista = new List<int>();

                Console.WriteLine("Insira 10 números...");

                var contador = true;
                var aux = 0;
                var resultado = 0;

                while (contador)
                {
                    var numeros = int.Parse(Console.ReadLine());
                    Lista.Add(numeros);

                    if (Lista.Count == 10)
                    {
                        contador = false;
                    }

                }

                //#Manual bubble sort
                for (var i = 1; i < Lista.Count; i++)
                {
                    for (int j = 0; j < Lista.Count - 1; j++)
                    {
                        if (Lista[j] > Lista[j + 1])
                        {
                            aux = Lista[j];
                            Lista[j] = Lista[j + 1];
                            Lista[j + 1] = aux;
                        }

                    }
                }

                Console.WriteLine(" \nNumeros ordernados ficam: ");

                foreach (var item in Lista)
                {
                    resultado = resultado + item;
                    Console.WriteLine(item);
                }

            Console.WriteLine("\n" + "O menor número é: " + Lista.First());
            Console.WriteLine("O maior número é: " + Lista.Last());
            Console.WriteLine("A média dos números são: " + resultado / Lista.Count);



            Console.ReadKey();

            
        }
    }
}
