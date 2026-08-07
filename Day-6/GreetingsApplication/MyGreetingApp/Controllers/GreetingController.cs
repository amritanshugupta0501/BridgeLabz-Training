using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyGreetingApp.Models;
namespace MyGreetingApp.Controllers
{
    // Controller for greeting pages and error handling.
    public class GreetingController : Controller
    {
        // Show the greeting view.
        public IActionResult Index()
        {
            return View();
        }

        // Return the error view with request diagnostics.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}