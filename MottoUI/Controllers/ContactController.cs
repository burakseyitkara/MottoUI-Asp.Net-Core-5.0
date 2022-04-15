using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;
using MottoUI.EntityLayer.Concrete;
using System;

namespace MottoUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.ContactAdd(p);
            
            return RedirectToAction("Index","Blog");
        }
    }
}
