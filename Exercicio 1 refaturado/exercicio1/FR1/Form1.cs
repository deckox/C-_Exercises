using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_retorno.Text = string.Empty;
        }

        public string Tabuada (int numero)
        {
            var resultado = "";

            for (var i = 1; i <= 10; i++)
            {
                var tabuada = numero * i;

                resultado = resultado + numero + " " + "x" + " " + i + " = " + tabuada + "\n" ;
            }

            return resultado;
        }



        private void btn_geraTabuada_Click(object sender, EventArgs e)
        {
            var tabuadaNumero = txt_tabuada.Text;

            try
            {
                txt_retorno.Text = Tabuada(int.Parse(tabuadaNumero));
            }
            catch (Exception)
            {
                MessageBox.Show("Valor inválido!");
                txt_tabuada.Text = "";
                txt_tabuada.Focus();
            }
            
        }
    }
}
