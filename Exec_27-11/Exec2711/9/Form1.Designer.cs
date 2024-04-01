namespace _9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_frase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_frase
            // 
            this.btn_frase.Location = new System.Drawing.Point(12, 45);
            this.btn_frase.Name = "btn_frase";
            this.btn_frase.Size = new System.Drawing.Size(75, 23);
            this.btn_frase.TabIndex = 0;
            this.btn_frase.Text = "Frase";
            this.btn_frase.UseVisualStyleBackColor = true;
            this.btn_frase.Click += new System.EventHandler(this.btn_frase_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(12, 75);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(74, 13);
            this.retorno.TabIndex = 2;
            this.retorno.Text = "Aguardando...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 125);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_frase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_frase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label retorno;
    }
}

