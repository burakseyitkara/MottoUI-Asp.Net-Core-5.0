using Microsoft.AspNetCore.Mvc;

namespace MottoUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
