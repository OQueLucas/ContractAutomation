namespace ContractAutomation.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.2;
        }

        public double Interest (double amount, int months) {
            return amount * (1 * months / 100);
        }
    }
}
