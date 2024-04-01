using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";

        }

        private void WriteLog(string operation)
        {
           
            var data = DateTime.Now;
            var Log = File.Open(@"C:\Workspace\operacoes.log", FileMode.Append); //abre arquivo
            var escritor = new StreamWriter(Log); // instancia para escrever
            escritor.Write(data + " - " + operation + "\n"); //escreve
            escritor.Close();
            Log.Close();
             
        }

        int num;
        int resultado;
        string operacao;

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 2;
        }


        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 3;
        }


        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            WriteLog(textBox1.Text + "Clean");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                operacao = "adicao";
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                operacao = "subtracao";

            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                operacao = "multiplicacao";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                operacao = "divisao";

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                if (operacao == "adicao")
                {
                    resultado = num + int.Parse(textBox1.Text);
                    textBox1.Text = "" + resultado;
                    WriteLog(operacao);
                }

                if (operacao == "subtracao")
                {
                    resultado = num - int.Parse(textBox1.Text);
                    textBox1.Text = "" + resultado;
                    WriteLog(operacao);
                }

                if (operacao == "multiplicacao")
                {
                    resultado = num * int.Parse(textBox1.Text);
                    textBox1.Text = "" + resultado;
                    WriteLog(operacao);
                }

                if (operacao == "divisao")
                {
                    resultado = num / int.Parse(textBox1.Text);
                    textBox1.Text = "" + resultado;
                    WriteLog(operacao);
                }
            }

            else
            {
                textBox1.Text = "";
            }

        }

    }

/*
6) Adicionar log das operações na aplicação de calculadora criada anteriormente, o log so deve ser gerado ao clicar no botao "=" ou no "ce";
ex: usuario fez uma conta de adição, ao clicar no = deve ser gerado o seguinte log:
    11/06/2017 14:35:00 - Operação Adição;
ex: usuario fez uma conta de adição, subtração e multiplicação, ao clicar no = deve ser gerado o seguinte log:
	11/06/2017 14:35:00 - Operação Adição, Operação Subtração, Operação Multiplicação;
ex: usuario clicou em CE
	11/06/2017 14:35:00 - Operação Limpar;
     */
}
