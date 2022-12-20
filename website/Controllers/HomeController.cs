using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using website.Models;

namespace website.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult cont()
        {
            return View();
        }

    }
}