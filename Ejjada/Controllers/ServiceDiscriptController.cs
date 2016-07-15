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
    public class ServiceDiscriptController : Controller
    {
        private EjjadaDb1 db = new EjjadaDb1();

        //
        // GET: /ServiceDiscript/

        public ActionResult Index()
        {
            return View(db.Discriptions.ToList());
        }

        //
        // GET: /ServiceDiscript/Details/5

        public ActionResult Details(int id = 0)
        {
            ServiceDiscript servicediscript = db.Discriptions.Find(id);
            if (servicediscript == null)
            {
                return HttpNotFound();
            }
            return View(servicediscript);
        }

        //
        // GET: /ServiceDiscript/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ServiceDiscript/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceDiscript servicediscript)
        {
            if (ModelState.IsValid)
            {
                db.Discriptions.Add(servicediscript);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicediscript);
        }

        //
        // GET: /ServiceDiscript/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ServiceDiscript servicediscript = db.Discriptions.Find(id);
            if (servicediscript == null)
            {
                return HttpNotFound();
            }
            return View(servicediscript);
        }

        //
        // POST: /ServiceDiscript/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceDiscript servicediscript)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicediscript).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicediscript);
        }

        //
        // GET: /ServiceDiscript/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ServiceDiscript servicediscript = db.Discriptions.Find(id);
            if (servicediscript == null)
            {
                return HttpNotFound();
            }
            return View(servicediscript);
        }

        //
        // POST: /ServiceDiscript/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceDiscript servicediscript = db.Discriptions.Find(id);
            db.Discriptions.Remove(servicediscript);
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