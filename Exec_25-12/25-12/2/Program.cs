using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero1 = 0;
                int numero2 = 0;
                int numero3 = 0;
                var qualMaior = 0;
                var resultado = 0;

                Console.Write("Favor digitar um numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Favor digitar um numero: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.Write("Favor digitar um numero: ");
                numero3 = int.Parse(Console.ReadLine());

                //qualMaior = (numero1 > numero2) ? resultado = numero1 : (numero2 > numero3) ? resultado = numero2 :
                //    (numero3 > numero1) ? resultado = numero3 : resultado = numero1;



                qualMaior = (numero1 > numero2) ?  numero1 : (numero2 > numero3) ?  numero2 :
                    (numero3 > numero1) ?  numero3 :  numero1;

                Console.WriteLine("O maior numero é: " + qualMaior);
                Console.Read();
            }

            catch (Exception)
            {
                Console.WriteLine("Digitar apenas numeros e o campo não pode ser em branco");
            }
        }
    }
}
