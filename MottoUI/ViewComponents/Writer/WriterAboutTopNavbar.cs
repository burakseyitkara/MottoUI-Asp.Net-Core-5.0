using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;
using System.Linq;

namespace MottoUI.ViewComponents.Writer
{
    public class WriterAboutTopNavbar:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var nameSurname = c.Users.Where(x => x.UserName == username).Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.nameSurname = nameSurname;
            var image = c.Users.Where(x => x.UserName == username).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.image = image;
            
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.NameSurname).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(x => x.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
