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
    public class NewsLetterManager:INewsLetterService
    {
        INewsLetterDal _newsletterDal;

        public NewsLetterManager(INewsLetterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsletterDal.Insert(newsLetter);
        }
    }
}
