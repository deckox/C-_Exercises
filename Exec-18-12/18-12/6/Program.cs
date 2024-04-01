using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {


        public static void Kimura()
        {
            var ListadeNumerosInformados = new List<int>();
            Console.Write("============================================================================" + "\n");
            Console.Write("      Insira quantidade de numeros desejados, digite 0 para operações       " + "\n");
            Console.Write("============================================================================" + "\n\n");

            var operacao = "";
            while (operacao != "sair")
            {
                var resultado = 0;
                var opcao = "";

                while (opcao != "0")
                {
                    try
                    {
                        Console.WriteLine("Digite o numero desejado ou digite 0 para operações: ");
                        opcao = Console.ReadLine();

                        if (opcao == "sair")
                        {
                            Environment.Exit(0);
                        }

                        if (opcao != "0")
                        {
                            ListadeNumerosInformados.Add(int.Parse(opcao));
                        }

                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Valor inválido! \n");
                    }


                }

                Console.Write("Escolha uma operação: somar, multiplicar, media, maximo, minimo, sair: ");
                operacao = Console.ReadLine();

                while (operacao != "somar" && operacao != "multiplicar" && operacao != "media" && operacao != "maximo" && operacao != "minimo" && operacao != "sair")
                {
                    Console.Write("Valor inválido! \n");
                    Console.Write("Escolha uma operação: somar, multiplicar, media, maximo, minimo, sair: ");
                    operacao = Console.ReadLine();
                }


                if (operacao == "multiplicar")
                {
                    resultado = 1;
                }
                else
                    resultado = 0;


                for (int i = 0; i < ListadeNumerosInformados.Count; i++)
                {

                    if (operacao == "somar")
                    {
                        resultado = resultado + ListadeNumerosInformados[i];
                    }

                    if (operacao == "multiplicar")
                    {

                        resultado = resultado * ListadeNumerosInformados[i];
                    }

                    if (operacao == "media")
                    {
                        resultado = resultado + ListadeNumerosInformados[i];
                    }

                    if (operacao == "maximo")
                    {
                        ListadeNumerosInformados.Sort();
                        resultado = ListadeNumerosInformados[ListadeNumerosInformados.Count - 1];
                        break;
                    }

                    if (operacao == "minimo")
                    {
                        ListadeNumerosInformados.Sort();
                        resultado = ListadeNumerosInformados[0];
                        break;
                    }

                    if (operacao == "sair")
                    {
                        Environment.Exit(0);
                    }

                }

                if (operacao == "media")
                {
                    resultado = resultado / ListadeNumerosInformados.Count;
                }


                Console.WriteLine("\nO resultado da operação é: " + resultado);
                //Console.Read();
                ListadeNumerosInformados.Clear();
            }
        }



        
        public static int OperacaoSoma(List<int> listaDeNumeros)
        {
            return listaDeNumeros.Sum();
        }
        public static int OperacaoMultiplicacao(List<int> listaDeNumeros)
        {
            if (!listaDeNumeros.Any())
                return 0;

            var result = 1;
            foreach (var num in listaDeNumeros)
                result = result * num;

            return result;

        }
        public static int OperacaoMedia(List<int> listaDeNumeros)
        {
            if (!listaDeNumeros.Any())
                return 0;

            return (int)listaDeNumeros.Average();
        }
        public static int OperacaoMaximo(List<int> listaDeNumeros)
        {
            if (!listaDeNumeros.Any())
                return 0;

            return listaDeNumeros.Max();
        }
        public static int OperacaoMinimo(List<int> listaDeNumeros)
        {
            if (!listaDeNumeros.Any())
                return 0;

            return listaDeNumeros.Min();
        }
        public static List<int> OperacaoAdicionarNumeroNaLista(string operacao, List<int> listaDeNumeros)
        {
            try
            {
                var num = int.Parse(operacao);
                listaDeNumeros.Add(num);
            }
            catch (Exception)
            {
                Console.WriteLine("( {0} ) Opção ou numero inválido!", operacao);
            }

            return listaDeNumeros;
        }

        public static void OperacaoSair()
        {
            Environment.Exit(0);
        }
        public static void EscreverCabecalho()
        {
            Console.WriteLine("");
            Console.WriteLine("============================================================================");
            Console.WriteLine("      Insira quantidade de numeros desejados, digite 0 para operações       ");
            Console.WriteLine("          Opções: somar, multiplicar, media, maximo, minimo, sair");
            Console.WriteLine("============================================================================");
            Console.WriteLine("");
        }
        public static void EscreverResultado(int resultado)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("O resultado da operação é: " + resultado);
            Console.WriteLine("--------------------------------------");

            EscreverCabecalho();
        }

        static void Main(string[] args)
        {
            //Kimura();
            EscreverCabecalho();

            var ListadeNumerosInformados = new List<int>();
            var operacao = "";
            while (operacao != "sair")
            {
                Console.Write("Digite o numero desejado ou a operação desejada: ");
                operacao = Console.ReadLine();

                var resultado = 0;
                switch (operacao.ToLower())
                {
                    case "somar":
                        resultado = OperacaoSoma(ListadeNumerosInformados);
                        EscreverResultado(resultado);
                        ListadeNumerosInformados.Clear();
                        break;
                    case "multiplicar":
                        resultado = OperacaoMultiplicacao(ListadeNumerosInformados);
                        EscreverResultado(resultado);
                        ListadeNumerosInformados.Clear();
                        break;
                    case "media":
                        resultado = OperacaoMedia(ListadeNumerosInformados);
                        EscreverResultado(resultado);
                        ListadeNumerosInformados.Clear();
                        break; 
                    case "maximo":
                        resultado = OperacaoMaximo(ListadeNumerosInformados);
                        EscreverResultado(resultado);
                        ListadeNumerosInformados.Clear();
                        break;
                    case "minimo":
                        resultado = OperacaoMinimo(ListadeNumerosInformados);
                        EscreverResultado(resultado);
                        ListadeNumerosInformados.Clear();
                        break;
                    case "sair":
                        OperacaoSair();
                        break;
                    default:
                        ListadeNumerosInformados = OperacaoAdicionarNumeroNaLista(operacao, ListadeNumerosInformados);
                        break;
                }

            }

        }

        /*6) Crie uma aplicação console application que deve ler numeros informados pelo usuário até que o mesmo 
         *informe um dos seguintes comandos:
        - somar, multiplicar, media, maximo, minimo, sair ok 
        - O programa deve efetuar a operação informada nos numeros fornecidos 
        - caso o usuario informe algum valor que nao seja um numero ou um dos comandos a aplciação deve
          informar o seguinte texto, "valor invalido", e pedir o proximo numero
        - apos exibir o resultado solicitado pelo usuario a aplicação deve zerar todos os dados armazenados e 
          voltar a pedir os numeros para uma nova operação assim como ao inicio
        - se o usuario informar o comando sair a aplicacao deve ser fechada - ok
         * */
    }
}
