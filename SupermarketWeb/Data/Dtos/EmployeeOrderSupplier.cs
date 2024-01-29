namespace SupermarketWeb.Data.Dtos
{
    


    public class EmployeeOrderSupplier
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string invoiceCode { get; set; }
        public string status { get; set; }
        public int employeeId { get; set; }
        public Employee employee { get; set; }
        public Store store { get; set; }
        public List<Purcharssing> purchassings { get; set; }
        public decimal totalBill { get; set; }
    }

    public class Store
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}