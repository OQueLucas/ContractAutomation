namespace ContractAutomation.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            double total = amount * ((float)2 / (float)100);
            return total;
        }

        public double Interest(double amount, int months)
        {
            double percentual = (1 * months) / (float)100;
            double total = amount * percentual;
            return total;
        }
    }
}
