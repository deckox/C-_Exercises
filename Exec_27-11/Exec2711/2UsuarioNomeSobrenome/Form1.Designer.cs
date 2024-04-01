namespace _2UsuarioNomeSobrenome
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_mostra = new System.Windows.Forms.Button();
            this.retorno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(195, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 20);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_mostra
            // 
            this.btn_mostra.Location = new System.Drawing.Point(195, 38);
            this.btn_mostra.Name = "btn_mostra";
            this.btn_mostra.Size = new System.Drawing.Size(75, 23);
            this.btn_mostra.TabIndex = 2;
            this.btn_mostra.Text = "Mostra";
            this.btn_mostra.UseVisualStyleBackColor = true;
            this.btn_mostra.Click += new System.EventHandler(this.btn_mostra_Click);
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(13, 43);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(95, 13);
            this.retorno.TabIndex = 3;
            this.retorno.Text = "Adicione o nome...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.btn_mostra);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_mostra;
        private System.Windows.Forms.Label retorno;
        private System.Windows.Forms.TextBox textBox1;
    }
}

