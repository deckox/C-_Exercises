using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ValorProduto
{
    public partial class Form1 : Form
    {
        List<Produto> ValoresProdutos;

        public Form1()
        {
            InitializeComponent();
            ValoresProdutos = new List<Produto>();
            label_retorno.Text = "";

        }

        public class Produto
        {
            public int Quantidade { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }


            public decimal Total
            {
                get
                {
                    try
                    {
                        return Preco * Quantidade;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }

                }
            }

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Adicionar(int quantidade, string nome, decimal preco)
        {
            var produto = new Produto();
            produto.Quantidade = quantidade;
            produto.Nome = nome;
            produto.Preco = preco;

            ValoresProdutos.Add(produto);
        }

        public decimal Calculo()
        {
            var total = ValoresProdutos.Sum(_ => _.Total);
            return total;
            /*
            decimal retorno = 0;

            for (var i = 0; i < ValoresProdutos.Count; i++)
            {
                retorno = retorno + ValoresProdutos[i].Total;
            }

            return retorno;
            */
        }


        private string FormataResultado(int quantidade, string nome, decimal preco)
        {

            return string.Format("({0}) {1} R$ {2} \n", quantidade, nome, preco);
            //return "(" + quantidade + ") " + nome + " R$ " + preco + "\n";
        }

        public void PrintaNaTela()
        {
            for (var i = 0; i < ValoresProdutos.Count; i++)
            {
                //label_retorno.Text = label_retorno.Text + "(" + ValoresProdutos[i].Quantidade + ") " + ValoresProdutos[i].Nome + " R$ " + ValoresProdutos[i].Preco + "\n";
                label_retorno.Text = label_retorno.Text + FormataResultado(ValoresProdutos[i].Quantidade,ValoresProdutos[i].Nome, ValoresProdutos[i].Preco );
            }

            var totalGeral = Calculo();

            label_retorno.Text = label_retorno.Text + "Total:" + totalGeral;
        }

        public void LimparCampo()
        {
            txt_produto.Text = "";
            txt_quantidade.Text = "";
            txt_valor.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var qtd = int.Parse(txt_quantidade.Text);
                var nomeProduto = txt_produto.Text;
                var valor = decimal.Parse(txt_valor.Text);

                Adicionar(qtd, nomeProduto, valor);
                LimparCampo();
            }
            catch (Exception)
            {
                MessageBox.Show("Numero inválido! / Campo não pode estar vazio");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintaNaTela();
            }
            catch (Exception)
            {
                MessageBox.Show("Numero inválido!");
            }

        }


    }
}
