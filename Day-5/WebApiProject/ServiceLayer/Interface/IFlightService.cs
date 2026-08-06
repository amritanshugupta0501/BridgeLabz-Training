using ModelLayer;

namespace ServiceLayer
{
    // Defines flight service methods.
    public interface IFlightService
    {
        // Returns all flights available to the application.
        IEnumerable<Flight> GetAllFlights();
    }
}