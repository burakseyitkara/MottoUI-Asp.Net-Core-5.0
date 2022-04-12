using MottoUI.DataAccessLayer.Abstract;
using MottoUI.DataAccessLayer.Repositories;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository:GenericRepository<Message2>,IMessage2Dal
    {
        
    }
}
