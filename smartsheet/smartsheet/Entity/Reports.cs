namespace smartsheet
{
    public class Reports
    {
        public int ReportId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float TotalSales { get; set; }
        public int TotalQuantitySold { get; set; }
        public float TotalStockValue { get; set; }
        public float TotalIncome { get; set; }
        public DateTime GeneratedDate { get; set; }
    }
}
