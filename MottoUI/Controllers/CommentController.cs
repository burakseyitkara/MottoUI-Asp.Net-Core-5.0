using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MottoUI.BusinessLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;
using MottoUI.EntityLayer.Concrete;
using System;

namespace MottoUI.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
    CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 4;
            cm.CommentAdd(p);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    } 
}
