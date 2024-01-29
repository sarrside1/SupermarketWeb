namespace SupermarketWeb.Data.Dtos
{
    public class StoreModel
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
        public bool Status { get; set; }
        public string StoreType { get; set; }
    }
}