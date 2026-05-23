using System.Data.Linq.Mapping;

namespace modul10_1
{
    [Table(Name = "Customers")]
    public class Customer
    {
        [Column]
        public string CompanyName { get; set; }

        [Column]
        public string Address { get; set; }

        [Column]
        public string Phone { get; set; }

        [Column]
        public string Fax { get; set; }

        [Column]
        public string City { get; set; }
    }
}