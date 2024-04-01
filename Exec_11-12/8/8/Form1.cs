using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            var texto = textBox1.Text;
            var contrarioTexto = "";

            for (var i = texto.Length - 1; i >= 0; i--)
            {
                contrarioTexto = contrarioTexto + texto.Substring(i, 1);
            }

            retorno_text.Text = contrarioTexto;
        }
    }
}

/*
 * 8) Crie uma aplicação que irá ler uma frase do usuario e escrever a mesma de tras para frente.
	  ex: teste da frase
	  resultado: esarf ad etset	*/		
	
