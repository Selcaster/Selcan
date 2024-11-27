using Microsoft.AspNetCore.Mvc;

namespace UniqloMVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
