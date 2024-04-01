using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    var numero1 = 0;
                    var numero2 = 0;

                    Console.Write("Digite um numero: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    numero2 = int.Parse(Console.ReadLine());

                    var resultado1 = numero1 / numero2;
                    var resultado2 = numero1 % numero2;

                    Console.WriteLine("O quociente é: " + resultado1 + "\nO resto é: " + resultado2);
                    Console.Read();
                }

                catch (Exception)
                {
                    Console.Write("Digite apenas numeros e o campo não pode ser em branco");
                    Console.Read();
                }
        }
    }
}
