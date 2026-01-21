using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Class designed to implement function of a billing queue
    internal class BillingQueueManagerImpl : IBillingQueueManager
    {
        // Customer queue created using queue collection
        Queue<CustomerDetails> CustomersQueue = new Queue<CustomerDetails>();
        ICustomerCartManager CustomerCart ;
        // Function to add a customer to the billing counter queue
        public void AddACustomerInTheBillingQueue()
        {
            CustomerDetails customerDetails = new CustomerDetails();
            Console.WriteLine("Give Customer Details : ");
            Console.Write("Person Name : ");
            customerDetails.CustomerName = Console.ReadLine();
            Console.Write("Person Address : ");
            customerDetails.CustomerAddress = Console.ReadLine();
            Console.Write("Person Contact Number : ");
            customerDetails.CustomerContactNumber = Console.ReadLine();
            CustomersQueue.Enqueue(customerDetails);
        }
        // Function to generate the bill of a customer
        public void GenerateBillOfACustomer()
        {
            CustomerDetails customerDetails ;
            while (true)
            {
                if (CustomersQueue.Count != 0)
                {
                    customerDetails = CustomersQueue.Dequeue();
                }
                else
                {
                    break;
                }
                CustomerCart = new CustomerCartManagerImpl();
                bool checker = true;
                Console.WriteLine("For Customer "+customerDetails.CustomerName+" :");
                while(checker)
                {
                    Console.WriteLine("1. Add the product from the pantry.");
                    Console.WriteLine("2. Exit the counter");
                    var choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "1":
                            CustomerCart.AddAProductToTheCart(customerDetails,choice);
                            break;
                        case "2":
                            CustomerCart.AddAProductToTheCart(customerDetails, choice);
                            checker = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice input.");
                            break;
                    }
                }
                Console.Clear();
                Console.WriteLine("\nCustomer Details : \n"+customerDetails.ToString());
                Console.WriteLine("\nProducts bought : \n");
                CustomerCart.DisplayAllProducts(customerDetails);
                CustomerCart.CalculateTotalBill(customerDetails);
                Console.WriteLine("\nTotal Bill Of the customer : "+customerDetails.TotalBill);
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Customers Queue at Billing Counter is Empty!!");
            Console.WriteLine();
            Console.Clear();
        }
    }
}
