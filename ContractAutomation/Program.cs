using ContractAutomation.Entities;
using ContractAutomation.Services;

namespace ContractAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            //int number = int.Parse(Console.ReadLine());
            int number = 8028;
            Console.Write("Date (dd/MM/yyyy): ");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime date = DateTime.Parse("25/06/2018");
            Console.Write("Contract value: ");
            //double totalValue = double.Parse(Console.ReadLine());
            double totalValue = 600;
            Console.Write("Enter number of installments: ");
            //int months = int.Parse(Console.ReadLine());
            int months = 3;
            Console.WriteLine("Installments:");

            Contract contract = new(number, date, totalValue);
            ContractService contractService = new(new PaypalService());
            contractService.ProcessContract(contract, months);

            foreach (var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}