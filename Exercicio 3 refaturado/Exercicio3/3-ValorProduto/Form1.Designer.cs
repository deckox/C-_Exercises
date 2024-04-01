namespace _3_ValorProduto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculo = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_retorno = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calculo
            // 
            this.btn_calculo.Location = new System.Drawing.Point(208, 48);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(75, 20);
            this.btn_calculo.TabIndex = 0;
            this.btn_calculo.Text = "Calculo";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(12, 25);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(35, 20);
            this.txt_quantidade.TabIndex = 1;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(53, 25);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(100, 20);
            this.txt_produto.TabIndex = 2;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(159, 25);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(43, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qtd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_retorno
            // 
            this.label_retorno.AutoSize = true;
            this.label_retorno.Location = new System.Drawing.Point(12, 48);
            this.label_retorno.Name = "label_retorno";
            this.label_retorno.Size = new System.Drawing.Size(35, 13);
            this.label_retorno.TabIndex = 7;
            this.label_retorno.Text = "label4";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(208, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 20);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 80);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_retorno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_calculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_retorno;
        private System.Windows.Forms.Button btn_add;
    }
}

