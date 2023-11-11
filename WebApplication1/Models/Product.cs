namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public bool? Active { get; set; }

        // Propiedades de navegación
        //public List<Detail> Details { get; set; }
    }
}
