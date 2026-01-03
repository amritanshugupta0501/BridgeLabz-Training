using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class BankAccountSystem
    {
        public static string bankName = "World Bank";
        private static int totalAccounts = 0;
        public readonly int accountNumber;
        public string accountHolderName;
        public BankAccountSystem(int accountNumber, string accountHolderName)                                   // Constructor defined to get characteristics of account holders
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            totalAccounts++;
        }
        public static int GetTotalAccounts()                                                                    // Get total number of accounts in the bank
        {
            return totalAccounts;
        }
        public void DisplayDetails()                                                                            // Display details of all the bank account holders in the bank
        {
            Console.WriteLine("Account Details : ");
            Console.WriteLine("Bank Name : " + bankName);
            Console.WriteLine("Account holder number : " + accountNumber);
            Console.WriteLine("Account holder name : " + accountHolderName);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()                                                                                      // Entry point of the application
        {
            Console.WriteLine("Give Bank Account Details of person 1 :");
            Console.Write("Give bank account name : ");
            int accNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Give bank account number : ");
            string accName1 = Console.ReadLine();
            BankAccountSystem account1 = new BankAccountSystem(accNumber1, accName1);                           // Constructor called to create first object
            Console.WriteLine("Give Bank Account Details of person 2 :");
            Console.Write("Give bank account name : ");
            int accNumber2 = int.Parse(Console.ReadLine());
            Console.Write("Give bank account number : ");   
            string accName2 = Console.ReadLine();
            BankAccountSystem account2 = new BankAccountSystem(accNumber2, accName2);                           // Constructor called to create second object
            if(account1 is BankAccountSystem)                                                                   // Checking the type of object using 'is' operator
            {
                account1.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Invalid Account type.");
            }
            Console.WriteLine("Total Accounts in the bank : " + BankAccountSystem.GetTotalAccounts());
        }
    }
}
