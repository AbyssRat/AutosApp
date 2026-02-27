using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AutosApp;
using System.Globalization;

namespace AutosApp
{
    class Kolcsonzes
    {
        public int KolcsonzesSzama { get; set; }
        public string Ugyfel { get; set; }
        public string Rendszam { get; set; }
        public string AutoMarka { get; set; }
        public string AutoModell { get; set; }
        public double NapiDij { get; set; }
        public DateTime Mettol { get; set; }
        public DateTime Meddig { get; set; }

        public int IdotartamNapok()
        {
            return (Meddig - Mettol).Days + 1;
        }

        public double TeljesDij()
        {
            return IdotartamNapok() * NapiDij;
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        string fajlNev = "kolcsonzesek.csv";
        List<Kolcsonzes> lista = new List<Kolcsonzes>();

        foreach (var sor in File.ReadAllLines(fajlNev).Skip(1))

        {
            var adatok = sor.Replace("\"", "").Split(';');

            lista.Add(new Kolcsonzes
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

        // 1. Kölcsönzések száma
        Console.WriteLine($"Kölcsönzések száma: {lista.Count}");

        // 2. Legdrágább kölcsönzés
        var legdragabb = lista.OrderByDescending(x => x.TeljesDij()).First();
        Console.WriteLine($"Legdrágább kölcsönzés: {legdragabb.AutoMarka} {legdragabb.AutoModell}, Díj: {legdragabb.TeljesDij()} Ft");

        // 3. Legnépszerűbb autómárka
        var legnepszerubbMarka = lista
            .GroupBy(x => x.AutoMarka)
            .OrderByDescending(g => g.Count())
            .First();

        Console.WriteLine($"Legnépszerűbb autómárka: {legnepszerubbMarka.Key} ({legnepszerubbMarka.Count()} db)");

        // 4. Legtöbbet kölcsönző ügyfél
        var legtobbUgyfel = lista
            .GroupBy(x => x.Ugyfel)
            .OrderByDescending(g => g.Count())
            .First();

        Console.WriteLine($"Legtöbbet kölcsönző ügyfél: {legtobbUgyfel.Key} ({legtobbUgyfel.Count()} db)");

        // 5. Átlagos időtartam
        double atlagIdotartam = lista.Average(x => x.IdotartamNapok());
        Console.WriteLine($"Átlagos időtartam: {atlagIdotartam:F2} nap");

        // 6. Összesített díj
        double osszesDij = lista.Sum(x => x.TeljesDij());
        Console.WriteLine($"Összesített díj: {osszesDij} Ft");

        // 7. 2025 decemberi kölcsönzések száma
        int december2025 = lista.Count(x =>
            x.Mettol.Year == 2025 && x.Mettol.Month == 12);

        Console.WriteLine($"2025 decemberi kölcsönzések száma: {december2025}");

        // 8. Adott ügyfél kölcsönzései
        Console.Write("\nAdja meg az ügyfél nevét: ");
        string keresettUgyfel = Console.ReadLine();

        var ugyfelKolcsonzesek = lista
            .Where(x => x.Ugyfel.Equals(keresettUgyfel, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (ugyfelKolcsonzesek.Count == 0)
        {
            Console.WriteLine("Nincs ilyen ügyfél.");
        }
        else
        {
            Console.WriteLine($"\n{keresettUgyfel} kölcsönzései:");

            foreach (var k in ugyfelKolcsonzesek)
            {
                Console.WriteLine($"{k.AutoMarka} {k.AutoModell} | {k.Mettol:yyyy.MM.dd} - {k.Meddig:yyyy.MM.dd} | {k.TeljesDij()} Ft");
            }

            // 9. Mentés fájlba
            string ujFajlNev = $"{keresettUgyfel}_kolcsonzesei.csv";

            using (StreamWriter sw = new StreamWriter(ujFajlNev))
            {
                sw.WriteLine("Automarka;Automodell;Mettol;Meddig;Teljes_dij");

                foreach (var k in ugyfelKolcsonzesek)
                {
                    sw.WriteLine($"{k.AutoMarka};{k.AutoModell};{k.Mettol:yyyy-MM-dd};{k.Meddig:yyyy-MM-dd};{k.TeljesDij()}");
                }
            }

            Console.WriteLine($"Adatok elmentve: {ujFajlNev}");
        }

        Console.ReadKey();
    }
}
        
   
