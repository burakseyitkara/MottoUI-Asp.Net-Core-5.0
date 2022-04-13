﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MottoUI.EntityLayer.Concrete;
using MottoUI.DataAccessLayer.EntityFramework;
using X.PagedList;
using MottoUI.BusinessLayer.ValidationRules;
using FluentValidation.Results;
using MottoUI.BusinessLayer.Concrete;

namespace MottoUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
             
            if (results.IsValid)
            {

                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else 
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           

            return View();
        }
    }
}
