using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {


        static void Main(string[] args)
        {

            // var nome1 = "Rafael";
            // var nome2 = "Kimura";
            // var nome3 = "Andre";


            //Metodos de comparação
            // var c = string.Compare(nome1, nome2); //Kimura  (1) string da direita
            // var d = string.Compare(nome3, nome2); //Andre  (-1) string da esquerda
            // var e = string.Compare(nome3, nome3); //0       (0) strings iguais
            //Metodos de comparação

            List<String> ListaNome = new List<string>();

            var emordem = "";
            var opcao = "";

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("*** Para efetuar iniciar a ordenação digite 0 ***");
            Console.WriteLine("_________________________________________________");

            while (opcao != "0")
            {
                Console.Write("Favor inserir um nome: ");
                opcao = Console.ReadLine();

                if (opcao.ToLower() != "0")
                    ListaNome.Add(opcao);

                Console.WriteLine("---------------------");
            }


            for (var i = 0; i < ListaNome.Count; i++)
            {
                for (var j = i + 1; j < ListaNome.Count; j++)
                {
                    var nome1 = ListaNome[i];
                    var nome2 = ListaNome[j];
                    var comparacao = string.Compare(nome1, nome2);

                    if (comparacao == 1)
                    {
                        ListaNome[i] = nome2;
                        ListaNome[j] = nome1;
                    }
                }

                emordem = emordem + ListaNome[i] + "\n";
            }

            Console.Write("Lista em ordem analfabetica: " + "\n" + emordem);
            Console.ReadLine();
        }
    }
}

/*6) Crie uma aplicação console application que deve ler 10 nomes e apresenta-los 
 * em ordem alfabetica sem utilizar order by. */

