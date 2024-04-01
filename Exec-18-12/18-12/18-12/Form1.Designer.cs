namespace _18_12
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
            this.btn_tabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_tabuada
            // 
            this.btn_tabuada.Location = new System.Drawing.Point(12, 12);
            this.btn_tabuada.Name = "btn_tabuada";
            this.btn_tabuada.Size = new System.Drawing.Size(360, 23);
            this.btn_tabuada.TabIndex = 1;
            this.btn_tabuada.Text = "Gerar Tabuada";
            this.btn_tabuada.UseVisualStyleBackColor = true;
            this.btn_tabuada.Click += new System.EventHandler(this.btn_tabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.Location = new System.Drawing.Point(12, 41);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(360, 277);
            this.lstTabuada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 333);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.btn_tabuada);
            this.Name = "Form1";
            this.Text = "Tabuada do Moises";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_tabuada;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

