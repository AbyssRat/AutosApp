namespace AutosGUI
{
    partial class FromUjKolcsonzes
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
            this.txtUgyfel = new System.Windows.Forms.TextBox();
            this.txtRendszam = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModell = new System.Windows.Forms.TextBox();
            this.txtNapidij = new System.Windows.Forms.TextBox();
            this.dtpMettol = new System.Windows.Forms.DateTimePicker();
            this.btnMentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMeddig = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUgyfel
            // 
            this.txtUgyfel.Location = new System.Drawing.Point(167, 28);
            this.txtUgyfel.Name = "txtUgyfel";
            this.txtUgyfel.Size = new System.Drawing.Size(100, 20);
            this.txtUgyfel.TabIndex = 0;
            // 
            // txtRendszam
            // 
            this.txtRendszam.Location = new System.Drawing.Point(167, 73);
            this.txtRendszam.Name = "txtRendszam";
            this.txtRendszam.Size = new System.Drawing.Size(100, 20);
            this.txtRendszam.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(167, 118);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // txtModell
            // 
            this.txtModell.Location = new System.Drawing.Point(167, 163);
            this.txtModell.Name = "txtModell";
            this.txtModell.Size = new System.Drawing.Size(100, 20);
            this.txtModell.TabIndex = 3;
            this.txtModell.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNapidij
            // 
            this.txtNapidij.Location = new System.Drawing.Point(167, 208);
            this.txtNapidij.Name = "txtNapidij";
            this.txtNapidij.Size = new System.Drawing.Size(100, 20);
            this.txtNapidij.TabIndex = 4;
            // 
            // dtpMettol
            // 
            this.dtpMettol.Location = new System.Drawing.Point(167, 253);
            this.dtpMettol.Name = "dtpMettol";
            this.dtpMettol.Size = new System.Drawing.Size(202, 20);
            this.dtpMettol.TabIndex = 5;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(167, 364);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 6;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ügyfél";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rendszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Márka";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Napi Díj";
            // 
            // dtpMeddig
            // 
            this.dtpMeddig.Location = new System.Drawing.Point(167, 298);
            this.dtpMeddig.Name = "dtpMeddig";
            this.dtpMeddig.Size = new System.Drawing.Size(202, 20);
            this.dtpMeddig.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mettől";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Meddig";
            // 
            // FromUjKolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMeddig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.dtpMettol);
            this.Controls.Add(this.txtNapidij);
            this.Controls.Add(this.txtModell);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRendszam);
            this.Controls.Add(this.txtUgyfel);
            this.Name = "FromUjKolcsonzes";
            this.Text = "Új kölcsönzés";
            this.Load += new System.EventHandler(this.FromUjKolcsonzes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUgyfel;
        private System.Windows.Forms.TextBox txtRendszam;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModell;
        private System.Windows.Forms.TextBox txtNapidij;
        private System.Windows.Forms.DateTimePicker dtpMettol;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMeddig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}