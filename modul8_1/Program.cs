using System;

namespace modul8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci("Elif AKAN");

            Console.WriteLine("Öğrencimiz {0}'un Boyu {1}, kilosu ise {2}",
                birOgrenci.Ad, birOgrenci.Boy, birOgrenci.Kilo);

            Console.ReadKey();
        }
    }
}