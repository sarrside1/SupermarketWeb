namespace SupermarketWeb.Data.Dtos
{
    public class ProductModel: IProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }=string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }
        public int supplierId { get; set; }
        public int Quantity { get; set; }
        public Supplier? Supplier { get; set; }
        public DepartmentModel Department { get; set; } = new DepartmentModel();
    }
}