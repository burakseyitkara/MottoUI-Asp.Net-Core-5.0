using Microsoft.AspNetCore.Mvc;

namespace MottoUI.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
