using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VeterinariaUAI.Models;

namespace VeterinariaUAI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Home"] = "Your Home page.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ActionName: Contact]
        public IActionResult Contact_Post()
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.Name = Request.Form["name"];
            RedirectToPage("/Home/SuccessContact");
            return View();
        }

        public IActionResult SuccessContact()
        {
            ViewData["Message"] = "Contact Successful!";
            ViewBag.Name = Request.Form["name"];
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
