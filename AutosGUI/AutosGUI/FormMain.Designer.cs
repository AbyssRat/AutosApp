namespace AutosGUI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKölcsönzésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kölcsönzésekSzámaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legdrágábbKölcsönzésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legnépszerűbbAutómárkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSzures = new System.Windows.Forms.TextBox();
            this.btnSzures = new System.Windows.Forms.Button();
            this.lblStatisztika = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.statisztikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újKölcsönzésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újKölcsönzésToolStripMenuItem
            // 
            this.újKölcsönzésToolStripMenuItem.Name = "újKölcsönzésToolStripMenuItem";
            this.újKölcsönzésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újKölcsönzésToolStripMenuItem.Text = "Új kölcsönzés";
            this.újKölcsönzésToolStripMenuItem.Click += new System.EventHandler(this.újKölcsönzésToolStripMenuItem_Click);
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kölcsönzésekSzámaToolStripMenuItem,
            this.legdrágábbKölcsönzésToolStripMenuItem,
            this.legnépszerűbbAutómárkaToolStripMenuItem});
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // kölcsönzésekSzámaToolStripMenuItem
            // 
            this.kölcsönzésekSzámaToolStripMenuItem.Name = "kölcsönzésekSzámaToolStripMenuItem";
            this.kölcsönzésekSzámaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.kölcsönzésekSzámaToolStripMenuItem.Text = "Kölcsönzések száma";
            this.kölcsönzésekSzámaToolStripMenuItem.Click += new System.EventHandler(this.kölcsönzésekSzámaToolStripMenuItem_Click);
            // 
            // legdrágábbKölcsönzésToolStripMenuItem
            // 
            this.legdrágábbKölcsönzésToolStripMenuItem.Name = "legdrágábbKölcsönzésToolStripMenuItem";
            this.legdrágábbKölcsönzésToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.legdrágábbKölcsönzésToolStripMenuItem.Text = "Legdrágább kölcsönzés";
            this.legdrágábbKölcsönzésToolStripMenuItem.Click += new System.EventHandler(this.legdrágábbKölcsönzésToolStripMenuItem_Click);
            // 
            // legnépszerűbbAutómárkaToolStripMenuItem
            // 
            this.legnépszerűbbAutómárkaToolStripMenuItem.Name = "legnépszerűbbAutómárkaToolStripMenuItem";
            this.legnépszerűbbAutómárkaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.legnépszerűbbAutómárkaToolStripMenuItem.Text = "Legnépszerűbb autómárka";
            this.legnépszerűbbAutómárkaToolStripMenuItem.Click += new System.EventHandler(this.legnépszerűbbAutómárkaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtSzures
            // 
            this.txtSzures.Location = new System.Drawing.Point(246, 27);
            this.txtSzures.Name = "txtSzures";
            this.txtSzures.Size = new System.Drawing.Size(100, 20);
            this.txtSzures.TabIndex = 2;
            this.txtSzures.TextChanged += new System.EventHandler(this.txtSzures_TextChanged);
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(246, 71);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(75, 23);
            this.btnSzures.TabIndex = 3;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // lblStatisztika
            // 
            this.lblStatisztika.AutoSize = true;
            this.lblStatisztika.Location = new System.Drawing.Point(246, 144);
            this.lblStatisztika.Name = "lblStatisztika";
            this.lblStatisztika.Size = new System.Drawing.Size(35, 13);
            this.lblStatisztika.TabIndex = 4;
            this.lblStatisztika.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatisztika);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.txtSzures);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Autók";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKölcsönzésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kölcsönzésekSzámaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legdrágábbKölcsönzésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legnépszerűbbAutómárkaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSzures;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Label lblStatisztika;
    }
}

