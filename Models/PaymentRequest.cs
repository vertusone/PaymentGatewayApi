namespace PaymentGatewayApi.Models
{
    public class PaymentRequest
    {
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string Expiry { get; set; }
        public string Cvv { get; set; }
        public decimal Amount { get; set; }
    }
} 