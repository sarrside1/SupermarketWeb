namespace SupermarketWeb.Data.Dtos
{
    public class PaymentModel
    {
        public decimal TotalAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public TypePayment? PaymentType { get; set; }
    }

    public enum TypePayment
    {
		CASH,
		CARD,
		QRCODE
    }
}