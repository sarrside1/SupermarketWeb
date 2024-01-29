namespace SupermarketWeb.Data.Dtos
{
    public class Employee
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public bool status { get; set; }
        public int storeId { get; set; }
        public object store { get; set; }
        public object refreshToken { get; set; }
        public int employeeLevel { get; set; }
    }

    public class OrderModel
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string invoiceCode { get; set; }
        public int customerId { get; set; }
        public int cashierId { get; set; }
        public string status { get; set; }
        public PaymentModel paymentCustomer { get; set; }
        public CustomerModel customer { get; set; }
        public Employee employee { get; set; }
        public decimal totalBill { get; set;}
    }
}