using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace objektiStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"D:\My Documents\NOOP\datoteka.txt");
            sw.WriteLine("Ime: { 0}", ime);
            sw.WriteLine("Prezime: { 0}", prezime);
            sw.Close();
        }
    }
}
