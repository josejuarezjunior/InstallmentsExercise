namespace Course.Services
{
    class PayPalService : IOnlinePaymentService
    {
        private const double FreePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        
        public double PaymentFee(double amount)
        {
            return amount * FreePercentage ;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
