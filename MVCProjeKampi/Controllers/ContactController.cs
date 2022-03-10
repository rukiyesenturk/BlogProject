using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactValidator cv = new ContactValidator();
        Context _context = new Context();

        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        public PartialViewResult MessageListDeneme()
        {
            return PartialView();
        }
        public PartialViewResult ContactPartial()
        {
            var results = cm.GetList().Count();
            ViewBag.contact = results;

            var receiverMail = _context.Messages.Count(x => x.ReceiverMail == "admin@gmail.com").ToString();
            ViewBag.receiverMail = receiverMail;

            var sendMail = _context.Messages.Count(x => x.SenderMail == "admin@gmail.com").ToString();
            ViewBag.send = sendMail;

            var draftMail = _context.Messages.Count(x => x.IsDraft == true);
            ViewBag.draft = draftMail;

            return PartialView();
        }
        public ActionResult IsRead(int id) //Bu alan sistem mesajlarindaki okundu butonundan gelen degeri DB yazar
        {
            var contactValue = cm.GetByID(id);

            if (contactValue.IsRead)
            {
                contactValue.IsRead = false;
            }
            else
            {
                contactValue.IsRead = true;
            }

            cm.ContactUpdateBL(contactValue);
            return RedirectToAction("Index");
        }


        public ActionResult IsImportant(int id) //Bu alan sistem mesajlarindaki önemli butonundan gelen degeri DB yazar
        {
            var contactValue = cm.GetByID(id);

            if (contactValue.IsImportant)
            {
                contactValue.IsImportant = false;
            }
            else
            {
                contactValue.IsImportant = true;
            }

            cm.ContactUpdateBL(contactValue);
            return RedirectToAction("Index");
        }
    }
}