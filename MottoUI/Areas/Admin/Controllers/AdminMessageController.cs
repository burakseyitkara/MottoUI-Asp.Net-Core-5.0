using Microsoft.AspNetCore.Mvc;

namespace MottoUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
    }
}
