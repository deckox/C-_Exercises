namespace _22012018
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
            this.btn_linha = new System.Windows.Forms.Button();
            this.campoLinha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campoColuna = new System.Windows.Forms.TextBox();
            this.campoX = new System.Windows.Forms.TextBox();
            this.campoY = new System.Windows.Forms.TextBox();
            this.btn_coordenadaX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_linha
            // 
            this.btn_linha.Location = new System.Drawing.Point(57, 24);
            this.btn_linha.Name = "btn_linha";
            this.btn_linha.Size = new System.Drawing.Size(75, 47);
            this.btn_linha.TabIndex = 0;
            this.btn_linha.Text = "Linha e Colunas";
            this.btn_linha.UseVisualStyleBackColor = true;
            this.btn_linha.Click += new System.EventHandler(this.btn_linha_Click);
            // 
            // campoLinha
            // 
            this.campoLinha.Location = new System.Drawing.Point(12, 24);
            this.campoLinha.Name = "campoLinha";
            this.campoLinha.Size = new System.Drawing.Size(39, 20);
            this.campoLinha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // campoColuna
            // 
            this.campoColuna.Location = new System.Drawing.Point(12, 51);
            this.campoColuna.Name = "campoColuna";
            this.campoColuna.Size = new System.Drawing.Size(39, 20);
            this.campoColuna.TabIndex = 4;
            // 
            // campoX
            // 
            this.campoX.Location = new System.Drawing.Point(288, 199);
            this.campoX.Name = "campoX";
            this.campoX.Size = new System.Drawing.Size(39, 20);
            this.campoX.TabIndex = 5;
            // 
            // campoY
            // 
            this.campoY.Location = new System.Drawing.Point(288, 224);
            this.campoY.Name = "campoY";
            this.campoY.Size = new System.Drawing.Size(39, 20);
            this.campoY.TabIndex = 6;
            // 
            // btn_coordenadaX
            // 
            this.btn_coordenadaX.Location = new System.Drawing.Point(333, 198);
            this.btn_coordenadaX.Name = "btn_coordenadaX";
            this.btn_coordenadaX.Size = new System.Drawing.Size(83, 46);
            this.btn_coordenadaX.TabIndex = 7;
            this.btn_coordenadaX.Text = "Coordenadas";
            this.btn_coordenadaX.UseVisualStyleBackColor = true;
            this.btn_coordenadaX.Click += new System.EventHandler(this.btn_coordenadaX_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Linha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coluna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_coordenadaX);
            this.Controls.Add(this.campoY);
            this.Controls.Add(this.campoX);
            this.Controls.Add(this.campoColuna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoLinha);
            this.Controls.Add(this.btn_linha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_linha;
        private System.Windows.Forms.TextBox campoLinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoColuna;
        private System.Windows.Forms.TextBox campoX;
        private System.Windows.Forms.TextBox campoY;
        private System.Windows.Forms.Button btn_coordenadaX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

