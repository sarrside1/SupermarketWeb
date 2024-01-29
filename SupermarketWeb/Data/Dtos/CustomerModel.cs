namespace SupermarketWeb.Data.Dtos
{
    public class CustomerModel
    {
        public int id { get; set; }
        public int storeId { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? middlename { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
    }
}