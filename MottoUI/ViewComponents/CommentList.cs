using Microsoft.AspNetCore.Mvc;
using MottoUI.Models;
using System.Collections.Generic;

namespace MottoUI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment{
                    ID=1,
                    Username="Burak",
                },
                new UserComment{
                    ID=2,
                    Username="Elif",
                },
                new UserComment{
                    ID=3,
                    Username="Kemal",
                },

            };
            return View(commentvalues);
        }

    }
}
