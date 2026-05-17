using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Faturalarý tutacaðýmýz liste
        public List<Invoice> invoiceList { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Tek bir OnGet metodu her þeyi halleder. 
        // Eðer searchTerm boþ gelirse tüm listeyi, dolu gelirse filtrelenmiþ listeyi getirir.
        public void OnGet(string? searchTerm)
        {
            // Önce sorgumuzu hazýrlýyoruz (AsQueryable ile veritabanýna henüz gitmiyoruz)
            var query = _context.Invoices.AsQueryable();

            // Eðer kullanýcý arama kutusuna bir þey yazdýysa sorguya filtre ekliyoruz
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(i => i.ClientName.Contains(searchTerm) || i.Number.Contains(searchTerm));
            }

            // Son aþamada verileri ID'ye göre tersten (en yeni en üstte) sýralayýp listeye çeviriyoruz
            invoiceList = query.OrderByDescending(i => i.Id).ToList();
        }
    }
}