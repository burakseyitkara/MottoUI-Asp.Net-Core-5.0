using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace MottoUI.Api.DataAccessLayer
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK;database=CoreBlogApiDb; integrated security=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
