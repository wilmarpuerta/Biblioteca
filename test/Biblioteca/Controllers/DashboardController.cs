using Microsoft.AspNetCore.Mvc;

namespace Mvc.controller{

    public class DashboardController : Controller{
        public IActionResult Index()
        {
            return View();
        }

    }
}

