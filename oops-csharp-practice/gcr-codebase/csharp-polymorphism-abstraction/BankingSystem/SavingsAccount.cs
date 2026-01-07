using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.BankingSystem
{
    internal class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return GetBalance() * 0.04;
        }

        public void ApplyForLoan()
        {
            // Loan application logic
        }

        public double CalculateLoanEligibility()
        {
            return GetBalance() * 5;
        }
    }
}
