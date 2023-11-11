
namespace WebApplication1.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; } // Clave foránea
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }

        // Propiedades de navegación
        public Customer Customer { get; set; }
        public List<Detail> Details { get; set; }
    }

}
