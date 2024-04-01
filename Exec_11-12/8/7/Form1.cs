using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {

            var campoTexto = textBox1.Text;
            var insere = "";

            for (var i = 0; i <= campoTexto.Length; i += 3)
            {
                if (i > campoTexto.Length - 1)
                {
                    break;
                }

                if (i >= campoTexto.Length - 1)
                {
                    insere += campoTexto.Substring(i, 1);
                }

                else
                {
                    insere += campoTexto.Substring(i, 3) + ".";
                }
            }

            retorno.Text = insere;
            textBox1.Text = "";
        }

        /* 7) Crie uma aplicação que irá ler uma frase do usuario e inserir . entre as letras a cada 3 caracteres. 
        */
    }
}
