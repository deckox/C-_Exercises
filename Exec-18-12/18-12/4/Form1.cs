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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomatoria_Click(object sender, EventArgs e)
        {
            try
            {
                var numeroSomatoria = int.Parse(campoTexto.Text);
                retorno.Text = "";
                var resultado = 0;

                for (var i = numeroSomatoria; i >= 1; i--)
                {
                    resultado = resultado + i;

                    if (i != 1)
                    {
                        retorno.Text = retorno.Text + i + " " + " + ";
                    }

                    else
                    {
                        retorno.Text = "O resultado da somatória é: \n\n" + retorno.Text + i + " = " + resultado;
                    }
                }
            }

            catch(Exception)
            {
                MessageBox.Show("O campo não pode ser em branco e somente numeros!");
            }
        }

    /*5) Crie uma aplicação que ira Ler um numero do usuário e apresentar a somatoria do mesmo 
     * utilizando o comando de laço FOR.
     * ex: usuario informa 5
     * aplicação apresenta:
     * 5 + 4 + 3 + 2 + 1 = 15 */
    }
}
