using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2UsuarioNomeSobrenome
{
    public partial class Form1 : Form
    {
        List <string> ListadeNomes;
        public Form1()
        {
            InitializeComponent();

            ListadeNomes = new List<string>();
          
            textBox1.Text = "Nome e Sobrenome";
        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            var campoTexto = textBox1.Text;

        
            if (campoTexto != "" && campoTexto != "Nome e Sobrenome" )
            {
                ListadeNomes.Add(campoTexto);

                textBox1.Text = "";
            }

            else
            {
                MessageBox.Show("Favor digitar no campo");
            }
            
        }

        private void btn_mostra_Click(object sender, EventArgs e)
        {
            
            var labelRetorno = retorno.Text;
            retorno.Text = "";

            for (var i = 0; i < ListadeNomes.Count; i++)
            {
                

                var separador = ListadeNomes[i].Split(' ');
                retorno.Text =  retorno.Text + ListadeNomes[i] + "\n" + separador.LastOrDefault() + " , " + separador.FirstOrDefault() + "\n";
            }


        }

        /* 5) Crie uma aplicação que deve ler o nome e sobrenome de um usuário e 
              apresentar para o usuário em 2 formatos diferentes(nome sobrenome) e(sobrenome, nome).

                Ex:
                                Usuario informa:
                                                Nome: Rafael  Sobrenome: Vasconcelos
                                Aplicação deve apresentar:
                                                Rafael Vasconcelos
                                                Vasconcelos, Rafael
        */
    }
}
