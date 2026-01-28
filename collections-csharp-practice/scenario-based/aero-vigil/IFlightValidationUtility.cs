namespace aero_vigil
{
    internal interface IFlightValidationUtility
    {
        void AddFlightDescription();
        void FlightValidation();
        bool ValidateFlightName(object flightDetails);
        bool ValidateFlightNumber(object flightDetails);
        double ValidateFuelCapacity(object flightDetails);
        bool ValidatePassengerCount(object flightDetails);
    }
}