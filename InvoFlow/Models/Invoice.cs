using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fatura numarası boş bırakılamaz.")]
        public string Number { get; set; } = string.Empty;

        [Required(ErrorMessage = "Müşteri adı zorunludur.")]
        public string ClientName { get; set; } = string.Empty;

        [Required]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hizmet alanı boş bırakılamaz.")]
        public string Service { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal UnitPrice { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Miktar en az 1 olmalıdır.")]
        public int Quantity { get; set; }

        public string Status { get; set; } = "Pending";
        public DateTime? IssueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Phone { get; set; }
    }
}