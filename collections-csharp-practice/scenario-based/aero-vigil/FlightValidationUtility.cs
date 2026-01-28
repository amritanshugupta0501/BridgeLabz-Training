using System;
namespace aero_vigil
{
    class FlightValidationUtility : IFlightValidationUtility
    {
        private FlightDetails FlightDescription;
        public bool ValidateFlightNumber(object flightDetails)
        {
            var type = flightDetails.GetType();
            foreach (var flightProperty in type.GetProperties())
            {
                var flightAttributes = (FlightNumberValidator)Attribute.GetCustomAttribute(flightProperty, typeof(FlightNumberValidator));
                if (flightAttributes != null)
                {
                    var property = flightProperty.GetValue(flightDetails);
                    if (!System.Text.RegularExpressions.Regex.IsMatch(property?.ToString(), flightAttributes.FlightNumberPattern))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool ValidateFlightName(object flightDetails)
        {
            var type = flightDetails.GetType();
            foreach (var flightProperties in type.GetProperties())
            {
                var flightAttribute = (FlightNameValidator)Attribute.GetCustomAttribute(flightProperties, typeof(FlightNameValidator));
                if (flightAttribute != null)
                {
                    var property = flightProperties.GetValue(flightDetails);
                    if (!System.Text.RegularExpressions.Regex.IsMatch(property?.ToString(), flightAttribute.FlightNamePattern))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool ValidatePassengerCount(object flightDetails)
        {
            var type = flightDetails.GetType();
            var flightName = type.GetProperty("FlightName").GetValue(flightDetails).ToString();
            var passengerCount = type.GetProperty("PassengerCount").GetValue(flightDetails);
            switch (flightName)
            {
                case "SpiceJet":
                    if ((int)passengerCount > 180 || (int)passengerCount <= 0)
                        return false;
                    break;
                case "Vistara":
                    if ((int)passengerCount > 150 || (int)passengerCount <= 0)
                        return false;
                    break;
                case "IndiGo":
                    if ((int)passengerCount > 200 || (int)passengerCount <= 0)
                        return false;
                    break;
                case "Air Arabia":
                    if ((int)passengerCount > 100 || (int)passengerCount <= 0)
                        return false;
                    break;
            }
            return true;
        }
        public double ValidateFuelCapacity(object flightDetails)
        {
            var type = flightDetails.GetType();
            var flightName = type.GetProperty("FlightName").GetValue(flightDetails).ToString();
            var fuelCapacity = type.GetProperty("FlightFuelCapacity").GetValue(flightDetails);
            switch (flightName)
            {
                case "SpiceJet":
                    if ((double)fuelCapacity > 50000 || (double)fuelCapacity <= 0)
                        return -1.0;
                    else
                        return 50000 - (double)fuelCapacity;
                case "Vistara":
                    if ((double)fuelCapacity > 40000 || (double)fuelCapacity <= 0)
                        return -1.0;
                    else
                        return 40000 - (double)fuelCapacity;
                case "IndiGo":
                    if ((double)fuelCapacity > 60000 || (double)fuelCapacity <= 0)
                        return -1.0;
                    else
                        return 60000 - (double)fuelCapacity;
                case "Air Arabia":
                    if ((double)fuelCapacity > 30000 || (double)fuelCapacity <= 0)
                        return -1.0;
                    else
                        return 30000 - (double)fuelCapacity;
            }
            return -1.0;
        }
        public void FlightValidation()
        {
            if (!ValidateFlightNumber(FlightDescription))
            {
                throw new InvalidFlightException("The Flight Number " + FlightDescription.FlightNumber + " is Invalid");
                return;
            }
            if (!ValidateFlightName(FlightDescription))
            {
                throw new InvalidFlightException("The Flight Name " + FlightDescription.FlightName + " is Invalid");
                return;
            }
            if (!ValidatePassengerCount(FlightDescription))
            {
                throw new InvalidFlightException("The Passenger Count " + FlightDescription.PassengerCount + " is Invalid for " + FlightDescription.FlightName);
                return;
            }
            if (ValidateFuelCapacity(FlightDescription) == -1.0)
            {
                throw new InvalidFlightException("Invalid fuel level for " + FlightDescription.FlightName);
                return;
            }
            Console.WriteLine("Fuel required to fill the tank for flight " + FlightDescription.FlightName + " is " + ValidateFuelCapacity(FlightDescription) + " liters");
        }
        public void AddFlightDescription()
        {
            FlightDescription = new FlightDetails();
            Console.WriteLine("Give Flight Details : ");
            Console.Write("Flight Number : ");
            FlightDescription.FlightNumber = Console.ReadLine();
            Console.Write("Flight Name : ");
            FlightDescription.FlightName = Console.ReadLine();
            Console.Write("Passenger Count : ");
            FlightDescription.PassengerCount = int.Parse(Console.ReadLine());
            Console.Write("Flight Fuel Capacity : ");
            FlightDescription.FlightFuelCapacity = double.Parse(Console.ReadLine());
            try
            {
                FlightValidation();
            }
            catch (InvalidFlightException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}