using BusinessLayer.Abstraact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDAl;

        public WriterManager(IWriterDal writerDAl)
        {
            _writerDAl = writerDAl;
        }

        public Writer GetByID(int id)
        {
            return _writerDAl.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDAl.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDAl.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDAl.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDAl.Update(writer);
        }
    }
}
