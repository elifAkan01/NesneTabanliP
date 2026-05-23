using System;

namespace modul11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranPozisyonu orijin = new EkranPozisyonu(0, 0);

            int xPos = orijin.X;

            int xpos = orijin.OkuX();

            orijin.YazX(xpos + 10);

            orijin.X += 10;

            EkranPozisyonu2 orijin2 = new EkranPozisyonu2(0, 0);

            int xpoz = orijin2.X;

            int ypoz = orijin2.Y;

            Console.WriteLine(orijin2.X);

            orijin2.X = 200;

            orijin2.X += 10;

            Console.ReadKey();
        }
    }
}