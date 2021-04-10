using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace klasaPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju izvornog direktorija: ");
            string izvorniDirektorij = Console.ReadLine();
            Console.Write("Unesite putanju ciljnog direktorija: ");
            string ciljniDirektorij = Console.ReadLine();
            try
            {
                // Kopiramo sve datoteke iz izvornog u ciljni direktorij
            foreach (string datoteka in Directory.GetFiles(izvorniDirektorij))
                {
                    // Dohvaćamo ime datoteke (bez putanje)
                    string imeDatoteke = Path.GetFileName(datoteka);
                    // Kreiramo putanju ciljne datoteke
                    string ciljnaDatoteka
                    = Path.Combine(ciljniDirektorij,

                    imeDatoteke);

                    // Kopiramo datoteku s izvorne na ciljnu putanju
                    File.Copy(datoteka, ciljnaDatoteka, true);
                }
                Console.WriteLine("Gotovo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: { 0}", ex.Message);
            }
            Console.ReadKey();

        }
    }
}
