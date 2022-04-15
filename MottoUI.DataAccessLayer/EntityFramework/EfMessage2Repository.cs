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
    public class EfMessage2Repository:GenericRepository<Message2>,IMessage2Dal
    {
        public List<Message2> GetSendboxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.ReceiverUser).Where(x => x.SenderID == id).ToList();
            }
        }

        public List<Message2> GetInboxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }

       
    }
}
