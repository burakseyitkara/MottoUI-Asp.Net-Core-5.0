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

        public void WriterAdd(Writer writer)
        {
            _writerdal.Insert(writer);
        }
    }
}
