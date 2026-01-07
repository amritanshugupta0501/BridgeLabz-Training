using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[]
            {
            new SavingsAccount("SA-101", "Alice Smith", 5000.00),
            new CurrentAccount("CA-202", "Bob Jones", 12000.00),
            new SavingsAccount("SA-303", "Charlie Brown", 1500.00)
            };

            ProcessAccounts(accounts);
        }

        public static void ProcessAccounts(BankAccount[] accounts)
        {
            Console.WriteLine("Processing Bank Accounts...\n");

            foreach (BankAccount account in accounts)
            {
                double interest = account.CalculateInterest();
                double loanAmount = 0;

                if (account is ILoanable)
                {
                    loanAmount = ((ILoanable)account).CalculateLoanEligibility();
                }

                Console.WriteLine("Account Holder: " + account.GetHolderName());
                Console.WriteLine("Account Number: " + account.GetAccountNumber());
                Console.WriteLine("Current Balance: $" + account.GetBalance());
                Console.WriteLine("Interest Earned: $" + interest);

                if (account is ILoanable)
                {
                    Console.WriteLine("Max Loan Eligibility: $" + loanAmount);
                }
            }
        }
    }
}
