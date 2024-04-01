using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        new List<string> ArmazenadorLista;
        public Form1()
        {
            InitializeComponent();
            ArmazenadorLista = new List<string>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var campoTexto = textBox1.Text;

            if (campoTexto != "")
            {
                ArmazenadorLista.Add(campoTexto);

                textBox1.Text = "";
            }

            else
            {
                MessageBox.Show("Favor não deixar o campo em branco!");
            }
   
        }

        private void btn_exibe_Click(object sender, EventArgs e)
        {
            for(var i = 0; i < ArmazenadorLista.Count; i++)
            {
                MessageBox.Show("O conteudo da lista é: " + ArmazenadorLista[i]);
            }
        }

        private void btn_apaga_Click(object sender, EventArgs e)
        {
            for(var i = 0; i < ArmazenadorLista.Count; i++)
            {
                ArmazenadorLista.RemoveAt(i);
                MessageBox.Show("Item removido com sucesso!!");
            }
        }
    }

   /* Crie uma aplicação com um campo para o usuario Informar um texto, um botao Adicionar, exibir e um Limpar.
    - Cada vez que o usuario cliar em adicionar o programa deve adicionar o texto informado em uma nova linha do arquivo.
    - Qnd clicar em exibir o programa deve exibir o conteudo total do arquivo
    - Quando clicar em apagar o programa deve limpar todo o conteudo do arquivo */
}
