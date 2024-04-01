using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? mentos = null;
            int mentosDisponiveis = mentos ?? 0;

            Console.WriteLine("Quantidade de Mentos disponiveis: " + mentosDisponiveis);
            Console.Read();
        }
    }
}
