using Microsoft.AspNetCore.Mvc;

namespace Lesson08Lab.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admins")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
