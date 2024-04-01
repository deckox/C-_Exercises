using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR3
{
    public partial class Form1 : Form
    {
        List<int> ListaNumeros;
        public Form1()
        {
            InitializeComponent();
            ListaNumeros = new List<int>();
            label1.Text = "Adicione 10 numeros! \n";
        }

        public string Calcular()
        {
            var menor = 0;
            var soma = 0;
            var media = 0;
            var maior = 0;

            ListaNumeros.Sort();
            soma = ListaNumeros.Sum();

            menor = ListaNumeros.First();
            media = soma / ListaNumeros.Count;
            maior = ListaNumeros.Last();
            var resultado = "O menor numero é: " + menor + "\n" + "O maior numero é: " + maior + "\n" +
           "A media de todos é: " + media;

            return resultado;
        }

        public void LimpaCampo()
        {
            txt_campo.Text = "";
            txt_campo.Focus();
        }


        private void AdicionarNumero(string numero)
        {
            try
            {
                var insereNumero = int.Parse(numero);
                ListaNumeros.Add(insereNumero);

                label1.Text = label1.Text + " " + numero;
                LimpaCampo();
            }
            catch (Exception)
            {
                MessageBox.Show("Numero invalido!");
            }

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarNumero(txt_campo.Text);

                if (ListaNumeros.Count == 10)
                {
                    LimpaCampo();
                    label1.Text = Calcular();
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Permitido apenas numeros!");
            }

        }
    }


    /*
    public partial class Form1 : Form
    {
        List<int> ListaNumeros = new List<int>();
        public Form1()
        {
            InitializeComponent();
            ListaNumeros = new List<int>();
            label1.Text = "";
        }

        public string Adiciona10Numeros(int estatistica)
        {
           
            var menor = 0;
            var media = 0;
            var maior = 0;

            var resultado = label1.Text = "Adicione 10 numeros!";

            if (ListaNumeros.Count <= 10)
            {
                ListaNumeros.Add(estatistica);
            }

            else
            {
                for (var i = 0; i < ListaNumeros.Count; i++)
                {
                    media = media + ListaNumeros[i];
                }

                ListaNumeros.Sort();


                menor = ListaNumeros[0];
                media = media / ListaNumeros.Count;
                maior = ListaNumeros[9];
                resultado = "O menor numero é: " + menor + "\n" + "O maior numero é: " + maior + "\n" +
               "A media de todos é: " + media;

            }

            return resultado;
        }

        public void LimpaCampo()
        {
            txt_campo.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var insereNumero = int.Parse(txt_campo.Text);

                label1.Text = Adiciona10Numeros(insereNumero);
                LimpaCampo();
            }

            catch (Exception)
            {
                MessageBox.Show("Permitido apenas numeros!");
            }

        }
    }

    /*
     2) Estatistica:
	 FR.1 Ler 10 numeros do usuario e informar qual o menor, o maior e a media
		ex: Usuario informa 1,2,3,4,5,6,7,8,9,10
		resultado esperado :
			Menor numero: 1
			Maior Numero: 10
			Media: 5  
	 obs: a media é calculada pela soma de todos os numeros dividido pela quantidade (no caso 10).
     */
}

