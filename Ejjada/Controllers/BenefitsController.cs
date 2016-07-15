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
    public class BenefitsController : Controller
    {
        private EjjadaDb1 db = new EjjadaDb1();

        //
        // GET: /Benefits/

        public ActionResult Index()
        {
            return View(db.Benefits.ToList());
        }

        //
        // GET: /Benefits/Details/5

        public ActionResult Details(int id = 0)
        {
            CBenefit cbenefit = db.Benefits.Find(id);
            if (cbenefit == null)
            {
                return HttpNotFound();
            }
            return View(cbenefit);
        }

        //
        // GET: /Benefits/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Benefits/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CBenefit cbenefit)
        {
            if (ModelState.IsValid)
            {
                db.Benefits.Add(cbenefit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cbenefit);
        }

        //
        // GET: /Benefits/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CBenefit cbenefit = db.Benefits.Find(id);
            if (cbenefit == null)
            {
                return HttpNotFound();
            }
            return View(cbenefit);
        }

        //
        // POST: /Benefits/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CBenefit cbenefit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cbenefit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cbenefit);
        }

        //
        // GET: /Benefits/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CBenefit cbenefit = db.Benefits.Find(id);
            if (cbenefit == null)
            {
                return HttpNotFound();
            }
            return View(cbenefit);
        }

        //
        // POST: /Benefits/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CBenefit cbenefit = db.Benefits.Find(id);
            db.Benefits.Remove(cbenefit);
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