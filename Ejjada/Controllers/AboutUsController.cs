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
    public class AboutUsController : Controller
    {
        private EjjadaDb1 db = new EjjadaDb1();

        //
        // GET: /AboutUs/

        public ActionResult Index()
        {
            return View(db.Discriptions1.ToList());
        }

        //
        // GET: /AboutUs/Details/5

        public ActionResult Details(int id = 0)
        {
            AboutDiscript aboutdiscript = db.Discriptions1.Find(id);
            if (aboutdiscript == null)
            {
                return HttpNotFound();
            }
            return View(aboutdiscript);
        }

        //
        // GET: /AboutUs/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AboutUs/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AboutDiscript aboutdiscript)
        {
            if (ModelState.IsValid)
            {
                db.Discriptions1.Add(aboutdiscript);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutdiscript);
        }

        //
        // GET: /AboutUs/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AboutDiscript aboutdiscript = db.Discriptions1.Find(id);
            if (aboutdiscript == null)
            {
                return HttpNotFound();
            }
            return View(aboutdiscript);
        }

        //
        // POST: /AboutUs/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AboutDiscript aboutdiscript)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutdiscript).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutdiscript);
        }

        //
        // GET: /AboutUs/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AboutDiscript aboutdiscript = db.Discriptions1.Find(id);
            if (aboutdiscript == null)
            {
                return HttpNotFound();
            }
            return View(aboutdiscript);
        }

        //
        // POST: /AboutUs/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutDiscript aboutdiscript = db.Discriptions1.Find(id);
            db.Discriptions1.Remove(aboutdiscript);
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