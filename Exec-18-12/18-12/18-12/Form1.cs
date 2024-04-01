using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tabuada_Click(object sender, EventArgs e)
        {
            //var coluna1 = 0;
            //retorno.Text = "";
            lstTabuada.Items.Clear();


            for (var i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var resultado = i * j;
                    //retorno.Text = retorno.Text + "\n" + i + " " + " x " + j + " = " + resultado;
                    lstTabuada.Items.Add(i + " " + " x " + j + " = " + resultado);

                }
                //retorno.Text = retorno.Text + "\n";
                lstTabuada.Items.Add("------------------");
            }

            //retorno.Text = retorno.Text;
        }
    }
}

/*) Crie um programa que ira printar a tabuada de todos os numeros de 1 a 10, utilizar um for/while dentr do outro.
Ex:
		1x1 = 1
		1x2 = 2
		...
		1x10 =10
		
		2x1 = 2
		2x2 = 2
		...
		2x10 = 20
		
		...
		
		10x1 = 10
		...
		10x10 = 100
*/