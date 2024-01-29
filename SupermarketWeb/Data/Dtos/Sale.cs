namespace SupermarketWeb.Data.Dtos
{
    public class Sale
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}