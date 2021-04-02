namespace Course.Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount += amount * 0.2;
        }
        public double Interest(double amount, int months)
        {
            return amount += 0.1 * months;
        }
    }
}
