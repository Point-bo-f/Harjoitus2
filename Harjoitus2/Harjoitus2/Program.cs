using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Lämpötila.txt";
            string uusiTieto = @"C:\Temp\UusiLämpötila2.txt";

            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("aiempi lämpötila oli" + aiempiArvo + " astetta");
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }
            int lämpotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpotila = int.Parse(syöte);

            // Tiedostoon kirjoittaminen

            File.WriteAllText(tiedosto, lämpotila.ToString());
            File.Copy(tiedosto, uusiTieto);
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}
