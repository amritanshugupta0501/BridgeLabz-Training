using ModelLayer;

namespace ServiceLayer
{
    // Implements the flight service.
    public class FlightServiceImpl : IFlightService
    {
        // Provides a sample list of flights for the API.
        public IEnumerable<Flight> GetAllFlights()
        {
            return new List<Flight>
            {
                new Flight { FlightID = 101, FlightName = "GoAir", FlightDestination = "Mumbai" },
                new Flight { FlightID = 105, FlightName = "Indigo Airlines", FlightDestination = "Bangalore" }
            };
        }
    }
}