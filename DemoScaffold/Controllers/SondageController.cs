using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoScaffold.Models;

namespace DemoScaffold.Controllers
{
    public class SondageController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Sondage
        public ActionResult Index()
        {
            return View(db.Sondages.ToList());
        }

        // GET: Sondage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sondage sondage = db.Sondages.Find(id);
            if (sondage == null)
            {
                return HttpNotFound();
            }
            return View(sondage);
        }

        // GET: Sondage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sondage/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date")] Sondage sondage)
        {
            if (ModelState.IsValid)
            {
                db.Sondages.Add(sondage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sondage);
        }

        // GET: Sondage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sondage sondage = db.Sondages.Find(id);
            if (sondage == null)
            {
                return HttpNotFound();
            }
            return View(sondage);
        }

        // POST: Sondage/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date")] Sondage sondage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sondage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sondage);
        }

        // GET: Sondage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sondage sondage = db.Sondages.Find(id);
            if (sondage == null)
            {
                return HttpNotFound();
            }
            return View(sondage);
        }

        // POST: Sondage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sondage sondage = db.Sondages.Find(id);
            db.Sondages.Remove(sondage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
