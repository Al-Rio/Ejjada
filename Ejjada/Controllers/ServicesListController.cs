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
    public class ServicesListController : Controller
    {
        private EjjadaDb1 db = new EjjadaDb1();

        //
        // GET: /ServicesList/

        public ActionResult Index()
        {
            return View(db.Services.ToList());
        }

        //
        // GET: /ServicesList/Details/5

        public ActionResult Details(int id = 0)
        {
            CService cservice = db.Services.Find(id);
            if (cservice == null)
            {
                return HttpNotFound();
            }
            return View(cservice);
        }

        //
        // GET: /ServicesList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ServicesList/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CService cservice)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(cservice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cservice);
        }

        //
        // GET: /ServicesList/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CService cservice = db.Services.Find(id);
            if (cservice == null)
            {
                return HttpNotFound();
            }
            return View(cservice);
        }

        //
        // POST: /ServicesList/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CService cservice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cservice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cservice);
        }

        //
        // GET: /ServicesList/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CService cservice = db.Services.Find(id);
            if (cservice == null)
            {
                return HttpNotFound();
            }
            return View(cservice);
        }

        //
        // POST: /ServicesList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CService cservice = db.Services.Find(id);
            db.Services.Remove(cservice);
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