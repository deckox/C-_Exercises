using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
       // List<string> ListaCriptografada;

        public Form1()
        {
            InitializeComponent();
           // ListaCriptografada = new List<string>();
        }



        private string InvertList(List<char> list)
        {
            var array = list.ToArray<char>();
            Array.Reverse(array);
            var resultado = new String(array);
            return resultado;
        }

        private void btn_frase_Click(object sender, EventArgs e)
        {
            var campoTexto = textBox1.Text;
            var criptografado = campoTexto;

            criptografado = criptografado.Replace("a", "%");
            criptografado = criptografado.Replace("e", "&");
            criptografado = criptografado.Replace("i", "$");
            criptografado = criptografado.Replace("o", "+");
            criptografado = criptografado.Replace("u", "@");
            criptografado = criptografado.Replace(" ", "?");
            
            var array = criptografado.ToCharArray();
            var arrayEditado = criptografado.ToCharArray().ToList();
            for (var i = 5; i < array.Count(); i = i + 5)
            {
                arrayEditado.Insert(i, '#');
            }


            var resultado = InvertList(arrayEditado);
            textBox1.Text = resultado;




            /*

            var ListaCriptografada = campoTexto.ToArray().ToList();
            string frase = "";
            var cinco = ListaCriptografada.ToString();


            for (int i = 0; i < ListaCriptografada.Count; i++)
            {
                var validacaoCriptografica = ListaCriptografada[i] == 'a' || ListaCriptografada[i] == 'e' || ListaCriptografada[i] == 'i' || ListaCriptografada[i] == 'o' || ListaCriptografada[i] == 'u' || ListaCriptografada[i] == ' ';
               // var aCadaCinco = cinco.Substring(i,5);



               /* if (aCadaCinco)
                {
                    frase = frase + "#";
                }
                * /
          

                if (ListaCriptografada[i] == 'a')
                {
                    frase = frase + "%";
                }

                if (ListaCriptografada[i] == 'e')
                {
                    frase = frase + "&";
                }

                if (ListaCriptografada[i] == 'i')
                {
                    frase = frase + "$";
                }

                if (ListaCriptografada[i] == 'o')
                {
                    frase = frase + "+";
                }

                if (ListaCriptografada[i] == 'u')
                {
                    frase = frase + "@";
                }

                if (ListaCriptografada[i] == ' ')
                {
                    frase = frase + "?";
                }

                if (!validacaoCriptografica)
                {
                    frase = frase + ListaCriptografada[i].ToString();
                }

            }

            var contrarioTexto = "";

            for (var i = frase.Length - 1; i >= 0; i--)
            {
                contrarioTexto = contrarioTexto + frase.Substring(i, 1);
            }

            
            textBox1.Text = contrarioTexto;
        */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var campoTexto = textBox1.Text;
            var criptografado = campoTexto;

            criptografado = criptografado.Replace("%", "a");
            criptografado = criptografado.Replace("&", "e");
            criptografado = criptografado.Replace("$", "i");
            criptografado = criptografado.Replace("+", "o");
            criptografado = criptografado.Replace("@", "u");
            criptografado = criptografado.Replace("?", " ");
            criptografado = criptografado.Replace("#", "");

            var array = criptografado.ToCharArray();
            var arrayEditado = criptografado.ToCharArray().ToList();
           /* for (var i = 5; i < array.Count(); i = i + 5)
            {
                arrayEditado.Insert(i, '#');
            }*/


            var resultado = InvertList(arrayEditado);
            textBox1.Text = resultado;
        }
    }
}

/*
 * 4) Crie uma aplicação que ira criptografar a frase informada pleo usuario 

    seguinto as seguintes regras:
	- Trocar as letras a por %
	- Trocar as letras e por &
	- Trocar as letras i por $
	- Trocar as letras o por +
	- Trocar as letras u por @
	- Trocar os espações por ?
	- Adicionar # entre as letras a cada 5 caracteres
	- Ao final exibir o resultado de tras para frente
	
	ex: 
		Usuário informa: Texto de exemplo da criptografia
		T&xt+#?d&?&#x&mpl#+?d%?#cr$pt#+gr%f#$% (previa do resultado antes de inverter)
		Resultado que deve ser apresentado: %$#f%rg+#tp$rc#?%d?+#lpm&x#&?&d?#+tx&T
 */
