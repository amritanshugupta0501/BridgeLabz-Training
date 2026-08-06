namespace ModelLayer
{
    // Represents a flight.
    public class Flight
    {
        // Unique identifier for the flight.
        public int FlightID { get; set; }

        // Display name of the flight.
        public string FlightName { get; set; }

        // Destination for the flight.
        public string FlightDestination { get; set; }
    }
}