using BusinessLayer.Concreate;
using CaptchaMvc.HtmlHelpers;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCProjeKampi.Controllers
{
    [AllowAnonymous]
    public class WriterLoginController : Controller
    {
        WriterLoginManager wm = new WriterLoginManager(new EfWriterDal());
        // GET: Login
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            var results = wm.GetWriter(p.WriterMail, p.WriterPassword);

            if (results != null)
            {
                if (!this.IsCaptchaValid(""))
                {
                    ViewBag.ErrorMessage = "Captcha geçerli değil";
                    return RedirectToAction("WriterLogin");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(results.WriterMail, false);
                    Session["WriterMail"] = results.WriterMail;
                    return RedirectToAction("MyContent", "WriterPanelContent");
                }
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Headings", "Default");
        }
    }
}