namespace _4_Fahrenheit
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
            this.btn_Fahrenheit = new System.Windows.Forms.Button();
            this.txt_Fahrenheit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fahrenheit
            // 
            this.btn_Fahrenheit.Location = new System.Drawing.Point(119, 13);
            this.btn_Fahrenheit.Name = "btn_Fahrenheit";
            this.btn_Fahrenheit.Size = new System.Drawing.Size(75, 20);
            this.btn_Fahrenheit.TabIndex = 0;
            this.btn_Fahrenheit.Text = "Fahrenheit";
            this.btn_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_Fahrenheit.Click += new System.EventHandler(this.btn_Fahrenheit_Click);
            // 
            // txt_Fahrenheit
            // 
            this.txt_Fahrenheit.Location = new System.Drawing.Point(13, 13);
            this.txt_Fahrenheit.Name = "txt_Fahrenheit";
            this.txt_Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txt_Fahrenheit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 211);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Fahrenheit);
            this.Controls.Add(this.btn_Fahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Fahrenheit;
        private System.Windows.Forms.TextBox txt_Fahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

