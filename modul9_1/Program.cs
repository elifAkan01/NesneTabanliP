using System;

namespace modul9_1
{
    class Program
    {
        public delegate void SiralamaHandler(ref string[] dizi);

        static void AlfabetikSirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine("A-Z Siralandi.");
        }

        static void TersSirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            Console.WriteLine("Z-A Siralandi.");
        }

        static void Main(string[] args)
        {
            string[] isimler = { "Zeynep", "Ali", "Metin", "Buse" };

            Console.WriteLine("Siralanmamis Dizi: " + string.Join(", ", isimler));

            SiralamaHandler handler = new SiralamaHandler(AlfabetikSirala);
            handler(ref isimler);
            Console.WriteLine(string.Join(", ", isimler));

            handler = TersSirala;
            handler(ref isimler);
            Console.WriteLine(string.Join(", ", isimler));

            Console.ReadKey();
        }
    }
}