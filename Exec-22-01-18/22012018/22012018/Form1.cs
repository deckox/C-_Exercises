using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22012018
{

    public partial class Form1 : Form
    {
        List<Cordenada> Coordernadas = new List<Cordenada>();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            Coordernadas = new List<Cordenada>();
        }

        private void btn_linha_Click(object sender, EventArgs e)
        {
            try
            {   
                var linha = int.Parse(campoLinha.Text);
                var coluna = int.Parse(campoColuna.Text);
              
                for (int i = 1; i <= linha; i++)
                {
                    for (int j = 1; j <= coluna; j++)
                    {
                        label1.Text = label1.Text + " O ";
                    }

                    label1.Text = label1.Text + "\n";

                }
  
            }

            catch(Exception)
            {
                MessageBox.Show("O campo não pode ser em branco, caracteres não são permitidos");
            }
        }


        private bool CordenadaJaMarcada(int linha, int coluna)
        {
            var achou = Coordernadas.Any(_ => _.Linha == linha && _.Coluna == coluna);
            return achou;
        }


        private void btn_coordenadaX_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                var coordernadaX = int.Parse(campoX.Text);
                var coordernadaY = int.Parse(campoY.Text);
                var linha = int.Parse(campoLinha.Text);
                var coluna = int.Parse(campoColuna.Text);


                Coordernadas.Add(new Cordenada(coordernadaX, coordernadaY));
            

                for (int i = 1; i <= linha; i++)
                {
                    for (int j = 1; j <= coluna; j++)
                    {
                        if (CordenadaJaMarcada(i,j))
                        {
                            label1.Text = label1.Text +  " X " ;
                        }

                        else
                        {
                            label1.Text = label1.Text + " O ";
                        }

                    }

                    label1.Text = label1.Text + "\n";
                }

                campoX.Text = "";
                campoY.Text = "";

            }

            catch (Exception)
            {
                MessageBox.Show("O campo não pode ser em branco, caracteres não são permitidos");
            }
        }
    }

    public class Cordenada
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Cordenada()
        {

        }

        public Cordenada(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
    }
}

