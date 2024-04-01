using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        public string CalculoFahrenheit()
        {
            var resultado = "";


            var campoCelsius = int.Parse(txt_Fahrenheit.Text);

            resultado = "Celsius convertido em Fahrenheit é: " + (9 * campoCelsius + 160) / 5;

           
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
           

            if (campoCelsius >= 30)
            {
                pictureBox1.Load("https://pm1.narvii.com/6346/baecd622ba4ff6667a73100040e2ac3b2aeb8e55_hq.jpg");
            }

            else if (campoCelsius <= 10)
            {
                pictureBox1.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfaOvMJKOBSSO10foY4GlLaA1yJ0Ib2UoWw5T9euSDkn4E3HD1");
            }

            else
            {
                pictureBox1.Load("https://vignette.wikia.nocookie.net/dragonball/images/7/74/ShenronDBZep240.png/revision/latest/scale-to-width-down/301?cb=20150116162138&path-prefix=pt-br");
            }

            return resultado;
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = CalculoFahrenheit();
            }
            catch (Exception)
            {

                MessageBox.Show("Numero invalido!");
            }

           
          
        }
    }
}
