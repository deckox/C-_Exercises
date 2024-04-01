using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        List<int> ListaNumeros;
        public Form1()
        {
            InitializeComponent();
            ListaNumeros = new List<int>();
            label1.Text = "";
        }

        public void AdicionarNumeros(string valor)
        {
            var numero = int.Parse(valor);
            ListaNumeros.Add(numero);
            txt_campo.Text = "";
            txt_campo.Focus();
        }

        public string Ordernacao()
        {
            var resultado = "";
     

            for (var i = 0; i < ListaNumeros.Count; i++)
            {
                for (int j = i + 1; j < ListaNumeros.Count; j++)
                {
                    var nome1 = ListaNumeros[i];
                    var nome2 = ListaNumeros[j];

                    if (nome1 > nome2)
                    {
                        ListaNumeros[i] = nome2;
                        ListaNumeros[j] = nome1;
                    }
                }
               
                resultado = resultado + ListaNumeros[i] + "\n";
            }

       

            return resultado;
        }

        private void btn_numeros_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarNumeros(txt_campo.Text);

                if (ListaNumeros.Count == 10)
                {
                    label1.Text = Ordernacao();
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Numero invalido!");
            }
        
        }
    }
}
