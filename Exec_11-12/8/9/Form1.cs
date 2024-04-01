using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            
            var espaco = textBox1.Text.Replace(" " , "");
            retorno_text.Text = espaco;
            textBox1.Text = "";
        }
    }

    /*9) Crie uma aplicação que irá ler uma frase do usuario e apresentar a mesma sem nenhum espaço
     * 
     */
}
