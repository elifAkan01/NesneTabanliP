using System;

namespace modul9_2
{
    class Program
    {
        static Sepet sepetim = new Sepet();

        static void Main(string[] args)
        {
            sepetim.UrunEklendi += new Sepet.SepetHandler(ToplamHesapla);

            while (true)
            {
                Urun yeniUrun = new Urun();
                Console.Write("Urun Adi: ");
                yeniUrun.Ad = Console.ReadLine();
                Console.Write("Fiyati: ");
                yeniUrun.Fiyat = Convert.ToDouble(Console.ReadLine());

                sepetim.Ekle(yeniUrun);
                Console.WriteLine(" ");
            }
        }

        static void ToplamHesapla()
        {
            Console.WriteLine("Toplam Tutar Guncellendi: " + sepetim.ToplamTutar());
        }
    }
}