using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutosGUI
{
    public partial class FormMain : Form
    {
        List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
        public FormMain()
        {

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Beolvas();
            dataGridView1.DataSource = kolcsonzesek;
            StatisztikaFrissit();
        }

        private void Beolvas()
        {
            kolcsonzesek.Clear();

            foreach (var sor in File.ReadAllLines("kolcsonzesek.csv").Skip(1))
            {
                var adatok = sor.Replace("\"", "").Split(';');

                kolcsonzesek.Add(new Kolcsonzes
                {
                    KolcsonzesSzama = int.Parse(adatok[0]),
                    Ugyfel = adatok[1],
                    Rendszam = adatok[2],
                    AutoMarka = adatok[3],
                    AutoModell = adatok[4],
                    NapiDij = double.Parse(adatok[5], CultureInfo.InvariantCulture),
                    Mettol = DateTime.Parse(adatok[6]),
                    Meddig = DateTime.Parse(adatok[7])
                });
            }
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            string keresett = txtSzures.Text.ToLower();

            var szurt = kolcsonzesek
                .Where(x => x.Ugyfel.ToLower().Contains(keresett))
                .ToList();

            dataGridView1.DataSource = szurt;
        }

        private void txtSzures_TextChanged(object sender, EventArgs e)
        {

        }

        private void újKölcsönzésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromUjKolcsonzes form = new FromUjKolcsonzes();
            form.ShowDialog();

            Beolvas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kolcsonzesek;
        }

        private void kölcsönzésekSzámaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kölcsönzések száma: {kolcsonzesek.Count}");
        }

        private void legdrágábbKölcsönzésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var legdragabb = kolcsonzesek.OrderByDescending(x => x.TeljesDij()).First();

            MessageBox.Show(
                $"{legdragabb.AutoMarka} {legdragabb.AutoModell}\nDíj: {legdragabb.TeljesDij()} Ft");
        }

        private void legnépszerűbbAutómárkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marka = kolcsonzesek
        .GroupBy(x => x.AutoMarka)
        .OrderByDescending(g => g.Count())
        .First();

            MessageBox.Show($"Legnépszerűbb: {marka.Key} ({marka.Count()} db)");
        }

        private void StatisztikaFrissit()
        {
            double atlag = kolcsonzesek.Average(x => x.IdotartamNapok());
            double osszes = kolcsonzesek.Sum(x => x.TeljesDij());

            int december2025 = kolcsonzesek.Count(x =>
                x.Mettol.Year == 2025 && x.Mettol.Month == 12);

            lblStatisztika.Text =
                $"Átlagos időtartam: {atlag:F2} nap\n" +
                $"Összes bevétel: {osszes} Ft\n" +
                $"2025 decemberi kölcsönzések: {december2025}";
        }
    }
}
