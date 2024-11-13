using System.ComponentModel.DataAnnotations;

namespace smartsheet
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
    }
}
