using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        public string CalculoFahrenheit(int fahrenheit)
        {
            fahrenheit = int.Parse(Console.ReadLine());
            var celsius = (fahrenheit - 32) * 5 / 9;
            var resultado = fahrenheit + "º farhrenheit" + " in celsius is: " + celsius;
            
            return resultado;
        }

        static void Main(string[] args)
        {
           // var fahrenheit = int.Parse(Console.ReadLine());

            //CalculoFahrenheit(fahrenheit);

        }
    }
}
