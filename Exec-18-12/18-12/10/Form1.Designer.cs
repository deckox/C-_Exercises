namespace _10
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
            this.btnTwitar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstTimeline = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 50;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 85);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTwitar
            // 
            this.btnTwitar.Location = new System.Drawing.Point(336, 12);
            this.btnTwitar.Name = "btnTwitar";
            this.btnTwitar.Size = new System.Drawing.Size(81, 85);
            this.btnTwitar.TabIndex = 1;
            this.btnTwitar.Text = "Twitar";
            this.btnTwitar.UseVisualStyleBackColor = true;
            this.btnTwitar.Click += new System.EventHandler(this.btnTwitar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(12, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(405, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "50 caracteres disponiveis, 0 caracteres utilizados";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTimeline
            // 
            this.lstTimeline.FormattingEnabled = true;
            this.lstTimeline.Location = new System.Drawing.Point(12, 135);
            this.lstTimeline.Name = "lstTimeline";
            this.lstTimeline.Size = new System.Drawing.Size(405, 381);
            this.lstTimeline.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 533);
            this.Controls.Add(this.lstTimeline);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTwitar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Twitter do Moises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTwitar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstTimeline;
    }
}

