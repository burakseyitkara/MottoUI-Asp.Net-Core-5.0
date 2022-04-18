using Microsoft.AspNetCore.Mvc;
using MottoUI.Areas.Admin.Models;
using System.Collections.Generic;

namespace MottoUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            var x = 600;
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "Teknoloji", categorycount = x });
            list.Add(new CategoryClass { categoryname = "Yazılım", categorycount = 80 });
            list.Add(new CategoryClass { categoryname = "Spor", categorycount = 90 });
            return Json(new { jsonlist = list });
        }
    }
}
