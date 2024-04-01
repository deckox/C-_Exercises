using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcula_Click(object sender, EventArgs e)
        {
            try
            {
                var numero1 = int.Parse(textBox1.Text);
                var numero2 = int.Parse(textBox2.Text);

                var soma = numero1 + numero2;
                var subtracao = numero1 - numero2;
                var multiplicacao = numero1 * numero2;
                var divisao = numero1 / numero2;

                retorno.Text = "Os resultados são: " + "\n" + "\n" + numero1 + " + " + numero2 + "=" + soma + "\n" + numero1 + " - " + numero2 + " = " + subtracao + "\n" + numero1 + " * " + numero2 + " = " + multiplicacao + "\n" + numero1 + " / " + numero2 + " = " + divisao;
             }

            catch (Exception)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
        }
    }

    /* Crie uma aplicação que irá ler 2 numeros e apresentar o resultado
     * das 4 operações com os mesmos(soma, subtração, divisao e multiplicação)           
     Ex:
     Usuário informa:
      
     6 e 2
     Aplicação deve apresentar:
     6 + 2 = 8
     6 - 2 = 4
     6 x 2 = 12
     6 / 2 = 3 */
}
