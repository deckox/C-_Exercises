namespace _6
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_retorno = new System.Windows.Forms.Label();
            this.btnBuscarLinq = new System.Windows.Forms.Button();
            this.label_salvo = new System.Windows.Forms.Label();
            this.btnBuscarSequencial = new System.Windows.Forms.Button();
            this.btnBuscarBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 38);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(291, 33);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar!";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label_retorno
            // 
            this.label_retorno.AutoSize = true;
            this.label_retorno.Location = new System.Drawing.Point(12, 170);
            this.label_retorno.Name = "label_retorno";
            this.label_retorno.Size = new System.Drawing.Size(16, 13);
            this.label_retorno.TabIndex = 2;
            this.label_retorno.Text = "...";
            // 
            // btnBuscarLinq
            // 
            this.btnBuscarLinq.Location = new System.Drawing.Point(12, 99);
            this.btnBuscarLinq.Name = "btnBuscarLinq";
            this.btnBuscarLinq.Size = new System.Drawing.Size(93, 55);
            this.btnBuscarLinq.TabIndex = 3;
            this.btnBuscarLinq.Text = "Buscar Linq";
            this.btnBuscarLinq.UseVisualStyleBackColor = true;
            this.btnBuscarLinq.Click += new System.EventHandler(this.btnBuscarLinq_Click);
            // 
            // label_salvo
            // 
            this.label_salvo.AutoSize = true;
            this.label_salvo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salvo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_salvo.Location = new System.Drawing.Point(12, 74);
            this.label_salvo.Name = "label_salvo";
            this.label_salvo.Size = new System.Drawing.Size(23, 16);
            this.label_salvo.TabIndex = 4;
            this.label_salvo.Text = "...";
            // 
            // btnBuscarSequencial
            // 
            this.btnBuscarSequencial.Location = new System.Drawing.Point(111, 99);
            this.btnBuscarSequencial.Name = "btnBuscarSequencial";
            this.btnBuscarSequencial.Size = new System.Drawing.Size(93, 55);
            this.btnBuscarSequencial.TabIndex = 5;
            this.btnBuscarSequencial.Text = "Buscar Sequencial";
            this.btnBuscarSequencial.UseVisualStyleBackColor = true;
            this.btnBuscarSequencial.Click += new System.EventHandler(this.btnBuscarSequencial_Click);
            // 
            // btnBuscarBinario
            // 
            this.btnBuscarBinario.Location = new System.Drawing.Point(210, 101);
            this.btnBuscarBinario.Name = "btnBuscarBinario";
            this.btnBuscarBinario.Size = new System.Drawing.Size(93, 51);
            this.btnBuscarBinario.TabIndex = 6;
            this.btnBuscarBinario.Text = "Buscar Binario";
            this.btnBuscarBinario.UseVisualStyleBackColor = true;
            this.btnBuscarBinario.Click += new System.EventHandler(this.btnBuscarBinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 531);
            this.Controls.Add(this.btnBuscarBinario);
            this.Controls.Add(this.btnBuscarSequencial);
            this.Controls.Add(this.label_salvo);
            this.Controls.Add(this.btnBuscarLinq);
            this.Controls.Add(this.label_retorno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_salvar);
            this.Name = "Form1";
            this.Text = "Busca ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_retorno;
        private System.Windows.Forms.Button btnBuscarLinq;
        private System.Windows.Forms.Label label_salvo;
        private System.Windows.Forms.Button btnBuscarSequencial;
        private System.Windows.Forms.Button btnBuscarBinario;
    }
}

