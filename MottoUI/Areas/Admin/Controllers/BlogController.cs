using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using MottoUI.Areas.Admin.Models;
using System.Collections.Generic;
using System.IO;

namespace MottoUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1,1).Value = "Blog ID";
                worksheet.Cell(1,2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach(var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
            
        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel
                {
                    ID = 1,
                    BlogName = "C# ile programlama"
                },
                new BlogModel
                {
                    ID = 2,
                    BlogName = "Tesla araçları"
                },
                new BlogModel
                {
                    ID = 3,
                    BlogName = "Python ile programlama"
                },

            };
            return bm;

        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
    }
}
