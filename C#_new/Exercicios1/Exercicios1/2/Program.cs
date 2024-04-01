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
            var numerotabuada = int.Parse(Console.ReadLine());
            var de = int.Parse(Console.ReadLine());
            var ate = int.Parse(Console.ReadLine());
            var resultadoTabuada = 0;
            

            for (var i = de; i <= ate; i++)
            {
                resultadoTabuada = i * numerotabuada;
                Console.WriteLine(numerotabuada + "x" + i + "=" + resultadoTabuada);
            }

            Console.ReadKey();
        }
    }
}
