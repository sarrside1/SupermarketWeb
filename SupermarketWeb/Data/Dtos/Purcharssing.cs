namespace SupermarketWeb.Data.Dtos
{
    public class Purcharssing
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsValidated { get; set; }
    }
}