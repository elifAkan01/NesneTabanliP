using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Invoice Invoice { get; set; } = new();

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            var invoice = _context.Invoices.Find(id);
            if (invoice == null) return NotFound();

            Invoice = invoice;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Invoices.Update(Invoice);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}