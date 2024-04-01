namespace _010118
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
            this.btnQualdia = new System.Windows.Forms.Button();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textMes = new System.Windows.Forms.TextBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQualdia
            // 
            this.btnQualdia.Location = new System.Drawing.Point(12, 51);
            this.btnQualdia.Name = "btnQualdia";
            this.btnQualdia.Size = new System.Drawing.Size(158, 23);
            this.btnQualdia.TabIndex = 0;
            this.btnQualdia.Text = "Que dia é hoje?";
            this.btnQualdia.UseVisualStyleBackColor = true;
            this.btnQualdia.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(12, 12);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(44, 20);
            this.textDia.TabIndex = 1;
            // 
            // textMes
            // 
            this.textMes.Location = new System.Drawing.Point(62, 12);
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(42, 20);
            this.textMes.TabIndex = 2;
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(110, 12);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(60, 20);
            this.textAno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 93);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.textMes);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.btnQualdia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQualdia;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textMes;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

