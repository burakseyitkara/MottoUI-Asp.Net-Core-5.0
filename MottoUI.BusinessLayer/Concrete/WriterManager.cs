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
    public class WriterManager: IWriterService
    {
        IWriteDal _writerdal;

        public WriterManager(IWriteDal writerdal)
        {
            _writerdal = writerdal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x =>x.WriterID==id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);

        }
        
        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }

       
    }
}
