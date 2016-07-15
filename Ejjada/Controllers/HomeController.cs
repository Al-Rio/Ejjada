using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejjada.Models;
using Ejjada.Services;

namespace Ejjada.Controllers
{
    public class HomeController : Controller
    {
        EjjadaDb1 _db = new EjjadaDb1();

        public ActionResult Index()
        {
            var Benefits = _db.Benefits.ToList();
            var Services = _db.Services.ToList();
            var WhyUs = _db.WhyUs.ToList();
            //var NewsL = _db.NewsL.ToList();
            var model = new maz();
            model.CService = Services;
            model.CBenefit = Benefits;
            model.Why = WhyUs;
            //model.News = NewsL;
            
            return View(model);
        }

        public ActionResult About()
        {
            var Discriptions1 = _db.Discriptions1.ToList();
            //var NewsL = _db.NewsL.ToList();
            var model = new maz();
            model.AboutDiscript = Discriptions1;
            //model.News = NewsL;

            return View(model);
        }

        public ActionResult Contact()
        {
            ////var NewsL = _db.NewsL.ToList();
            //var model = new maz();
            //model.News = NewsL;
            return View();
        }

        public ActionResult Services()
        {
            var Discriptions = _db.Discriptions.ToList();
            var Services = _db.Services.ToList();
            //var NewsL = _db.NewsL.ToList();
            var model = new maz();
            model.CService = Services;
            model.ServiceDiscript = Discriptions;
            //model.News = NewsL;

            return View(model);
        }

        public class maz
        {
            public IEnumerable<CBenefit> CBenefit { get; set; }
            public IEnumerable<CService> CService { get; set; }
            public IEnumerable<Why> Why { get; set; }
            public IEnumerable<ServiceDiscript> ServiceDiscript { get; set; }
            public IEnumerable<AboutDiscript> AboutDiscript { get; set; }
            //public IEnumerable<News> News { get; set; }
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        ////[HttpPost]
        ////public ActionResult Contact(ContactModel model)
        ////{
        ////    var msg = string.Format("Comment Form: {1}{0}Email:{2}{0}Phone:{3}{0}Title:{4}{0}Message:",
        ////     model.Name,
        ////     model.Email,
        ////     model.Phone,
        ////     model.Title,
        ////     model.Message);

        ////    var svc = new MailService();

        ////   if (svc.SendMail("noreply@alriodesign.com", 
        ////        "rio@alriodesign.com", 
        ////        "Website Contact", 
        ////        msg))
        ////   {
        ////       ViewBag.MailSent = true;
        ////   }

        ////    return View();
        ////}
    }
}
