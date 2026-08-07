// Configure the web application builder and request handling pipeline.
var builder = WebApplication.CreateBuilder(args);

// Register MVC services so controllers can return views.
builder.Services.AddControllersWithViews();

// Build the application from the configured services.
var app = builder.Build();

// Configure request handling and error pages based on environment.
if (!app.Environment.IsDevelopment())
{
    // Use a generic error page in production.
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redirect plain HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Enable endpoint routing for controllers and static assets.
app.UseRouting();

// Apply authorization middleware for protected routes.
app.UseAuthorization();

// Enable serving static files and assets.
app.MapStaticAssets();

// Map the default controller route for MVC.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Start processing incoming requests.
app.Run();
