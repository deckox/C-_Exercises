namespace extra
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
            this.bntMostraArray = new System.Windows.Forms.Button();
            this.bntOrdenaArray = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntMostraArray
            // 
            this.bntMostraArray.Location = new System.Drawing.Point(43, 32);
            this.bntMostraArray.Name = "bntMostraArray";
            this.bntMostraArray.Size = new System.Drawing.Size(75, 23);
            this.bntMostraArray.TabIndex = 0;
            this.bntMostraArray.Text = "MostraArray";
            this.bntMostraArray.UseVisualStyleBackColor = true;
            this.bntMostraArray.Click += new System.EventHandler(this.bntMostraArray_Click);
            // 
            // bntOrdenaArray
            // 
            this.bntOrdenaArray.Location = new System.Drawing.Point(43, 110);
            this.bntOrdenaArray.Name = "bntOrdenaArray";
            this.bntOrdenaArray.Size = new System.Drawing.Size(75, 23);
            this.bntOrdenaArray.TabIndex = 1;
            this.bntOrdenaArray.Text = "OrdenaArray";
            this.bntOrdenaArray.UseVisualStyleBackColor = true;
            this.bntOrdenaArray.Click += new System.EventHandler(this.bntOrdenaArray_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "OrdernaArrayC#";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(165, 41);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(35, 13);
            this.lblOriginal.TabIndex = 3;
            this.lblOriginal.Text = "label1";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(169, 119);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(35, 13);
            this.lblOrdenado.TabIndex = 4;
            this.lblOrdenado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 250);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntOrdenaArray);
            this.Controls.Add(this.bntMostraArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntMostraArray;
        private System.Windows.Forms.Button bntOrdenaArray;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblOrdenado;
    }
}

