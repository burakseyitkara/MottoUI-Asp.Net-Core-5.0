using MottoUI.BusinessLayer.Abstract;
using MottoUI.DataAccessLayer.Abstract;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
           return _commentdal.GetListAll(x => x.BlogID ==id);
        }
    }
}
