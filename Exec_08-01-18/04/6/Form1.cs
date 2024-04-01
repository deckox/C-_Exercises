using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace _6
{
    public partial class Form1 : Form
    {
        public static List<string> ListaDeNomes;

        public Form1()
        {
            InitializeComponent();
            ListaDeNomes = new List<string>();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            label_salvo.Text = "";
            var campoTexto = textBox1.Text;

            if (textBox1.Text != string.Empty)
            {
                ListaDeNomes.Add(campoTexto);
                textBox1.Text = string.Empty;

                var lista = PesquisaLINQ(ListaDeNomes);
                ExibirResultado(lista);
                label_salvo.Text = campoTexto + " salvo com sucesso!";

            }
            else
            {
                label_salvo.Text = "";
            }

        }

        /*
        class Aluno
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string CPF { get; set; }
            public int Idade { get; set; }
            public bool Ativo { get; set; }
        }


        class Matricula
        {
            public string CPF { get; set; }
            public string NumeroMatricula { get; set; }
            public string Classe { get; set; }
            public bool Ativo { get; set; }
        }
        */


        public List<string> PesquisaLINQ(List<string> Lista, string busca = "")
        {
            /*
            var ListaDeAlunos = new List<Aluno>();
            var ListaDeMatriculas= new List<Matricula>();

            var resultadoteste = from aluno in ListaDeAlunos
                                 join mat in ListaDeMatriculas on aluno.CPF equals mat.CPF
                                 
                                 where  aluno.Idade > 30  && aluno.Ativo && mat.Ativo
                                 select mat;

            */
            //var resultado2 = from nome in ListaDeNomes
            //where string.IsNullOrEmpty(busca) || nome.Contains(busca)
            //select nome;


            //return resultado2.ToList();


            var resultado = ListaDeNomes.Where(nome => string.IsNullOrEmpty(busca) || nome.Contains(busca)).ToList();
            return resultado;




            /*
            var ListaDeAlunos = new List<Aluno>();

            var resultado = from aluno in ListaDeAlunos where aluno.Nome == "Rafael" && aluno.Idade > 30 select aluno;
            var resultado2 = ListaDeAlunos.Where(aluno => aluno.Nome == "Rafael" && aluno.Idade > 30).ToList();
            var resultado3 = ListaDeAlunos.Where(aluno => aluno.Nome == "Rafael").Where(_=>  _.Idade > 30).ToList();


            var todosAlunosAtivos = ListaDeAlunos.Where(_=> _.Ativo).ToList(); //Lista do tipo Objeto Aluno
            var todosNomesAlunosAtivos = ListaDeAlunos.Where(_ => _.Ativo).Select(_=>_.Nome).ToList(); //Lista de String




            var primeiroAlunoAtivo = ListaDeAlunos.First(_ => _.Ativo);
            var ultimoAlunoAtivo = ListaDeAlunos.Last(_ => _.Ativo);



            return "";
            */
        }

        public List<string> PesquisaSequencial(List<string> Lista, string busca)
        {
            var resultado = "";
            var listaFiltrada = new List<string>();

            for (int i = 0; i < ListaDeNomes.Count(); i++)
            {
                if (ListaDeNomes[i].ToLower().Contains(busca.ToLower()))
                {
                    listaFiltrada.Add(ListaDeNomes[i]);
                    //resultado = resultado + ListaDeNomes[i] + "\n";
                }
            }

            //label_retorno.Text = resultado;

            return listaFiltrada;
        }

        public string PesquisaBinario(List<string> Lista, string busca)
        {
            ListaDeNomes.Sort();
            var indexLocalizado = -1;

            var limiteInferior = 0;    
            int limiteSuperior = ListaDeNomes.Count - 1;
            int meio;

            while (limiteInferior <= limiteSuperior)
            {
                meio = (limiteInferior + limiteSuperior) / 2;
                if (busca == Lista[meio])
                    indexLocalizado =  meio;
                if ( string.Compare(busca, Lista[meio]) == -1)
                    limiteSuperior = meio - 1;
                else
                    limiteInferior = meio + 1;
            }

            var resultado = "";
            if (indexLocalizado > -1)
                resultado = Lista[indexLocalizado];


            return resultado;



            //do {

            //var comparacao = string.Compare(ListaDeNomes[Min], ListaDeNomes[Meio]);
            //var comparacao2 = string.Compare(ListaDeNomes[Meio], ListaDeNomes[Max]);

            /* if ()
             {
                 //Retorna a posição do número na seqüencia.
                 resultado += ListaDeNomes[Meio];
                 Min = Meio + 1;
             }

             else if (!ListaDeNomes[Meio].Contains(busca))
                   Max = Meio + 1;  
             else
                 Max = Meio - 1;
        */

            //} while (Min <= Max);


        }

        /*  do
       {
     meio = (int) (Min + Max) / 2;
       if (vetor[meio] == numeroin)
           {
           //Retorna a posição do número na seqüencia.
           return meio;
           }
       else if (chave > vetor[meio])
           Min = meio + 1;
       else
           Max = meio - 1;
       }
   while (Min <= Max);*/

        private void ExibirResultado(List<string> lista)
        {
            label_retorno.Text = "";
            foreach (var item in lista)
            {
                label_retorno.Text += item + "\n";
            }
        }

        private void btnBuscarLinq_Click(object sender, EventArgs e)
        {
            var busca = textBox1.Text;
            var listaFiltrada = PesquisaLINQ(ListaDeNomes, busca);
            ExibirResultado(listaFiltrada);
        }

        private void btnBuscarSequencial_Click(object sender, EventArgs e)
        {
            var busca = textBox1.Text;
            var listaFiltrada =  PesquisaSequencial(ListaDeNomes, busca);
            ExibirResultado(listaFiltrada);
        }

        private void btnBuscarBinario_Click(object sender, EventArgs e)
        {
            var busca = textBox1.Text;
            var resultado = PesquisaBinario(ListaDeNomes, busca);
            label_retorno.Text = resultado;
        }
    }
}

/*
 * 

7) Qual a diferença entre o algoritimo de busca Sequencial e busca binaria? Qual é mais eficiente? 
	
8) Modifique o programa anterior adicionando um novo botão "Pesquisar Sequencial" para fazer a mesma busca utilizando um 
algoritimo de busca sequencial(percorrendo a lista com um loop).

9) Modifique o programa anterior adicionando um novo botão "Pesquisar Binaria" para fazer a mesma busca utilizando
um algoritimo de busca binaria (pesquisar a respeito).

10) Modifique o programa anterior, para que nos 3 botões a busca não seja feita pelo texto exato e sim por 
parte do texto.
	-Ex: busca por "ae"
		Retorna Rafael, Raphael, Michael, ...

    */
