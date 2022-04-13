using Microsoft.AspNetCore.Mvc;

namespace MottoUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
