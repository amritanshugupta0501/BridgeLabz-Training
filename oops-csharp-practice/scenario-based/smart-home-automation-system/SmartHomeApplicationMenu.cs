using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    // Sealed class defined to preven inheritance of the class
    sealed class SmartHomeApplicationMenu
    {
        private IControllable ApplianceType; 
        // Design the menu of the application
        public void HomeMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Smart Home Automation System!");
                Console.WriteLine("1. Light");
                Console.WriteLine("2. Fan");
                Console.WriteLine("3. AC");
                Console.WriteLine("4. Display All Appliances");
                Console.WriteLine("5. Toggle An Appliances");
                Console.WriteLine("6. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ApplianceType = new LightUtilityImpl();
                        Console.WriteLine("Successfully Added an appliance");
                        break;
                    case 2:
                        ApplianceType = new FanUtilityImpl();
                        Console.WriteLine("Successfully Added an appliance");
                        break;
                    case 3:
                        ApplianceType = new ACUtilityImpl();
                        Console.WriteLine("Successfully Added an appliance");
                        break;
                    case 4:
                        ApplianceControl displayingAppliances = new ApplianceControl();
                        displayingAppliances.DisplayAllAppliances();
                        break;
                    case 5:
                        ApplianceControl toggleAppliance = new ApplianceControl();
                        toggleAppliance.DisplayAllAppliances();
                        Console.Write("Select The Appliance you want to toggle : ");
                        int applianceNumber = int.Parse(Console.ReadLine());
                        toggleAppliance.ToggleAppliances(applianceNumber-1);
                        break;
                    case 6:
                        Console.WriteLine("Thank you for your efforts!");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
