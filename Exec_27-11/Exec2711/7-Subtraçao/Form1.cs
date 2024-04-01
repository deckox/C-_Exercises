using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Subtraçao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var campoTexto = int.Parse(textBox1.Text);
            //var retornoTexto = retorno.Text;
            //var resultado = 0;
            retorno.Text = "Não consegue né moises?!";



            var primeiroNumero = campoTexto;
            for (var segundoNumero = 1; segundoNumero <= campoTexto; segundoNumero++)
            {
                //for (var j = campoTexto; j >= 1; j--)
                //{
                var resultado = (primeiroNumero - segundoNumero);
                retorno.Text = retorno.Text + "\n" + primeiroNumero + " - " + segundoNumero + " = " + resultado;
                primeiroNumero--;
                //resultado = resultado - (j - i);
                //}
            }

        }
    }
}


/*

    5 


     5 - 1 = 4
     4 - 2 = 2
     3 - 3 = 0
     2 - 4 = -2
     1 - 5 = -4

 * */
