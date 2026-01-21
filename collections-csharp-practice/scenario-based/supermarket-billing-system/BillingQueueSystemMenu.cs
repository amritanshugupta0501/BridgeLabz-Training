using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Class Defined to design the home menu of the supermarket billing system
    internal class BillingQueueSystemMenu
    {
        IBillingQueueManager BillingManager;
        public void HomeMenu()
        {
            BillingManager = new BillingQueueManagerImpl();
            Console.WriteLine("Welcome to Supermarket Billing Counter!!");
            while(true)
            {
                Console.WriteLine("1. Add a customer to the Billing Counter");
                Console.WriteLine("2. Generate Bill of a Customer");
                Console.WriteLine("0. Exit the System");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "0":
                        Console.WriteLine("Hope you have a good day!");
                        return;
                    case "1":
                        BillingManager.AddACustomerInTheBillingQueue();
                        break;
                    case "2":
                        Console.Clear();
                        BillingManager.GenerateBillOfACustomer();
                        break;
                    default:
                        Console.WriteLine("Invalid choice input.");
                        break;
                }
            }
        }
    }
}
