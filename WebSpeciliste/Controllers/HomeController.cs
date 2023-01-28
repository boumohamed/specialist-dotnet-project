using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSpeciliste.Models;
using WebSpeciliste.services.CustomerServices;
using WebSpeciliste.services.SpecialistsService;

namespace WebSpeciliste.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICustomer _customerService;
        public HomeController(ICustomer customerservice)
        {
            _customerService = customerservice;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string speciality, string location, string keyword)
        {

            return RedirectToAction("Index", "Customer", new { speciality = speciality, location = location, keyword = keyword});
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