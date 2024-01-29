namespace SupermarketWeb.Data.Dtos
{
    public class EmployeeOrder
    {
        public DateTime date { get; set; }
        public string? invoiceCode { get; set; }
        public char? status { get; set; }
        public int employeeId { get; set; }
        public int StoreId { get; set; }
        public List<Purcharssing> Purcharssings { get; set; } = new List<Purcharssing>();
    }
}