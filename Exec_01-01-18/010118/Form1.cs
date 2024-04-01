using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010118
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var dia = int.Parse(textDia.Text);
                var mes = int.Parse(textMes.Text);
                var ano = int.Parse(textAno.Text);

                DateTime dateValue = new DateTime(ano, mes, dia);

                if (dateValue.DayOfWeek == DayOfWeek.Monday)
                {
                    MessageBox.Show("Segunda-Feira (Sebunda)");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Tuesday)
                {
                    MessageBox.Show("Terça-Feira");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Wednesday)
                {
                    MessageBox.Show("Quarta-Feira");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Thursday)
                {
                    MessageBox.Show("Quinta-Feira");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Friday)
                {
                    MessageBox.Show("Sexta-Feira");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Saturday)
                {
                    MessageBox.Show("Sabado");
                }

                if (dateValue.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Domingo");
                }

            }

            catch (Exception)
            {
                MessageBox.Show("O campo so pode conter numeros e não pode ser vazio!");
            }

            textDia.Text = "";
            textMes.Text = "";
            textAno.Text = "";
        }

    }
}


//3) Crie um programa que recebe uma data e informa em qual dia da semana ela cai (em portugues).
