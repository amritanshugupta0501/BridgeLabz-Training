using System;
namespace aero_vigil
{
    sealed class FlightValidationMenu
    {
        private IFlightValidationUtility FlightValidator; 
        public void HomeMenu()
        {
            FlightValidator = new FlightValidationUtility();
            Console.WriteLine("Welcome to Aero-Vigil Flight Validation System");
            while(true)
            {
                Console.WriteLine("1. Validate Flight Details");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        FlightValidator.AddFlightDescription();
                        break;
                    case "2":
                        Console.WriteLine("Exiting the system!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}