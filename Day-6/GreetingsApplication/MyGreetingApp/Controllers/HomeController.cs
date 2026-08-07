using Microsoft.AspNetCore.Mvc;

namespace MyGreetingApp.Controllers
{
    // HomeController handles requests for the main landing page.
    public class HomeController : Controller
    {
        // Returns the default home page view.
        public IActionResult Index()
        {
            return View();
        }
    }
}

