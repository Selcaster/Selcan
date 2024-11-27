using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniqloMVC.Models;

namespace UniqloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
