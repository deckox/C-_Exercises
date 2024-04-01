using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15012018
{
    public partial class Form1 : Form
    {


        public string SimboloAtual = "X";


        public Form1()
        {
            InitializeComponent();
        }

        public void TrocarSimbolo()
        {
            if (SimboloAtual.Equals("X"))
                SimboloAtual = "O";
            else
                SimboloAtual = "X";
        }

        private string Verificar(Label primeiraLabel, Label segundaLabel, Label terceiraLabel)
        {

            if (String.IsNullOrEmpty(primeiraLabel.Text) || String.IsNullOrEmpty(segundaLabel.Text) || String.IsNullOrEmpty(terceiraLabel.Text))
                return "";

            if (primeiraLabel.Text == segundaLabel.Text && primeiraLabel.Text == terceiraLabel.Text)
                return primeiraLabel.Text;
            else
                return "";

        }

        private bool CampoPreenchido(Label label)
        {
            return label.Text != string.Empty;
        }

        private void VerificarJogoTravado()
        {
            if(CampoPreenchido(label1) && CampoPreenchido(label2) && CampoPreenchido(label3) && CampoPreenchido(label4) && CampoPreenchido(label5) && CampoPreenchido(label6) && CampoPreenchido(label7) && CampoPreenchido(label8) && CampoPreenchido(label9))
            {
                MessageBox.Show("Deu velha!");
                LimparJogo();
            }
        }


        private void ExibirGanhador(string ganhador)
        {
            MessageBox.Show(ganhador + " Ganhou");
            LimparJogo();
        }


        public void VerificarVitoria()
        {

            var comparacao1 = Verificar(label1, label2, label3);
            if (comparacao1  != "")
                ExibirGanhador(comparacao1);

            var comparacao2 = Verificar(label4, label5, label6);
            if (comparacao2 != "")
                ExibirGanhador(comparacao2);

            var comparacao3 = Verificar(label7, label8, label9);
            if (comparacao3 != "")
                ExibirGanhador(comparacao3);

            var comparacao4 = Verificar(label1, label4, label7);
            if (comparacao4 != "")
                ExibirGanhador(comparacao4 );

            var comparacao5 = Verificar(label2, label5, label8);
            if (comparacao5 != "")
                ExibirGanhador(comparacao5);

            var comparacao6 = Verificar(label3, label6, label9);
            if (comparacao6 != "")
                ExibirGanhador(comparacao6);

            var comparacao7 = Verificar(label1, label5, label9);
            if (comparacao7 != "")
                ExibirGanhador(comparacao7);

            var comparacao8 = Verificar(label3, label5, label7);
            if (comparacao8 != "")
                ExibirGanhador(comparacao8);

            VerificarJogoTravado();
        }

        public void MarcaSimbolo(Label label)
        {
            if (label.Text == "")
            { 

                label.Text = SimboloAtual;

                TrocarSimbolo();
                VerificarVitoria();
            }

        }


        public void LimparJogo()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            label9.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparJogo();
        }

        #region Botoes
        
        private void button1_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarcaSimbolo(label9);
        }

        #endregion



        private void label_Click(object sender, EventArgs e)
        {
            MarcaSimbolo((Label)sender);
        }
        
    }
}
