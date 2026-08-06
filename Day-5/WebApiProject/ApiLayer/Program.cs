using ServiceLayer;
using ControllerLayer;

// Sets up the API host and registers services.
// Create the web application host and configure its services.
var builder = WebApplication.CreateBuilder(args);

// Register MVC controllers from the controller layer so their endpoints are discovered.
builder.Services.AddControllers().AddApplicationPart(typeof(FlightController).Assembly);

// Register the flight service implementation for dependency injection.
builder.Services.AddScoped<IFlightService, FlightServiceImpl>();

// Build the application pipeline.
var app = builder.Build();

// Map controller-based endpoints.
app.MapControllers();

// Start the web application.
app.Run();