using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;

namespace MottoUI.Controllers
{
    public class CommentController : Controller
    {
    CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }


        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    } 
}
