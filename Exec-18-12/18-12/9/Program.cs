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
            Console.WriteLine(Multiplicar()); // 50
            Console.WriteLine(Multiplicar(4)); // 40
            Console.WriteLine(Multiplicar(4, 5)); // 20
            Console.WriteLine(Multiplicar(y: 5)); // 25
            Console.Read();


            kimura("", "");
            kimura(naoconsegue: "aa", moises: "bb");
            kimura(moises: "bb", naoconsegue: "aa");
        }

        static int Multiplicar(int x = 5, int y = 10)
        {
            return x * y;
        }



        public static void kimura(string moises, string naoconsegue)
        {

        }

    
    }
}
