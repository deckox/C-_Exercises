namespace _4
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
            this.txt_campo = new System.Windows.Forms.TextBox();
            this.btn_numeros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_campo
            // 
            this.txt_campo.Location = new System.Drawing.Point(12, 12);
            this.txt_campo.Name = "txt_campo";
            this.txt_campo.Size = new System.Drawing.Size(100, 20);
            this.txt_campo.TabIndex = 0;
            // 
            // btn_numeros
            // 
            this.btn_numeros.Location = new System.Drawing.Point(118, 12);
            this.btn_numeros.Name = "btn_numeros";
            this.btn_numeros.Size = new System.Drawing.Size(75, 20);
            this.btn_numeros.TabIndex = 1;
            this.btn_numeros.Text = "10 numeros";
            this.btn_numeros.UseVisualStyleBackColor = true;
            this.btn_numeros.Click += new System.EventHandler(this.btn_numeros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_numeros);
            this.Controls.Add(this.txt_campo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_campo;
        private System.Windows.Forms.Button btn_numeros;
        private System.Windows.Forms.Label label1;
    }
}

