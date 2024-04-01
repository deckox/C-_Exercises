namespace FR1
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
            this.txt_tabuada = new System.Windows.Forms.TextBox();
            this.btn_geraTabuada = new System.Windows.Forms.Button();
            this.txt_retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tabuada
            // 
            this.txt_tabuada.Location = new System.Drawing.Point(13, 13);
            this.txt_tabuada.Name = "txt_tabuada";
            this.txt_tabuada.Size = new System.Drawing.Size(100, 20);
            this.txt_tabuada.TabIndex = 0;
            // 
            // btn_geraTabuada
            // 
            this.btn_geraTabuada.Location = new System.Drawing.Point(109, 12);
            this.btn_geraTabuada.Name = "btn_geraTabuada";
            this.btn_geraTabuada.Size = new System.Drawing.Size(93, 21);
            this.btn_geraTabuada.TabIndex = 1;
            this.btn_geraTabuada.Text = "Gera Tabuada";
            this.btn_geraTabuada.UseVisualStyleBackColor = true;
            this.btn_geraTabuada.Click += new System.EventHandler(this.btn_geraTabuada_Click);
            // 
            // txt_retorno
            // 
            this.txt_retorno.AutoSize = true;
            this.txt_retorno.Location = new System.Drawing.Point(13, 40);
            this.txt_retorno.Name = "txt_retorno";
            this.txt_retorno.Size = new System.Drawing.Size(35, 13);
            this.txt_retorno.TabIndex = 2;
            this.txt_retorno.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_retorno);
            this.Controls.Add(this.btn_geraTabuada);
            this.Controls.Add(this.txt_tabuada);
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tabuada;
        private System.Windows.Forms.Button btn_geraTabuada;
        private System.Windows.Forms.Label txt_retorno;
    }
}

