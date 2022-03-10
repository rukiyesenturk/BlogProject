using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers

{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAbout());
        public ActionResult Index()
        {
            var results = abm.GetList();
            return View(results);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            abm.AboutAddBL(p);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public ActionResult isActive(int id)
        {
            var value = abm.GetByID(id);
            if (value.isActive)
            {
                value.isActive = false;
            }
            else
            {
                value.isActive = true;
            }
            abm.AboutUpdateBL(value);
            return RedirectToAction("Index");
        }
    }
}