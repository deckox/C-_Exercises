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

        public void TrocaSimbolo()
        {
            if (SimboloAtual.Equals("X"))
            {
                SimboloAtual = "0";
            }

            else
            {
                SimboloAtual = "X";
            }
        }

        public void MarcarSimbolo (Label lbl)
        {
            if (lbl.Text == "")
            {
                lbl.Text = SimboloAtual;
            }

            TrocaSimbolo();
            VerificarVitoria();
        }

        public string Verificar(Label lbl1, Label lbl2, Label lbl3)
        {
            if (String.IsNullOrEmpty(lbl1.Text) || String.IsNullOrEmpty(lbl2.Text) || String.IsNullOrEmpty(lbl3.Text))
                return "";

            if (lbl1.Text == lbl2.Text && lbl1.Text == lbl3.Text)
                return lbl1.Text;
            else
                return "";
        }

        private bool CampoPreenchido(Label label)
        {
            return label.Text != string.Empty;
        }

        private void VerificarJogoTravado()
        {
            if (CampoPreenchido(label1) && CampoPreenchido(label2) && CampoPreenchido(label3) && CampoPreenchido(label4) && CampoPreenchido(label5) && CampoPreenchido(label6) && CampoPreenchido(label7) && CampoPreenchido(label8) && CampoPreenchido(label9))
            {
                MessageBox.Show("Deu velha!");
                LimparJogo();
            }
        }

        public void ExibirGanhador(string ganhador)
        {
            MessageBox.Show(ganhador + " Ganhou");
            LimparJogo();
        }

        public void VerificarVitoria()
        {

            var comparacao1 = Verificar(label1, label2, label3);
            if (comparacao1 != "")
                ExibirGanhador(comparacao1);

            var comparacao2 = Verificar(label4, label5, label6);
            if (comparacao2 != "")
                ExibirGanhador(comparacao2);

            var comparacao3 = Verificar(label7, label8, label9);
            if (comparacao3 != "")
                ExibirGanhador(comparacao3);

            var comparacao4 = Verificar(label1, label4, label7);
            if (comparacao4 != "")
                ExibirGanhador(comparacao4);

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
            MarcarSimbolo(label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarcarSimbolo(label9);
        }

        #endregion



        private void label_Click(object sender, EventArgs e)
        {
            MarcarSimbolo((Label)sender);
        }
        
    }
}
