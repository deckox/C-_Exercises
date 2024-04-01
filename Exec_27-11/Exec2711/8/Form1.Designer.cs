namespace _8
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exibe = new System.Windows.Forms.Button();
            this.btn_apaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(120, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exibe
            // 
            this.btn_exibe.Location = new System.Drawing.Point(120, 42);
            this.btn_exibe.Name = "btn_exibe";
            this.btn_exibe.Size = new System.Drawing.Size(75, 23);
            this.btn_exibe.TabIndex = 2;
            this.btn_exibe.Text = "Exibe";
            this.btn_exibe.UseVisualStyleBackColor = true;
            this.btn_exibe.Click += new System.EventHandler(this.btn_exibe_Click);
            // 
            // btn_apaga
            // 
            this.btn_apaga.Location = new System.Drawing.Point(120, 71);
            this.btn_apaga.Name = "btn_apaga";
            this.btn_apaga.Size = new System.Drawing.Size(75, 23);
            this.btn_apaga.TabIndex = 3;
            this.btn_apaga.Text = "Apagar";
            this.btn_apaga.UseVisualStyleBackColor = true;
            this.btn_apaga.Click += new System.EventHandler(this.btn_apaga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 274);
            this.Controls.Add(this.btn_apaga);
            this.Controls.Add(this.btn_exibe);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exibe;
        private System.Windows.Forms.Button btn_apaga;
    }
}

