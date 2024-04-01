using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Fatorial(int i)
        {
            return ((i <= 1) ? 1 : (i * Fatorial(i - 1)));
        }

        private void btn_fatorial_Click(object sender, EventArgs e)
        {
            var campo = int.Parse(textBox1.Text);

            MessageBox.Show("O fatorial é: " + Fatorial(campo));
        }
    }
}
