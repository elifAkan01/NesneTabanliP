using System;

namespace modul7_1
{
    class Progrsm
    {
        static void Main(string[] args)
        {
            int[] sayi = { 1, 2, 3, 4 };
            int toplam = 0;

            foreach (int i in sayi)
            {
                toplam = toplam + i;
            }

            Console.WriteLine("Dizi elemanlarının toplamı:" + toplam);
            Console.WriteLine("\nKapatmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }
}