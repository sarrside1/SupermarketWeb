namespace SupermarketWeb.Data.Dtos
{
    public class ProductStore
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }
        public decimal price { get; set; }
        public string? description { get; set; }
        public int DepartmentId { get; set; }
        public int StoreId { get; set; }
        public decimal SellingPrice { get; set; }
        public string? barcode { get; set; }
        public DepartmentModel Department { get; set; }= new DepartmentModel();
    }
}