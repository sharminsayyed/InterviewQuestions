using System.Diagnostics;
using EntityFrameworkCoreImplementation.Data;
using EntityFrameworkCoreImplementation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreImplementation.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var emp = _db.Employees.ToList();
            return View(emp);
        }

        
    }
}
