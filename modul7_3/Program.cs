namespace modul7_3
{
    internal class Program
    {
        public static int toplam(params int[] paramList)
        {
            int c = paramList[0]; // En küçük için
            int d = paramList[0]; // En büyük için

            foreach (int i in paramList)
            {
                if (i < c)
                    c = i;
            }
            return c + d;
        }
        static void Main(string[] args)
        {
            int toplamen = Program.toplam(9, 4, 5, 6, 19);

            Console.WriteLine("En Küçük ve En Büyük Sayının Toplamı: " + toplamen);

            Console.Read();
        }
    }
}
