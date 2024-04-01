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
            int resultado;
            int numero1;
            int numero2;

            Console.Write("Digite um numero para saber, o numero vezes ele mesmo: ");
            numero1 = int.Parse(Console.ReadLine());
            resultado = tabuada(numero1);
            Console.Write(" \nO resultado de " + numero1 + " vezes ele mesmo é: " + resultado);


            Console.Write(" \nDigite 2 numeros para calcula a multiplicacao entre eles: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            resultado = tabuada(numero1, numero2);
            Console.Write("O resultado de " + numero1 + " vezes " + numero2 + " é: " + resultado);

            Console.ReadLine();
        }

        public static int tabuada(int numero1)
        {
            return numero1 * numero1;
        }

        public static int tabuada(int numero1, int numero2)
        {
            return numero1 * numero2;

        }
    }
}
    /*2) Crie uma aplicação onde é utilizado sobrecarga de metodo. */