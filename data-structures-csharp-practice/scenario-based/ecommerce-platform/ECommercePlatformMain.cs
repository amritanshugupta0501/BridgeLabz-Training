using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ecommerceplatform
{
    // Entry point of the application
    internal class ECommercePlatformMain
    {
        static void Main(string[] args)
        {
            ECommercePlatformMenu eCommercePlatformMenu = new ECommercePlatformMenu();
            eCommercePlatformMenu.HomeMenu();
        }
    }
}
