namespace SupermarketWeb.Data.Dtos
{
    public class User
    {
        public int id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? middlename { get; set; }
        public string? phone { get; set; }
        public string? username { get; set; }
        public string? address { get; set; }
        public bool status { get; set; }
        public int storeId { get; set; }
    }

    public class Supplier
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    
}