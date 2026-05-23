using System;

namespace ArayuzOzellikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen1 = new Ucgen
            {
                Kenar1Uzunluk = 20
            };

            Ucgen ucgen2 = new Ucgen
            {
                Kenar1Uzunluk = 20,
                Kenar2Uzunluk = 15
            };

            Ucgen ucgen3 = new Ucgen
            {
                Kenar1Uzunluk = 20,
                Kenar2Uzunluk = 15,
                Kenar3Uzunluk = 10
            };

            Console.WriteLine("Ucgenler olusturuldu.");
            Console.ReadKey();
        }
    }

    class Ucgen
    {
        private int kenar1Uzunluk = 10;
        private int kenar2Uzunluk = 10;
        private int kenar3Uzunluk = 10;

        public int Kenar1Uzunluk
        {
            set { this.kenar1Uzunluk = value; }
        }

        public int Kenar2Uzunluk
        {
            set { this.kenar2Uzunluk = value; }
        }

        public int Kenar3Uzunluk
        {
            set { this.kenar3Uzunluk = value; }
        }
    }
}