namespace SupermarketWeb.Data.Dtos
{
    public class CustomerOrderModel
    {
        public string invoiceCode { get; set; }
        public int customerId { get; set; }
        public int cashierId { get; set; }
        public List<Sale> Sales{ get; set; } = new List<Sale>();
        public PaymentModel Payment {get; set;} = new PaymentModel();
    }
}