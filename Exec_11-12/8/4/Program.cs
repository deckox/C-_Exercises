using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Numero { valor = 15};
            Console.WriteLine(k.valor);
            k++;

            Console.WriteLine(k.valor);
            k++;

            Console.ReadLine();
        }
    }

    class Numero
    {
        public int valor { get; set; }

        public static Numero operator ++(Numero k)
        {
            return new Numero { valor = k.valor + 10 };
        }

        

    }
}
