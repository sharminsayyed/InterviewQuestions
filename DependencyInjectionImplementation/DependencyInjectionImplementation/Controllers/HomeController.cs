using System.Diagnostics;
using DependencyInjectionImplementation.DI;
using DependencyInjectionImplementation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionImplementation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMessaging _message;

        public HomeController(ILogger<HomeController> logger, IMessaging message)
        {
            _logger = logger;
            _message = message;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _message.GetMessage();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
