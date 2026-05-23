using System;
using System.Data.Linq;
using System.Linq;

namespace modul10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string baglanti =
                @"Server=ELIF;Database=Northwind;Trusted_Connection=True;";

            try
            {
                DataContext context =
                    new DataContext(baglanti);

                Table<Customer> Customers =
                    context.GetTable<Customer>();

                var q =
                    from c in Customers
                    where c.City == "Berlin"
                    select c;

                Console.WriteLine("BERLIN MÜŞTERİLERİ");
                Console.WriteLine("");

                foreach (var item in q)
                {
                    Console.WriteLine("Şirket : " + item.CompanyName);
                    Console.WriteLine("Adres  : " + item.Address);
                    Console.WriteLine("Telefon: " + item.Phone);
                    Console.WriteLine("Fax    : " + item.Fax);

                    Console.WriteLine("");
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata oluştu!");
                Console.WriteLine(hata.Message);
            }

            Console.ReadLine();
        }
    }
}