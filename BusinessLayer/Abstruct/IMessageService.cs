using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendbox(string p);
        void MessageAddBL(Message message);
        Message GetByID(int id);
        void MessageDeleteBL(Message message);
        void MessageUpdateBL(Message message);
    }
}
