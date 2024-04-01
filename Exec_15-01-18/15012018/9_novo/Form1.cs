using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{


    public partial class Form1 : Form
    {

        public class Cartela
        {
            public string Nome { get; set; }
            public List<string> Numeros { get; set; }

            public Cartela()
            {
                Numeros = new List<string>();
            }
        }

        List<string> NumerosSaidos;
        public List<Cartela> Cartelas;


        public Form1()
        {

            InitializeComponent();
            label17.Text = "";
            label1.Text = "";

            NumerosSaidos = new List<string>();


            var cartela = GerarCartelaRandomica();

        }


        private string GerarNumeroAleatorio(List<string> ListaDeExcecoes)
        {
            var random = new Random();
            var numero = "";
            while (numero == "")
            {
                var sorteado = random.Next(1, 100).ToString();
                if (!ListaDeExcecoes.Contains(sorteado))
                {
                    numero = sorteado;
                }
            }

            return numero;
        }

        private List<string> GerarCartelaRandomica()
        {
            const int totalNumerosDaCartela = 16;
            var cartela = new List<string>();

            while(cartela.Count < totalNumerosDaCartela)
            {
                var numero = GerarNumeroAleatorio(cartela);
                cartela.Add(numero);
            }

            return cartela;
        }


        private void btn_cartela_Click(object sender, EventArgs e)
        {

        }

        private void btn_bolatual_Click(object sender, EventArgs e)
        {

        }

        private void btn_geralbola_Click(object sender, EventArgs e)
        {
            var numeroGerado = GerarNumeroAleatorio(NumerosSaidos);
            NumerosSaidos.Add(numeroGerado);



            var numeroUtilizado = "";
            var indexColuna = 0;
            var maxColuna = 4;
            for (int i = 0; i < NumerosSaidos.Count; i++)
            {
                numeroUtilizado = numeroUtilizado + NumerosSaidos[i] + " , ";
                indexColuna++;
                if(indexColuna > maxColuna)
                {
                    numeroUtilizado += "\n";
                    indexColuna = 0;
                }

            }

            var ListaNumerodaCartela = label17.Text.ToList();

            if (label17.Text.Contains("x" + NumerosSaidos))
            {
                MessageBox.Show("Tem!");
            }

            label1.Text = numeroUtilizado;



            MarcarNumeroNaCartela(numeroGerado);
            //OU
            //ExibirCartelas();

        }

        private void MarcarNumeroNaCartela(string numeroGerado)
        {
            var numero = FormataLabelNumeroCartela(numeroGerado);
            var numeroMarcado = FormataLabelNumeroCartela(numeroGerado, true);

            label17.Text = label17.Text.Replace(numero, numeroMarcado);


            var ganhador = VerificarGanhador();
            if(ganhador != "")
            {
                MessageBox.Show(ganhador);
            }
        }
               

        private string VerificarGanhador()
        {
            var resultado = "";

            foreach (var cartela in Cartelas)
            {
                var ganhou = true;
                foreach (var numero in cartela.Numeros)
                {
                    if (!NumerosSaidos.Contains(numero))
                    {
                        ganhou = false;
                        break;
                    }
                }
                if(ganhou)
                {
                    resultado += cartela.Nome +  " Ganhou";
                }
            }




                return resultado;
        }

        private void ExibirCartelas()
        {
            label17.Text = "";

            var cartelaExibicao = "";
            var usuario = 1;
            foreach(var cartela in Cartelas)
            {

                cartelaExibicao += cartela.Nome + "\n";
                usuario++;

                var indexColuna = 0;
                foreach(var numero in cartela.Numeros)
                {
                    if(indexColuna == 4)
                    {
                        cartelaExibicao += "\n";
                        indexColuna = 1;
                    }
                    else
                    {
                        indexColuna++;
                    }


                    if(NumerosSaidos.Contains(numero))
                        cartelaExibicao += FormataLabelNumeroCartela(numero, true);
                    else
                        cartelaExibicao += FormataLabelNumeroCartela(numero);

                }

                cartelaExibicao += "\n------------------------------------------------------------\n";
            }

            label17.Text += cartelaExibicao;
        }



        private string FormataLabelNumeroCartela(string numero, bool marcado = false)
        {
            var numeroExibido = numero.Length == 2 ? numero :  numero;
            if (marcado)

                return "[x" + numeroExibido + " ]";
            else
                return "[ " + numeroExibido + " ]";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Cartelas == null)
                Cartelas = new List<Cartela>();


            var cartelaGerada = GerarCartelaRandomica();

            var cartela = new Cartela();
            cartela.Numeros = cartelaGerada;

            cartela.Nome = "Cartela do Usuario " + (Cartelas.Count() + 1) + " Gerada as " + DateTime.Now.ToLongTimeString();
            Cartelas.Add(cartela);

            ExibirCartelas();

        }

    }
}
