using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var val1 = int.Parse(textBox1.Text);
            var val2 = int.Parse(textBox2.Text);

            var media = (val1 + val2) / 2;

            retorno.Text = media.ToString();
        }
    }

    /*10) Crie uma aplicação que leia dois números nas variáveis Val1 e Val2, 
      calcule sua média na variável Media e imprima seu valor.*/
}
