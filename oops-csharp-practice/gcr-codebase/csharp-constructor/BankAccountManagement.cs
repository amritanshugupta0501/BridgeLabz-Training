using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class BankAccountManagement
    {
        public long accNumber;
        protected string accHolder;
        private double balance;
        public BankAccountManagement(long accNumber, string accHolder)                               // Constructor Defined to get Bank account attributes
        {
            this.accNumber = accNumber;
            this.accHolder = accHolder;
        }
        public void SetBalance(double balance)                                                      // Setter method for private variable Balance
        {
            this.balance = balance;
        }
        public double GetBalance()                                                                  // Getter Method for private variable Balance
        {
            return this.balance;
        }
    }
    class SavingsAccount : BankAccountManagement                                                    // SavingsAccount class inheriting properties of BankAccountManagement class
    {
        public SavingsAccount(long accNumber, string accHolder) : base(accNumber, accHolder) { }    // Constructor defined 
        public void DisplayDetails()                                                                // Function to display details of Account
        {
            Console.WriteLine("Account Number : " + accNumber);
            Console.WriteLine("Account holder Name : " + accHolder);
            Console.WriteLine("Account balance : " + GetBalance());
        }
    }
    class Program
    {
        static void Main()                                                                          // Entry point of the program
        {
            Console.Write("Give Account Number : ");
            long accNumber = long.Parse(Console.ReadLine());
            Console.Write("Give Account Holder Name : ");
            string accHolder = Console.ReadLine();
            Console.Write("Give Account Balance : ");
            double balance = double.Parse(Console.ReadLine());
            SavingsAccount account = new SavingsAccount(accNumber, accHolder);                      // Constructor calling
            account.SetBalance(balance);
            account.DisplayDetails();
        }
    }
}
