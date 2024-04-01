using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomatoria_Click(object sender, EventArgs e)
        {
            var numeroinformado = int.Parse(campoNumero.Text);
            var indice = 1;
            retorno.Text = "";
            var resultado = 0;

            while (numeroinformado >= indice)
            {
                resultado = resultado + numeroinformado;

                if (numeroinformado == 1)
                {
                    retorno.Text = retorno.Text + numeroinformado + " = " + resultado;
                    numeroinformado--;
                }

                else
                {
                    retorno.Text = retorno.Text + numeroinformado + " " + " + ";
                    numeroinformado--;
                }
            }
        }

        /*4) Crie uma aplicação que ira Ler um numero do usuário e apresentar a somatoria 
         * do mesmo utilizando o comando de laço WHILE.*/
    }
}
