
namespace WebApplication1.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; } // Clave foránea
        public int InvoiceId { get; set; } // Clave foránea
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }

        // Propiedades de navegación
        public Product Product { get; set; }
        public Invoice Invoice { get; set; }
    }






}
