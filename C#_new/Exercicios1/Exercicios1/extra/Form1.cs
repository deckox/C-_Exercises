using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extra
{
    public partial class Form1 : Form
    {
        int[] x = { 2, 1, 8, 7, 5, 9, 15, 3, 6 };

        public Form1()
        {
            InitializeComponent();
        }

        // criando o método bubblesort
        public void bubblesort(int[] y)
        {
            for (int i = 1; i < y.Length; i++)
                for (int j = 0; j < y.Length - 1; j++)
                    if (y[j] > y[j + 1])
                        troca(y, j);
        }

        // algoritmo de troca de valores de variáveis:
        public void troca(int[] g, int primeiro)
        {
            int aux;
            aux = g[primeiro];
            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = aux;
        }

        private void bntMostraArray_Click(object sender, EventArgs e)
        {
            // Botão para ordenar o array
            {  
                lblOriginal.Text = "Itens do array ordenados:\n";
                for (int i = 0; i < x.Length; i++)
                {
                    lblOriginal.Text += " " + x[i];
                }
            }
        }

        private void bntOrdenaArray_Click(object sender, EventArgs e)
        {
            // Botão para mostrar conteúdo original do array
            {
                bubblesort(x);
                lblOrdenado.Text = "Itens do array na ordem original:\n";
                for (int i = 0; i < x.Length; i++)
                {
                    lblOrdenado.Text += " " + x[i];
                }
            }
        }
    }
}
