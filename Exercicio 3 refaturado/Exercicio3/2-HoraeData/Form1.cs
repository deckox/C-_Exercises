using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_HoraeData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DataHora()
        {
            var dataAgora = DateTime.Now;
            MessageBox.Show("A data e hora atual é: " + dataAgora);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHora();
        }
    }
}
