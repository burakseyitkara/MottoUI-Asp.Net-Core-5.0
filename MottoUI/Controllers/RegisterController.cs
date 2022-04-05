using Microsoft.AspNetCore.Mvc;

namespace MottoUI.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
    }
}
