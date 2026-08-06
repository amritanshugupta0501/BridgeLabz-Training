using Microsoft.AspNetCore.Mvc;
using ModelLayer;
using ServiceLayer;

namespace ControllerLayer
{
    // Handles flight API requests.
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;

        // Inject the flight service into the controller.
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        // Retrieve all available flights.
        [HttpGet]
        public IActionResult GetAllFlights()
        {
            var flights = _flightService.GetAllFlights();
            return Ok(flights);
        }
    }
}