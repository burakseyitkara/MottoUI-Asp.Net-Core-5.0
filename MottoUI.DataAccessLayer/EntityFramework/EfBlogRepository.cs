using Microsoft.EntityFrameworkCore;
using MottoUI.DataAccessLayer.Abstract;
using MottoUI.DataAccessLayer.Concrete;
using MottoUI.DataAccessLayer.Repositories;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c= new Context() )
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
