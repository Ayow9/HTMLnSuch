using AYAssessment5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace AYAssessment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //*****//
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Welcome(Welcome welcome)
        {
            if(welcome.Password == "open sesame")
            {
                welcome.Length = welcome.Name.Length;
                return View(welcome);
            }
           return RedirectToAction("WrongPassword");
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult WrongPassword()
        {
            return View();
        }
        //*****//
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
