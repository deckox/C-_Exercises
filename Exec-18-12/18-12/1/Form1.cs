using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
   
    public partial class Form1 : Form
    {
        List<int> ListadeNumeros;
        public Form1()
        {
            InitializeComponent();

            ListadeNumeros = new List<int>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var numeroInformado = int.Parse(campotexto.Text);

            ListadeNumeros.Add(numeroInformado);

            campotexto.Text = "";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            var media = 0;

            for (var i = 0; i < ListadeNumeros .Count; i++)
            {
                media = media + ListadeNumeros[i];
            }

            ListadeNumeros.Sort();

            listBox1.Items.Add("O menor numero da lista é: " + ListadeNumeros[0]);
            listBox1.Items.Add("O maior numero da lista é: " + ListadeNumeros[ListadeNumeros.Count - 1]);
            listBox1.Items.Add("A media dos numeros da lista é: " + media / ListadeNumeros.Count);
        }
    }


    /*1) Crie uma aplicação que leia 10 numeros do usuario e informar qual o menor, o maior e a media
		ex: Usuario informa 1,2,3,4,5,6,7,8,9,10
		resultado esperado :
			Menor numero: 1
			Maior Numero: 10
			Media: 5  
		obs: a media é calculada pela soma de todos os numeros dividido pela quantidade (no caso 10).
     */
}
