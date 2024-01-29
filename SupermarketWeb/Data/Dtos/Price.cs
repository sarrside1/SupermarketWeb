namespace SupermarketWeb.Data.Dtos
{
    public class Price
    {
        public int productId { get; set; }
        public int storeId { get; set; }
        public decimal sellingPrice { get; set; }
        public string? barcode { get; set; }
    }
}