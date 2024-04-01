using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            retorno_txt.Text = "";
            LimparCampos();
        }

        public string Tabuada(int de, int ate)
        {
            var resultado = "";
            LimparCampos(ate);

            for (var i = 1; i <= ate; i++)
            {
                var resultadoTabuada = de * i;
                resultado = resultado + de + " " + " x " + i + " = " + resultadoTabuada + "\n";
                UpdateProgressBar();
            }

            return resultado;
        }

        public void UpdateProgressBar()
        {
            progressBar.Value = progressBar.Value + 1;
            Application.DoEvents();
        }

        public void LimparCampos(int ate = 0)
        {
            txt_de.Text = "";
            txt_ate.Text = "";
            progressBar.Maximum = ate;
            progressBar.Value = 0;
            retorno_txt.Text = "";
        }

        private void btn_tabuada_Click(object sender, EventArgs e)
        {
            try
            {
                var numeroDe = int.Parse(txt_de.Text);
                var numeroAte = int.Parse(txt_ate.Text);

                retorno_txt.Text = Tabuada(numeroDe, numeroAte);
                
            }

            catch (Exception)
            {
                MessageBox.Show("Numero inválido!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
