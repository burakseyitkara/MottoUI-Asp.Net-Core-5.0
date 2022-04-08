using MottoUI.BusinessLayer.Abstract;
using MottoUI.DataAccessLayer;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactdal.Insert(contact);
        }
    }
}
