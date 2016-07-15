using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejjada.Models;

namespace Ejjada.Controllers
{
    public class WhyUsController : Controller
    {
        private EjjadaDb1 db = new EjjadaDb1();

        //
        // GET: /WhyUs/

        public ActionResult Index()
        {
            return View(db.WhyUs.ToList());
        }

        //
        // GET: /WhyUs/Details/5

        public ActionResult Details(int id = 0)
        {
            Why why = db.WhyUs.Find(id);
            if (why == null)
            {
                return HttpNotFound();
            }
            return View(why);
        }

        //
        // GET: /WhyUs/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /WhyUs/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Why why)
        {
            if (ModelState.IsValid)
            {
                db.WhyUs.Add(why);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(why);
        }

        //
        // GET: /WhyUs/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Why why = db.WhyUs.Find(id);
            if (why == null)
            {
                return HttpNotFound();
            }
            return View(why);
        }

        //
        // POST: /WhyUs/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Why why)
        {
            if (ModelState.IsValid)
            {
                db.Entry(why).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(why);
        }

        //
        // GET: /WhyUs/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Why why = db.WhyUs.Find(id);
            if (why == null)
            {
                return HttpNotFound();
            }
            return View(why);
        }

        //
        // POST: /WhyUs/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Why why = db.WhyUs.Find(id);
            db.WhyUs.Remove(why);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}