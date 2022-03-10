using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
    public interface IAdminService
    {
        List<Admin> GetList();
        Admin GetAdmin(string username, string password);
        void AdminAddBL(Admin admin);
        Admin GetByID(int id);
        void AdminDeleteBL(Admin admin);
        void AdminUpdateBL(Admin admin);
    }
}
