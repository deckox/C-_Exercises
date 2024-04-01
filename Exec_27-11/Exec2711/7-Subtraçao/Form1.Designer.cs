namespace _7_Subtraçao
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(123, 38);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(120, 78);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(52, 13);
            this.retorno.TabIndex = 2;
            this.retorno.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 364);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label retorno;
    }
}

