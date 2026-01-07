using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.BankingSystem
{
    internal class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return GetBalance() * 0.01;
        }

        public void ApplyForLoan()
        {
            // Loan application logic
        }

        public double CalculateLoanEligibility()
        {
            return GetBalance() * 10;
        }
    }
}
