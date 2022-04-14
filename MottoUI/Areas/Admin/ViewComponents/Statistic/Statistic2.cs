using Microsoft.AspNetCore.Mvc;
using MottoUI.DataAccessLayer.Concrete;
using System.Linq;

namespace MottoUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
