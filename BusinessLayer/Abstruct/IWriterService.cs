using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriterAddBL(Writer writer);
        void WriterDeleteBL(Writer writer);
        void WriterUpdateBL(Writer writer);
        Writer GetByID(int id);
    }
}
