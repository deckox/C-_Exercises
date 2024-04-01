using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        List<string> ListadeTwites;
        public Form1()
        {
            ListadeTwites = new List<string>();
            InitializeComponent();
        }

        //Nao esquecer que as mensagens mais recentes devem ficar primeiro na timeline.

        private void btnTwitar_Click(object sender, EventArgs e)
        {
            var hora = DateTime.Now;
            var campoTwit = textBox1.Text;



            //lstTimeline.Items.Insert(0, hora + ": " + campoTwit);


            var lista = new List<string>();
            foreach (var item in lstTimeline.Items)
            {
                lista.Add(item.ToString());
            }

            lstTimeline.Items.Clear();
            lstTimeline.Items.Add(hora + ": " + campoTwit);
            foreach (var item in lista)
            {
                lstTimeline.Items.Add(item.ToString());
            }

            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int totalutilizados = 0 + textBox1.TextLength;
            int totaldisponivel = 50 - textBox1.TextLength;

            lblStatus.Text = totaldisponivel + " caracteres disponiveis, " + totalutilizados + " caracteres utilizados";
        }
    }
}
