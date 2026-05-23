using modul11_2;
using System;

namespace ArayuzOzellikleri
{
    struct EkranPozisyonu : IEkranPozisyonu
    {
        int x, y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}