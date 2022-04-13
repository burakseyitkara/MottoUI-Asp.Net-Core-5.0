using FluentValidation;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name is required");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category description is required");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Category name must be less than 50 characters");
            RuleFor(x => x.CategoryDescription).MinimumLength(2).WithMessage("Category description must be more than 2 characters");

        }
    }
}
