using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        public string RetornaMes(int mes)
        {
            var resultado = "";
           

            switch (mes)
            {
                  case 1:
                        resultado = "Janeiro";
                        break;
                    case 2:
                        resultado = "Fevereiro" ;
                        break;
                    case 3:
                        resultado = "Março";
                        break;
                    case 4:
                        resultado = "Abril";
                        break;
                    case 5:
                        resultado = "Maio";
                        break;
                    case 6:
                        resultado = "Junho";
                        break;
                    case 7:
                        resultado = "Julho";
                        break;
                    case 8:
                        resultado = "Agosto";
                        break;
                    case 9:
                        resultado = "Setembro";
                        break;
                    case 10:
                        resultado = "Outubro";
                        break;
                    case 11:
                        resultado = "Novembro";
                        break;
                    case 12:
                        resultado = "Dezembro";
                        break;

                    default:
                        MessageBox.Show("Digite apenas de 1 a 12");
                        label1.Text = "";
                        textBox1.Text = "";
                        break;
            }

            return resultado;
        }

        public void Erro()
        {
            MessageBox.Show(" Digite apenas de 1 a 12");
            label1.Text = "";
        }

        public void Exibir(string mes)
        { 
                var exibemes = RetornaMes(int.Parse(mes));
                label1.Text = "O mes digitado é: " + exibemes;
            
        }

        private void btn_mes_Click(object sender, EventArgs e)
        {
            try
            {
                var mes = textBox1.Text;
                Exibir(mes);
            }
            catch (Exception)
            {

                Erro();
            }
         
        }
    }
}
