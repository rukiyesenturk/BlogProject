using BusinessLayer.Concreate;
using CaptchaMvc.HtmlHelpers;
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
    public class LoginController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminDal());
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var results = adm.GetAdmin(admin.AdminUserName, admin.AdminPassword);
            if (results != null)
            {
                if (!this.IsCaptchaValid(""))
                {
                    ViewBag.ErrorMessage = "Captcha geçerli değil";
                    return RedirectToAction("Index");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(results.AdminUserName, false);
                    Session["AdminUserName"] = results.AdminUserName;
                    return RedirectToAction("AddCategory", "AdminCategory");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("DefaultHeadings", "Default");
        }
    }
}