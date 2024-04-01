using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de fibonacci: ");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            var num1 = 0;
           
            var num2 = 1;

           for (var i = 1; i < 50; i++)
             {
                var aux = num1;
                num1 = num2;
                num2 = aux + num1;
                Console.WriteLine("{0}", num2);


            }

            // Iniciamos o programa setando duas variáveis int 
            int a = 0, fib = 1;


            // A variável fib é testada no laço while, e enquanto for <= 100 o laço continua 
            while (fib <= 100)
            {

                // O Console mostra os valores inicias das variaveis ‘a’ e ‘fib’, que são ‘0’ e ‘1’ respectivamente 
                Console.Write(a + " " + fib + " ");

                // A partir daqui as variáveis ‘a’ e ‘fib’ começam a obter os valores umas das outras


                // ‘a’ será igual a ela mesma mais ‘fib’ 
                a += fib;
                // ‘fib’ será igual a ela mesma mais ‘a’ 
                fib += a;
                // O laço while só será encerrado quando a condição do laço for falsa 
            }
            // O Console apenas coloca um espaço em branco no final da linha 
            Console.WriteLine(" "); 
            Console.ReadKey();
        }
    }
}
