using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.BankingSystem
{
    internal abstract class BankAccount
    {
        private string AccountNumber;
        private string HolderName;
        private double Balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public void SetAccountNumber(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public string GetHolderName()
        {
            return HolderName;
        }

        public void SetHolderName(string holderName)
        {
            HolderName = holderName;
        }

        public double GetBalance()
        {
            return Balance;
        }

        protected void SetBalance(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public abstract double CalculateInterest();
    }
}
