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

        private void btn_frase_Click(object sender, EventArgs e)
        {
            var campo = textBox1.Text;

            retorno.Text = "A frase contém " + campo.Length + " caractéres." + "\n" + "Os 3 primeiros caractéres são: " + campo.Substring(0, 3) + "\n" + "Os ultimos 5 caracteres são: " + campo.Substring(campo.Length -5, 5);
        }
    }
}
