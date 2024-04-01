namespace _7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ler = new System.Windows.Forms.Button();
            this.retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_ler
            // 
            this.btn_ler.Location = new System.Drawing.Point(13, 40);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(473, 23);
            this.btn_ler.TabIndex = 1;
            this.btn_ler.Text = "Ler!";
            this.btn_ler.UseVisualStyleBackColor = true;
            this.btn_ler.Click += new System.EventHandler(this.btn_ler_Click);
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(13, 70);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(74, 13);
            this.retorno.TabIndex = 2;
            this.retorno.Text = "Aguardando...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 116);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.btn_ler);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.Label retorno;
    }
}

