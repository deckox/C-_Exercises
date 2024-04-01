namespace _4_1
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
            this.campoNumero = new System.Windows.Forms.TextBox();
            this.btnsomatoria = new System.Windows.Forms.Button();
            this.retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoNumero
            // 
            this.campoNumero.Location = new System.Drawing.Point(12, 12);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.Size = new System.Drawing.Size(100, 20);
            this.campoNumero.TabIndex = 1;
            // 
            // btnsomatoria
            // 
            this.btnsomatoria.Location = new System.Drawing.Point(12, 38);
            this.btnsomatoria.Name = "btnsomatoria";
            this.btnsomatoria.Size = new System.Drawing.Size(75, 23);
            this.btnsomatoria.TabIndex = 2;
            this.btnsomatoria.Text = "Somatoria";
            this.btnsomatoria.UseVisualStyleBackColor = true;
            this.btnsomatoria.Click += new System.EventHandler(this.btnsomatoria_Click);
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(12, 64);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(112, 13);
            this.retorno.TabIndex = 3;
            this.retorno.Text = "Aguardando numero...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.btnsomatoria);
            this.Controls.Add(this.campoNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNumero;
        private System.Windows.Forms.Button btnsomatoria;
        private System.Windows.Forms.Label retorno;
    }
}

