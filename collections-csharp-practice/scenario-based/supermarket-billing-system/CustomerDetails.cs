using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Class Designed to define all the attributes of a customer
    internal class CustomerDetails
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContactNumber { get; set; }
        public int TotalBill {  get; set; }

        public override string? ToString()
        {
            return $"Customer Name : {CustomerName}\nCustomer Address : {CustomerAddress}\nCustomer Contact Number : {CustomerContactNumber}";
        }
    }
}
