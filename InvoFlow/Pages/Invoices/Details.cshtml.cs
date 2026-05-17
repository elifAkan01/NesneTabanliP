using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Invoice Invoice { get; set; } = new();

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            var invoice = _context.Invoices.FirstOrDefault(m => m.Id == id);
            if (invoice == null) return NotFound();

            Invoice = invoice;
            return Page();
        }
    }
}