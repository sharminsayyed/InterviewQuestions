using System.Diagnostics;
using DependencyInjectionImplementation.DI;
using DependencyInjectionImplementation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionImplementation.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly IMessaging _message;

        public HomeController( IMessaging message)
        {
          
            _message = message;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _message.GetMessage();
            return View();
        }

       
    }
}
