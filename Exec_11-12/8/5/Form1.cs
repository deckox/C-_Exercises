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
        }

        private void AtivaDesativaBotoes(bool ativo)
        {
            btn_A.Enabled = ativo;
            btn_B.Enabled = ativo;
            btn_C.Enabled = ativo;
            btn_D.Enabled = ativo;
            btn_E.Enabled = ativo;
        }

        private void WriteLog(string operation, string text)
        {
            AtivaDesativaBotoes(false);
            var data = DateTime.Now;
            var Log = File.Open(@"C:\Workspace\operacoes.log", FileMode.Append); //abre arquivo
            var escritor = new StreamWriter(Log); // instancia para escrever
            escritor.Write(data + " - " + operation + " : " + text + "\n"); //escreve
            escritor.Close();
            Log.Close();
            AtivaDesativaBotoes(true);
        }


        private void btn_A_Click(object sender, EventArgs e)
        {
            var campoA = textBox1.Text;
            var botaoA = btn_A.Text;
            WriteLog(botaoA, campoA);
            textBox1.Text = "";
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            var campoB = textBox2.Text;
            var botaoB = btn_B.Text;
            WriteLog(botaoB, campoB);
            textBox2.Text = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            var campoC = textBox3.Text;
            var botaoC = btn_C.Text;
            WriteLog(botaoC,campoC);
            textBox3.Text = "";
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            var campoD = textBox4.Text;
            var botaoD = btn_D.Text;
            WriteLog(botaoD, campoD);
            textBox4.Text = "";
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            var campoE = textBox5.Text;
            var botaoE = btn_E.Text;
            WriteLog(botaoE, campoE);
            textBox5.Text = "";
        }
    }

    /*5) Criar uma aplica com 5 botões e um campo de texto que gere um log da utilização.
	-Campo de texto
	-Botões: Operação A, Operação B, Operação C, Operação D, Operação E.
	-A aplicacao deve gerar um arquivo de log chamado "operacoes.log"
	-Apos o clique em cada botão deve ser inserido uma nova linha no arquivo de log no seguinte formato
        Data e Hora que o botão foi precionado + "-" + Nome da Operação + ":" + Texto informado pelo usuario + ";"

        ex:
			11/06/2017 14:31:27 - Operação C : teste123;
			11/06/2017 14:33:12 - Operação B : abcde;
			11/06/2017 14:35:00 - Operação E : blablablabla; */
}
