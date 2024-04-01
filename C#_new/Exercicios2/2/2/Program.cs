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

            var celsius = int.Parse(Console.ReadLine());
            var fahrenheit = (9 * celsius + 160) / 5;
             
            Console.WriteLine(celsius + "º Celsius" + " in farhrenheit is: " + fahrenheit);
            Console.ReadKey();


        }
    }
}
