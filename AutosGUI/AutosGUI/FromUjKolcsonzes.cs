using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutosGUI
{
    public partial class FromUjKolcsonzes : Form
    {
        public FromUjKolcsonzes()
        {
            InitializeComponent();
        }

        private void FromUjKolcsonzes_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            string fajlNev = "kolcsonzesek.csv";
            int ujId = File.ReadAllLines(fajlNev).Length;

            string ujSor = $"\"{ujId}\";\"{txtUgyfel.Text}\";\"{txtRendszam.Text}\";\"{txtMarka.Text}\";\"{txtModell.Text}\";\"{txtNapidij.Text}\";\"{dtpMettol.Value:yyyy-MM-dd}\";\"{dtpMeddig.Value:yyyy-MM-dd}\"";

            File.AppendAllText(fajlNev, Environment.NewLine + ujSor);

            MessageBox.Show("Sikeres mentés!");
            this.Close();
        }
    }
}
