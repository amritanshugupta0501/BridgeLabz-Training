using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to create a custom exception checking insufficient fund in a bank account
    class InsufficientFundException : Exception
    {
        public InsufficientFundException(string message) : base(message) { }
    }
    // Class defined to show characteristic of a bank account i.e. Amount in the account
    class BankAccount
    {
        public double Balance { get; set; }
        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }
        public void WithdrawBalance(double balance)
        {
            if(balance < 0)
            {
                throw new ArgumentException("Withdrawal amount can never be negative");
            }
            else if(balance > Balance)
            {
                throw new InsufficientFundException("Insufficient balance in your account.");
            }
            else
            {
                Balance -= balance;
                Console.WriteLine("Withdrawal is successful. CurrentBalance : "+Balance);
            }
        }
    }
    // Class defined to handle the custom exception during bank transaction system
    internal class BankTransactionSystem
    {
        static void Main(string[] args)
        {
            BankAccount personBankAccount = new BankAccount(2000);
            Console.WriteLine("Current Balance : "+personBankAccount.Balance);
            try
            {
                Console.WriteLine("Enter amount to withdraw : ");
                personBankAccount.WithdrawBalance(int.Parse(Console.ReadLine()));
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(InsufficientFundException exception)
            {
                Console.WriteLine(exception.Message); 
            }
        }
    }
}
