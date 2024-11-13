using System.ComponentModel.DataAnnotations;

namespace smartsheet
{
    public class Stocks
    {
        [Key]
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int StockQuantity { get; set; }
        public float BuyPrice { get; set; }
        public float SalePrice { get; set; }
        public DateTime DateAdded { get; set; }
        public string Status { get; set; }
    }
}
