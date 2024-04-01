using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        /* public int Calculofatorial(int numero)
         {
             var resultado = 1;


             for (var i = 1; i <= numero; i++)
             {
                 resultado = resultado * i;
             } 

             return resultado;

         }*/

        public string Calculofatorial(int numero)
        {
            var resultado = 1;
            var retorno = numero + "! = ";


            for (var i = numero; i >= 1; i--)
            {
                resultado = resultado * i;

                var sinal = (i > 1 ? " x " : " = ");
                retorno = retorno + i + sinal;
            }

            retorno = retorno + resultado;

            return retorno;

        }

        private void btn_fatorial_Click(object sender, EventArgs e)
        {
            try
            {
                var numeroFatorial = int.Parse(textBox1.Text);

                label1.Text = Calculofatorial(numeroFatorial).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Numero invalido!");
            }
         
        }
    }

    /*
     3) Fatorial
	FR.1  Usuario ira informar um numero e o programa devera exibir o seu fatorial, ou seja a soma da multiplicação de um número (n) vezes, onde n é o número lido.
	ex: usuario informa 5
	resultado esperado :
		5! =  120
     */
}
