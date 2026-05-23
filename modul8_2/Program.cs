using System;

namespace modul8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birogrenci = new Ogrenci();
            Ogretmen birogretmen = new Ogretmen();

            birogrenci.Buyu();
            birogretmen.Buyu();
            birogrenci.Oku();
            birogretmen.Oku();

            Console.ReadKey();
        }
    }
}