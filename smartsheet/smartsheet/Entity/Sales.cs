using System.ComponentModel.DataAnnotations;

namespace smartsheet
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int QuantitySold { get; set; }
        public float SalePrice { get; set; }
        public float TotalAmount { get; set; }
        public float Discount { get; set; }
        public float NetAmount { get; set; }
    }
}
