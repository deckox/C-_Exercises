using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CleanFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = String.Empty;
        }


        private void WriteNewFile(string content)
        {
            var produtos = File.Open(@"C:\Workspace\cadastros.txt", FileMode.Create); //abre arquivo
            var escritor = new StreamWriter(produtos); // instancia para escrever
            escritor.WriteLine(content); //escreve
            escritor.Close();
            produtos.Close();
        }

        private void WriteProducts(string codigo, string nome, string categoria, int quantidade, int preco)
        {
            var produtos = File.Open(@"C:\Workspace\cadastros.txt", FileMode.Append); //abre arquivo
            var escritor = new StreamWriter(produtos); // instancia para escrever
            escritor.Write(codigo + ";" + nome + ";" + categoria + ";" + quantidade + ";" + preco + ";" + "\n"); //escreve
            escritor.Close();
            produtos.Close();
        }

        private void ChangeProducts(string codigo, string nome, string categoria, int quantidade, int preco)
        {
            var produtos = File.Open(@"C:\Workspace\cadastros.txt", FileMode.Create); //abre arquivo
            var escritor = new StreamWriter(produtos); // instancia para escrever
            escritor.Write(codigo + ";" + nome + ";" + categoria + ";" + quantidade + ";" + preco + ";" + "\n"); //escreve
            escritor.Close();
            produtos.Close();
        }


        private void WriteProducts(List<string> products)
        {
            var conteudo = String.Join("\n", products);
            WriteNewFile(conteudo);
        }

        private string ReadProducts()
        {

            Stream produtos = File.Open(@"C:\Workspace\cadastros.txt", FileMode.Open); //abre arquivo
            StreamReader leitor = new StreamReader(produtos); // instancia para ler
            var arquivo = leitor.ReadToEnd(); // le arquivo
            leitor.Close();
            produtos.Close();

            return arquivo;

        }

        public void EraseProducts(string Login)
        {

            Stream produtos = File.Open(@"C:\Workspace\cadastros.txt", FileMode.Create); //abre arquivo
            StreamReader leitor = new StreamReader(produtos); // instancia para ler
            var arquivo = leitor.ReadToEnd(); // le arquivo
            leitor.Close();
            produtos.Close();


        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = textBox1.Text;
                var nome = textBox2.Text;
                var categoria = textBox3.Text;
                var quantidade = int.Parse(textBox4.Text);
                var preco = int.Parse(textBox5.Text);


                var arquivo = ReadProducts();
                var campoPesquisa = textBox6.Text;
                var listaProdutos = arquivo.Split('\n').ToList();
                var achou = false;


                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    var itensCadastrados = listaProdutos[i];
                    var separaItens = itensCadastrados.Split(';').ToList();

                    if (codigo == separaItens[0])
                    {
                        listaProdutos.RemoveAt(i);
                        achou = true;
                        break;
                    }

                }

                if (achou)
                {
                    WriteProducts(listaProdutos);
                    WriteProducts(codigo, nome, categoria, quantidade, preco);
                }

                if (!achou)
                {
                    WriteProducts(codigo, nome, categoria, quantidade, preco);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("O campo não pode ser em branco!");
            }

            CleanFields();




        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            var arquivo = ReadProducts();
            var campoPesquisa = textBox6.Text;
            var listaProdutos = arquivo.Split('\n').ToList();
            var achou = false;

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                var itensCadastrados = listaProdutos[i];
                var separaItens = itensCadastrados.Split(';').ToList();

                if (campoPesquisa == separaItens[0])
                {
                    achou = true;
                    textBox1.Text = separaItens[0];
                    textBox2.Text = separaItens[1];
                    textBox3.Text = separaItens[2];
                    textBox4.Text = separaItens[3];
                    textBox5.Text = separaItens[4];
                    break;
                }
            }

            if (!achou)
            {
                MessageBox.Show("Não consegue achar moises!");
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var arquivo = ReadProducts();
            var campoPesquisa = textBox6.Text;
            var listaProdutos = arquivo.Split('\n').ToList();

            var achou = false;
            for (int i = 0; i < listaProdutos.Count; i++)
            {
                var itensCadastrados = listaProdutos[i];
                var separaItens = itensCadastrados.Split(';').ToList();

                if (campoPesquisa == separaItens[0])
                {
                    listaProdutos.RemoveAt(i);
                    achou = true;
                    break;
                }
            }

            if (achou)
            {
                WriteProducts(listaProdutos);
                MessageBox.Show("Produto excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto " + campoPesquisa + " não localizado!");
            }

            CleanFields();
        }
    }
}

/*7) Crie uma aplicação que ira cadastrar produtos.
	 Deve conter os campos: Codigo, nome, categoria, quantidade e preço
	 Deve conter os seguintes botoes: Cadastrar, Limpar
	
	Ao clicar em limpar deve limpar todos os campos
	Ao clicar em cadastrar deve salvar o produto em uma linha de um arquivo texto, com os dados separados por ;
		ex: produtos.txt
			001;Big Mac;lanche;100;50;
			002;Coca-Cola;bebida;500;50;

8) No programa anterior adicione um campo para busca  (campo texto para digitar o codigo do produto e um botao pesquisar)
	Ao digitar o codigo a aplicação deve procurar no arquivo texto se o produto existe, se existir preencher os campos com os dados do mesmo
	Se nao existir deve exibir mensagem dizendo que o produto nao existe


9) No programa anterior cado o usuario tente cadastrar um produto com o codigo igual a um já cadastrado o mesmo deve ser atualizado 
para os novos dados fornecidos


10) No programa anterior Adicionar o botao de excluir para remover do arquivo de texto o produto pesquisado.

*/
