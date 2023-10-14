using ContractAutomation.Entities;

namespace ContractAutomation.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount = contract.TotalValue;
            DateTime date = contract.Date;

            double value = amount / months;

            for (int i = 1; i <= months; i++)
            {
                double fee = _onlinePaymentService.PaymentFee(value);
                double installment = _onlinePaymentService.Interest(value, i);
                double total = value + fee + installment;
                DateTime dueDate = date.AddMonths(i);
                contract.AddInstallment(new Installment(dueDate, total));
            }
        }
    }
}
