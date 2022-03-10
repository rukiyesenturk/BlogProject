using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
    public interface IAboutService
    {
        List<About> GetList();
        void AboutAddBL(About about);
        About GetByID(int id);
        void AboutDeleteBL(About about);
        void AboutUpdateBL(About about);
    }
}
