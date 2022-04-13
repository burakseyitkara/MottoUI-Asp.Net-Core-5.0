using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;

namespace MottoUI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
        
        public IActionResult MessageDetails(int id)
        {
            var values = mm.TGetById(id);
            return View(values);
        }
    }
}
