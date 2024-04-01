using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        List<string> NumerosSaidos;





        
        private string GerarNumeroAleatorio(List<string> ListaDeExcecoes)
        {
            var random = new Random();
            var numero = "";
            while (numero == "")
            {
                var sorteado = random.Next(1, 100).ToString();
                if (!ListaDeExcecoes.Contains(sorteado))
                {
                    numero = sorteado;
                }
            }

            return numero;
        }

        private List<string> GerarCartelaRandomica()
        {
            const int totalNumerosDaCartela = 16;
            var cartela = new List<string>();

            while(cartela.Count < totalNumerosDaCartela)
            {
                var numero = GerarNumeroAleatorio(cartela);
                cartela.Add(numero);
            }

            return cartela;
        }


        public Form1()
        {
            InitializeComponent();
            LimpaCampo();

            NumerosSaidos = new List<string>();


            var cartela = GerarCartelaRandomica();
            textBox1.Text = cartela[0].ToString();
            textBox2.Text = cartela[1].ToString();
            textBox3.Text = cartela[2].ToString();
            textBox4.Text = cartela[3].ToString();
            textBox5.Text = cartela[4].ToString();
            textBox6.Text = cartela[5].ToString();
            textBox7.Text = cartela[6].ToString();
            textBox8.Text = cartela[7].ToString();
            textBox9.Text = cartela[8].ToString();
            textBox10.Text =cartela[9].ToString();
            textBox11.Text =cartela[10].ToString();
            textBox12.Text =cartela[11].ToString();
            textBox13.Text =cartela[12].ToString();
            textBox14.Text =cartela[13].ToString();
            textBox15.Text =cartela[14].ToString();
            textBox16.Text = cartela[15].ToString();
            /*
            Random random = new Random();

            textBox1.Text = random.Next(0,100).ToString();
            textBox2.Text = random.Next(0, 100).ToString();
            textBox3.Text = random.Next(0, 100).ToString();
            textBox4.Text = random.Next(0, 100).ToString();
            textBox5.Text = random.Next(0, 100).ToString();
            textBox6.Text = random.Next(0, 100).ToString();
            textBox7.Text = random.Next(0, 100).ToString();
            textBox8.Text = random.Next(0, 100).ToString();
            textBox9.Text = random.Next(0, 100).ToString();
            textBox10.Text = random.Next(0, 100).ToString();
            textBox11.Text = random.Next(0, 100).ToString();
            textBox12.Text = random.Next(0, 100).ToString();
            textBox13.Text = random.Next(0, 100).ToString();
            textBox14.Text = random.Next(0, 100).ToString();
            textBox15.Text = random.Next(0, 100).ToString();
            textBox16.Text = random.Next(0, 100).ToString();
            */
        }



        public void LimpaCampo()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            txtNumerosSorteados.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        /* public void NumeroRepetido()
          {
              var campo1 = textBox1.Text;
              var campo2 = textBox2.Text;
              var campo3 = textBox3.Text;
              var campo4 = textBox4.Text;
              var campo5 = textBox5.Text;
              var campo6 = textBox6.Text;
              var campo7 = textBox7.Text;
              var campo8 = textBox8.Text;
              var campo9 = textBox9.Text;
              var campo10 = textBox10.Text;
              var campo11 = textBox11.Text;
              var campo12 = textBox12.Text;
              var campo13 = textBox13.Text;
              var campo14 = textBox14.Text;
              var campo15 = textBox15.Text;
              var campo16 = textBox16.Text;


              if (campo1 == campo2 || campo1 == campo3 || campo1 == campo4 || campo1 == campo5 || campo1 == campo6 ||
               campo1 == campo7 || campo1 == campo8 || campo1 == campo9 || campo1 == campo10 || campo1 == campo11 ||
               campo1 == campo12 || campo1 == campo13 || campo1 == campo14 || campo1 == campo15 || campo1 == campo16)
              {
                  MessageBox.Show("Numero repetido");
                  campo1 = "";
              }

              if (campo2 == campo3 || campo2 == campo4 || campo2 == campo5 || campo2 == campo6 || campo2 == campo7 ||
                campo2 == campo8 || campo2 == campo9 || campo2 == campo10 || campo2 == campo11 || campo2 == campo13 ||
                campo2 == campo14 || campo2 == campo15 || campo2 == campo12 || campo1 == campo16)
              {
                  MessageBox.Show("Numero repetido");
                  campo2 = "";
              }

          } */

        private void btn_cartela_Click(object sender, EventArgs e)
        {
            var campo1 = textBox1.Text;
            var campo2 = textBox2.Text;
            var campo3 = textBox3.Text;
            var campo4 = textBox4.Text;
            var campo5 = textBox5.Text;
            var campo6 = textBox6.Text;
            var campo7 = textBox7.Text;
            var campo8 = textBox8.Text;
            var campo9 = textBox9.Text;
            var campo10 = textBox10.Text;
            var campo11 = textBox11.Text;
            var campo12 = textBox12.Text;
            var campo13 = textBox13.Text;
            var campo14 = textBox14.Text;
            var campo15 = textBox15.Text;
            var campo16 = textBox16.Text;

            if (campo1 == campo2 || campo1 == campo3 || campo1 == campo4 || campo1 == campo5 || campo1 == campo6 ||
              campo1 == campo7 || campo1 == campo8 || campo1 == campo9 || campo1 == campo10 || campo1 == campo11 ||
              campo1 == campo12 || campo1 == campo13 || campo1 == campo14 || campo1 == campo15 || campo1 == campo16)
            {

                campo1 = "";
                textBox1.Text = "";
            }

            if (campo2 == campo1 || campo2 == campo3 || campo2 == campo4 || campo2 == campo5 || campo2 == campo6 || campo2 == campo7 ||
              campo2 == campo8 || campo2 == campo9 || campo2 == campo10 || campo2 == campo11 || campo2 == campo13 ||
              campo2 == campo14 || campo2 == campo15 || campo2 == campo12 || campo1 == campo16)
            {

                campo2 = "";
                textBox2.Text = "";
            }

            if (campo3 == campo1 || campo3 == campo2 || campo3 == campo4 || campo3 == campo5 || campo3 == campo6 || campo3 == campo7 || campo3 == campo8 ||
            campo3 == campo9 || campo3 == campo10 || campo3 == campo11 || campo3 == campo12 || campo3 == campo13 ||
            campo3 == campo14 || campo3 == campo15 || campo3 == campo16)
            {

                campo3 = "";
                textBox3.Text = "";
            }

            if (campo4 == campo1 || campo4 == campo2 || campo4 == campo3 ||
            campo4 == campo5 || campo4 == campo6 || campo4 == campo7 || campo4 == campo8 || campo4 == campo9 ||
            campo4 == campo10 || campo4 == campo11 || campo4 == campo12 || campo4 == campo13 ||
            campo4 == campo14 || campo4 == campo15 || campo4 == campo16)
            {

                campo4 = "";
                textBox4.Text = "";
            }

            if (campo5 == campo1 || campo5 == campo2 || campo5 == campo3 || campo5 == campo4 ||
                campo5 == campo6 || campo5 == campo7 || campo5 == campo8 || campo5 == campo9 ||
            campo5 == campo10 || campo5 == campo11 || campo5 == campo12 || campo5 == campo13 ||
            campo5 == campo14 || campo5 == campo15 || campo5 == campo16)
            {

                campo5 = "";
                textBox5.Text = "";
            }

            if (campo6 == campo1 || campo6 == campo2 || campo6 == campo2 || campo6 == campo3 || campo6 == campo4 ||
            campo6 == campo5 || campo6 == campo7 || campo6 == campo8 || campo6 == campo9 ||
            campo6 == campo10 || campo6 == campo11 || campo6 == campo12 || campo6 == campo13 ||
            campo6 == campo14 || campo6 == campo15 || campo6 == campo16)
            {

                campo6 = "";
                textBox6.Text = "";
            }

            if (campo7 == campo1 || campo7 == campo2 || campo7 == campo3 || campo7 == campo4 ||
            campo7 == campo5 || campo7 == campo6 || campo7 == campo8 || campo7 == campo9 ||
            campo7 == campo10 || campo7 == campo11 || campo7 == campo12 || campo7 == campo13 ||
            campo7 == campo14 || campo7 == campo15 || campo7 == campo16)
            {

                campo7 = "";
                textBox7.Text = "";
            }

            if (campo8 == campo1 || campo8 == campo2 || campo8 == campo3 || campo8 == campo4 ||
           campo8 == campo5 || campo8 == campo6 || campo8 == campo7 | campo8 == campo9 ||
           campo8 == campo10 || campo8 == campo11 || campo8 == campo12 || campo8 == campo13 ||
           campo8 == campo14 || campo8 == campo15 || campo8 == campo16)
            {

                campo8 = "";
                textBox8.Text = "";
            }

            if (campo9 == campo1 || campo9 == campo2 || campo9 == campo3 || campo9 == campo4 ||
            campo9 == campo5 || campo9 == campo6 || campo9 == campo7 | campo9 == campo8 ||
            campo9 == campo10 || campo9 == campo11 || campo9 == campo12 || campo9 == campo13 ||
            campo9 == campo14 || campo9 == campo15 || campo9 == campo16)
            {

                campo9 = "";
                textBox9.Text = "";
            }

            if (campo10 == campo1 || campo10 == campo2 || campo10 == campo3 || campo10 == campo4 ||
            campo10 == campo5 || campo10 == campo6 || campo10 == campo7 | campo10 == campo8 ||
            campo10 == campo9 || campo10 == campo11 || campo10 == campo12 || campo10 == campo13 ||
            campo10 == campo14 || campo10 == campo15 || campo10 == campo16)
            {

                campo10 = "";
                textBox10.Text = "";
            }

            if (campo11 == campo1 || campo11 == campo2 || campo11 == campo3 || campo11 == campo4 ||
            campo11 == campo5 || campo11 == campo6 || campo11 == campo7 | campo11 == campo8 ||
            campo11 == campo9 || campo11 == campo10 || campo11 == campo12 || campo11 == campo13 ||
            campo11 == campo14 || campo11 == campo15 || campo11 == campo16)
            {

                campo11 = "";
                textBox11.Text = "";
            }

            if (campo12 == campo1 || campo12 == campo2 || campo12 == campo3 || campo12 == campo4 ||
            campo12 == campo5 || campo12 == campo6 || campo12 == campo7 | campo12 == campo8 ||
            campo12 == campo9 || campo12 == campo10 || campo12 == campo11 || campo12 == campo13 ||
            campo12 == campo14 || campo12 == campo15 || campo12 == campo16)
            {

                campo12 = "";
                textBox12.Text = "";
            }

            if (campo13 == campo1 || campo13 == campo2 || campo13 == campo3 || campo13 == campo4 ||
            campo13 == campo5 || campo13 == campo6 || campo13 == campo7 | campo13 == campo8 ||
            campo13 == campo9 || campo13 == campo10 || campo13 == campo11 || campo13 == campo12 ||
            campo13 == campo14 || campo13 == campo15 || campo13 == campo16)
            {

                campo13 = "";
                textBox13.Text = "";
            }


            if (campo14 == campo1 || campo14 == campo2 || campo14 == campo3 || campo14 == campo4 ||
            campo14 == campo5 || campo14 == campo6 || campo14 == campo7 | campo14 == campo8 ||
            campo14 == campo9 || campo14 == campo10 || campo14 == campo11 || campo14 == campo12 ||
            campo14 == campo13 || campo14 == campo15 || campo14 == campo16)
            {

                campo14 = "";
                textBox14.Text = "";
            }


            if (campo15 == campo1 || campo15 == campo2 || campo15 == campo3 || campo15 == campo4 ||
           campo15 == campo5 || campo15 == campo6 || campo15 == campo7 | campo15 == campo8 ||
           campo15 == campo9 || campo15 == campo10 || campo15 == campo11 || campo15 == campo12 ||
           campo15 == campo13 || campo15 == campo14 || campo15 == campo16)
            {

                campo15 = "";
                textBox15.Text = "";
            }

            if (campo16 == campo1 || campo16 == campo2 || campo16 == campo3 || campo16 == campo4 ||
           campo16 == campo5 || campo16 == campo6 || campo16 == campo7 | campo16 == campo8 ||
           campo16 == campo9 || campo16 == campo10 || campo16 == campo11 || campo16 == campo12 ||
           campo16 == campo13 || campo16 == campo14 || campo16 == campo15)
            {

                campo16 = "";
                textBox16.Text = "";
            }

            if (campo1 == "" || int.Parse(campo1) < 1 || int.Parse(campo1) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox1.Text = "";
                campo1 = "";

            }

            if (campo2 == "" || int.Parse(campo2) < 1 || int.Parse(campo2) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox2.Text = "";
                campo2 = "";

            }

            if (campo3 == "" || int.Parse(campo3) < 1 || int.Parse(campo3) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox3.Text = "";
                campo3 = "";

            }

            if (campo4 == "" || int.Parse(campo4) < 1 || int.Parse(campo4) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox4.Text = "";
                campo4 = "";

            }

            if (campo5 == "" || int.Parse(campo5) < 1 || int.Parse(campo5) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox5.Text = "";
                campo5 = "";

            }

            if (campo6 == "" || int.Parse(campo6) < 1 || int.Parse(campo6) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox6.Text = "";
                campo6 = "";

            }

            if (campo7 == "" || int.Parse(campo7) < 1 || int.Parse(campo7) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox7.Text = "";
                campo7 = "";

            }

            if (campo8 == "" || int.Parse(campo8) < 1 || int.Parse(campo8) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox8.Text = "";
                campo8 = "";

            }

            if (campo9 == "" || int.Parse(campo9) < 1 || int.Parse(campo9) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox9.Text = "";
                campo9 = "";

            }

            if (campo10 == "" || int.Parse(campo10) < 1 || int.Parse(campo10) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox10.Text = "";
                campo10 = "";

            }

            if (campo11 == "" || int.Parse(campo11) < 1 || int.Parse(campo11) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox11.Text = "";
                campo11 = "";

            }

            if (campo12 == "" || int.Parse(campo12) < 1 || int.Parse(campo12) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox12.Text = "";
                campo12 = "";

            }

            if (campo13 == "" || int.Parse(campo13) < 1 || int.Parse(campo13) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox13.Text = "";
                campo13 = "";

            }

            if (campo14 == "" || int.Parse(campo14) < 1 || int.Parse(campo14) > 100)
            {
                MessageBox.Show("Para o " + campo14 + "Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox14.Text = "";
                campo14 = "";

            }

            if (campo15 == "" || int.Parse(campo15) < 1 || int.Parse(campo15) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox15.Text = "";
                campo15 = "";

            }

            if (campo16 == "" || int.Parse(campo16) < 1 || int.Parse(campo16) > 100)
            {
                MessageBox.Show("Favor escolher apenas numeros de 1 a 100 e o numero não pode ser repetido");
                textBox16.Text = "";
                campo16 = "";

            }




            label1.Text = campo1;
            label2.Text = campo2;
            label3.Text = campo3;
            label4.Text = campo4;
            label5.Text = campo5;
            label6.Text = campo6;
            label7.Text = campo7;
            label8.Text = campo8;
            label9.Text = campo9;
            label10.Text = campo10;
            label11.Text = campo11;
            label12.Text = campo12;
            label13.Text = campo13;
            label14.Text = campo14;
            label15.Text = campo15;
            label16.Text = campo16;


        }

        private void btn_bolatual_Click(object sender, EventArgs e)
        {
            var campo1 = textBox1.Text;
            var campo2 = textBox2.Text;
            var campo3 = textBox3.Text;
            var campo4 = textBox4.Text;
            var campo5 = textBox5.Text;
            var campo6 = textBox6.Text;
            var campo7 = textBox7.Text;
            var campo8 = textBox8.Text;
            var campo9 = textBox9.Text;
            var campo10 = textBox10.Text;
            var campo11 = textBox11.Text;
            var campo12 = textBox12.Text;
            var campo13 = textBox13.Text;
            var campo14 = textBox14.Text;
            var campo15 = textBox15.Text;
            var campo16 = textBox16.Text;

            var gerarNumero = textBox17.Text;

            if (gerarNumero == "" || int.Parse(gerarNumero) > 101 || int.Parse(gerarNumero) < 1)
            {
                MessageBox.Show("O numero não pode ser menor que 1 e maior que 100 e o campo não pode ser em branco!");
                
            }

            else
            {
                NumerosSaidos.Add(gerarNumero);
            }


            var resultado = "";

            for (int i = 0; i < NumerosSaidos.Count; i++)
            {
                resultado = resultado + NumerosSaidos[i] + " ";

                if (campo1 == NumerosSaidos[i])
                {
                    label1.Text = "X" + campo1;
                }

                if (campo2 == NumerosSaidos[i])
                {
                    label2.Text = "X" + campo2;
                }

                if (campo3 == NumerosSaidos[i])
                {
                    label3.Text = "X" + campo3;
                }

                if (campo4 == NumerosSaidos[i])
                {
                    label4.Text = "X" + campo4;
                }

                if (campo5 == NumerosSaidos[i])
                {
                    label5.Text = "X" + campo5;
                }

                if (campo6 == NumerosSaidos[i])
                {
                    label6.Text = "X" + campo6;
                }

                if (campo7 == NumerosSaidos[i])
                {
                    label7.Text = "X" + campo7;
                }

                if (campo8 == NumerosSaidos[i])
                {
                    label8.Text = "X" + campo8;
                }
                if (campo9 == NumerosSaidos[i])
                {
                    label9.Text = "X" + campo9;
                }

                if (campo10 == NumerosSaidos[i])
                {
                    label10.Text = "X" + campo10;
                }

                if (campo11 == NumerosSaidos[i])
                {
                    label11.Text = "X" + campo11;
                }

                if (campo12 == NumerosSaidos[i])
                {
                    label12.Text = "X" + campo12;
                }

                if (campo13 == NumerosSaidos[i])
                {
                    label13.Text = "X" + campo13;
                }

                if (campo14 == NumerosSaidos[i])
                {
                    label14.Text = "X" + campo14;
                }

                if (campo15 == NumerosSaidos[i])
                {
                    label15.Text = "X" + campo15;
                }

                if (campo16 == NumerosSaidos[i])
                {
                    label16.Text = "X" + campo16;
                }
                
            }

            txtNumerosSorteados.Text = "Numeros já sorteados: " + resultado;

            textBox17.Text = "";

            if (label1.Text.Contains("X" + campo1) && label2.Text.Contains("X" + campo2) && label3.Text.Contains("X" + campo3)
                && label4.Text.Contains("X" + campo4) && label5.Text.Contains("X" + campo5) && label6.Text.Contains("X" + campo6)
                && label7.Text.Contains("X" + campo7) && label8.Text.Contains("X" + campo8) && label9.Text.Contains("X" + campo9)
                && label10.Text.Contains("X" + campo10) && label11.Text.Contains("X" + campo11) && label12.Text.Contains("X" + campo12)
                && label13.Text.Contains("X" + campo13) && label14.Text.Contains("X" + campo14) && label15.Text.Contains("X" + campo15)
                && label16.Text.Contains("X" + campo16))
            {
                MessageBox.Show("BINGO!");
                LimpaCampo();
            }

           if (NumerosSaidos.Count == 200)
            {
                MessageBox.Show("Voce Perdeu!!");
                LimpaCampo();
            }
        }

        private void btn_geralbola_Click(object sender, EventArgs e)
        {
            var campo1 = textBox1.Text;
            var campo2 = textBox2.Text;
            var campo3 = textBox3.Text;
            var campo4 = textBox4.Text;
            var campo5 = textBox5.Text;
            var campo6 = textBox6.Text;
            var campo7 = textBox7.Text;
            var campo8 = textBox8.Text;
            var campo9 = textBox9.Text;
            var campo10 = textBox10.Text;
            var campo11 = textBox11.Text;
            var campo12 = textBox12.Text;
            var campo13 = textBox13.Text;
            var campo14 = textBox14.Text;
            var campo15 = textBox15.Text;
            var campo16 = textBox16.Text;

            var resultado = "";


            var numeroGerado = GerarNumeroAleatorio(NumerosSaidos);
            NumerosSaidos.Add(numeroGerado);

            for (int i = 0; i < NumerosSaidos.Count; i++)
            {
                resultado = resultado + NumerosSaidos[i] + " ";

                if (campo1 == NumerosSaidos[i])
                {
                    label1.Text = "X" + campo1;
                }

                if (campo2 == NumerosSaidos[i])
                {
                    label2.Text = "X" + campo2;
                }

                if (campo3 == NumerosSaidos[i])
                {
                    label3.Text = "X" + campo3;
                }

                if (campo4 == NumerosSaidos[i])
                {
                    label4.Text = "X" + campo4;
                }

                if (campo5 == NumerosSaidos[i])
                {
                    label5.Text = "X" + campo5;
                }

                if (campo6 == NumerosSaidos[i])
                {
                    label6.Text = "X" + campo6;
                }

                if (campo7 == NumerosSaidos[i])
                {
                    label7.Text = "X" + campo7;
                }

                if (campo8 == NumerosSaidos[i])
                {
                    label8.Text = "X" + campo8;
                }
                if (campo9 == NumerosSaidos[i])
                {
                    label9.Text = "X" + campo9;
                }

                if (campo10 == NumerosSaidos[i])
                {
                    label10.Text = "X" + campo10;
                }

                if (campo11 == NumerosSaidos[i])
                {
                    label11.Text = "X" + campo11;
                }

                if (campo12 == NumerosSaidos[i])
                {
                    label12.Text = "X" + campo12;;
                }

                if (campo13 == NumerosSaidos[i])
                {
                    label13.Text = "X" + campo13;
                }

                if (campo14 == NumerosSaidos[i])
                {
                    label14.Text = "X" + campo14;
                }

                if (campo15 == NumerosSaidos[i])
                {
                    label15.Text = "X" + campo15;
                }

                if (campo16 == NumerosSaidos[i])
                {
                    label16.Text = "X" + campo16;
                }

            }

            txtNumerosSorteados.Text = "Numeros já sorteados: " + resultado;

            if (label1.Text.Contains("X" + campo1) && label2.Text.Contains("X" + campo2) && label3.Text.Contains("X" + campo3)
                && label4.Text.Contains("X" + campo4) && label5.Text.Contains("X" + campo5) && label6.Text.Contains("X" + campo6)
                && label7.Text.Contains("X" + campo7) && label8.Text.Contains("X" + campo8) && label9.Text.Contains("X" + campo9)
                && label10.Text.Contains("X" + campo10) && label11.Text.Contains("X" + campo11) && label12.Text.Contains("X" + campo12)
                && label13.Text.Contains("X" + campo13) && label14.Text.Contains("X" + campo14) && label15.Text.Contains("X" + campo15)
                && label16.Text.Contains("X" + campo16))
            {
                MessageBox.Show("BINGO!!");
                LimpaCampo();
            }

            if (NumerosSaidos.Count == 200)
            {
                MessageBox.Show("Voce Perdeu!!");
                LimpaCampo();
            }

        }


    
}
}
