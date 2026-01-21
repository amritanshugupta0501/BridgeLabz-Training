using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    internal interface IBillingQueueManager
    {
        void AddACustomerInTheBillingQueue();
        void GenerateBillOfACustomer();
    }
}
