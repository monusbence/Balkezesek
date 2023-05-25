using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Balkezesek
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<BalkezesekOsztály> balkezesekLista = new List<BalkezesekOsztály>();

            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] szoveg = sr.ReadLine().Split(";");
                balkezesekLista.Add(new BalkezesekOsztály(szoveg[0], Convert.ToDateTime(szoveg[1]), Convert.ToDateTime(szoveg[2]), Convert.ToInt32(szoveg[3]), Convert.ToInt32(szoveg[4])));
            }

            Console.WriteLine($"3. feladat: {balkezesekLista.Count}");

            Console.WriteLine("4. feladat:");
            foreach (BalkezesekOsztály adat in balkezesekLista)
            {
                if (adat.UtolsoPalyaraLepes.Year == 1999 && adat.UtolsoPalyaraLepes.Month == 10)
                {
                    Console.WriteLine($"\t{adat.Nev},{Math.Round(adat.Magassag * 2.54, 1)}cm");
                }
            }

            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
            int bekert = Convert.ToInt32(Console.ReadLine());
            while (!(bekert >= 1990 && bekert <= 1999))
            {
                Console.Write("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!: ");
                bekert = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}