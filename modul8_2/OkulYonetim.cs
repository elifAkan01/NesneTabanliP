using System;

namespace modul8_2
{
    interface IInsan
    {
        void Buyu();
        void Oku();
    }

    abstract class OkuyanInsan
    {
        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    class Ogrenci : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }
    }

    class Ogretmen : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }
    }
}