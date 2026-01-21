using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Entry point of the application
    internal class BillingQueueSystemMain
    {
        static void Main(string[] args)
        {
            BillingQueueSystemMenu queueSystemMenu = new BillingQueueSystemMenu();
            queueSystemMenu.HomeMenu();
        }
    }
}
