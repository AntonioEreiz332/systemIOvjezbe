using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace naredbaUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            // Podatke upisujemo u datoteku
            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter sw = new StreamWriter(@"D:\My Documents\NOOP\datoteka.txt"))
            {
                sw.WriteLine("Ime: { 0}", ime);
                sw.WriteLine("Prezime: { 0}", prezime);
            }
        }
    }
}
