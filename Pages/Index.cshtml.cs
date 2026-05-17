using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Sayfada göstereceğimiz istatistik değişkenleri
        public int TotalInvoices { get; set; }
        public decimal TotalAmount { get; set; }
        public int PendingInvoices { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // LINQ sorguları ile verileri hesaplıyoruz
            TotalInvoices = _context.Invoices.Count();

            // Tüm faturaların toplam tutarı (UnitPrice * Quantity)
            TotalAmount = _context.Invoices.ToList().Sum(i => i.UnitPrice * i.Quantity);

            // Beklemede (Pending) olan faturaların sayısı
            PendingInvoices = _context.Invoices.Count(i => i.Status == "Pending");
        }
    }
}