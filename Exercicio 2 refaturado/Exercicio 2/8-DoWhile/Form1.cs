using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        public int CalculoSomatoria (int num)
        {
            var indice = 0;
            var resultado = num;

            do
            {
                resultado = resultado + indice;
                indice++;

            } while (num > indice);

            return resultado;
        }

        public void Exibir(int valor)
        {
            var valorCampo = valor;
            var resultado =  CalculoSomatoria(valor);
            label1.Text = "A somatoria de "  + valorCampo + " é " + resultado;
        }

        public void Erro()
        {
            MessageBox.Show("Numero invalido!");
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            try
            {
                var soma = int.Parse(textBox1.Text);
               
                Exibir(soma);
            }
            catch (Exception)
            {

                Erro();  
            }
           
           
        }
    }
}
