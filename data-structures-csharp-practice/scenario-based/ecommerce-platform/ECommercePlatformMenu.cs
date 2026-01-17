using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ecommerceplatform
{
    // Menu class of the application : Sealed to prevent inheritance
    sealed class ECommercePlatformMenu
    {
        IECommercePlatformSystem ECommercePlatform;
        // Function to design the home menu of the application
        public void HomeMenu()
        {
            ECommercePlatform = new ECommercePlatformSystemImpl();
            Console.WriteLine("Welcome to the ECommerce Platform");
            while (true)
            {
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. View Top Discounted Items");
                Console.WriteLine("0. Exit");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "0":
                        Console.WriteLine("Hope you have a Good Day!");
                        return;
                    case "1":
                        ECommercePlatform.AddProductInThePantry();
                        break;
                    case "2":
                        ECommercePlatform.DisplayTheHighestDiscountedProducts();
                        break;
                }
            }
        }
    }
}
