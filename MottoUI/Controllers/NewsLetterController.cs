using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;
using MottoUI.EntityLayer.Concrete;

namespace MottoUI.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
            
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
