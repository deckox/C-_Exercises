using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }



        public string GetImagemTemperatura(int temperatura)
        {
            if (temperatura >= 86)
            {
                return "https://pm1.narvii.com/6346/baecd622ba4ff6667a73100040e2ac3b2aeb8e55_hq.jpg";
            }
            else if (temperatura <= 50)
            {
               return "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfaOvMJKOBSSO10foY4GlLaA1yJ0Ib2UoWw5T9euSDkn4E3HD1";
            }
            else
            {
               return "https://vignette.wikia.nocookie.net/dragonball/images/7/74/ShenronDBZep240.png/revision/latest/scale-to-width-down/301?cb=20150116162138&path-prefix=pt-br";
            }
        }

        public int CalculoCelsius(string valor)
        {
            var fahrenheit = int.Parse(valor);
            var celcius = (fahrenheit - 32) * 5 / 9;
            return celcius;
        }

        public void ExibirResultado(int temperatura, string imagem)
        {
            label1.Text = "Fahrenheit convertido em Celsius é: " +  temperatura;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(imagem);
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                var temperatura = CalculoCelsius(txt_Celsius.Text);
                var imagem = GetImagemTemperatura(temperatura);
                ExibirResultado(temperatura, imagem);
            }

            catch (Exception)
            {

                MessageBox.Show("Numero invalido!");
            }

           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
