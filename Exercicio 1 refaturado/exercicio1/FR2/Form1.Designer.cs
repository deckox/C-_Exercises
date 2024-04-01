namespace FR2
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
            this.retorno_txt = new System.Windows.Forms.Label();
            this.btn_tabuada = new System.Windows.Forms.Button();
            this.txt_ate = new System.Windows.Forms.TextBox();
            this.txt_de = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // retorno_txt
            // 
            this.retorno_txt.AutoSize = true;
            this.retorno_txt.Location = new System.Drawing.Point(12, 96);
            this.retorno_txt.Name = "retorno_txt";
            this.retorno_txt.Size = new System.Drawing.Size(35, 13);
            this.retorno_txt.TabIndex = 0;
            this.retorno_txt.Text = "label1";
            // 
            // btn_tabuada
            // 
            this.btn_tabuada.Location = new System.Drawing.Point(108, 12);
            this.btn_tabuada.Name = "btn_tabuada";
            this.btn_tabuada.Size = new System.Drawing.Size(255, 43);
            this.btn_tabuada.TabIndex = 1;
            this.btn_tabuada.Text = "Gera Tabuada";
            this.btn_tabuada.UseVisualStyleBackColor = true;
            this.btn_tabuada.Click += new System.EventHandler(this.btn_tabuada_Click);
            // 
            // txt_ate
            // 
            this.txt_ate.Location = new System.Drawing.Point(39, 35);
            this.txt_ate.Name = "txt_ate";
            this.txt_ate.Size = new System.Drawing.Size(63, 20);
            this.txt_ate.TabIndex = 2;
            // 
            // txt_de
            // 
            this.txt_de.Location = new System.Drawing.Point(39, 12);
            this.txt_de.Name = "txt_de";
            this.txt_de.Size = new System.Drawing.Size(63, 20);
            this.txt_de.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ate";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 64);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 23);
            this.progressBar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 340);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_de);
            this.Controls.Add(this.txt_ate);
            this.Controls.Add(this.btn_tabuada);
            this.Controls.Add(this.retorno_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label retorno_txt;
        private System.Windows.Forms.Button btn_tabuada;
        private System.Windows.Forms.TextBox txt_ate;
        private System.Windows.Forms.TextBox txt_de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

