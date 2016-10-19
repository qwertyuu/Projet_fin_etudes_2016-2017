using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;

namespace ECJ.Web.Controllers.AppelOffre
{
    public class testController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: test
        public ActionResult Index()
        {
            var tblAppelOffre = db.tblAppelOffre.Include(t => t.tblEvenement).Include(t => t.tblStatutAppelOffre);
            return View(tblAppelOffre.ToList());
        }

        // GET: test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return View(tblAppelOffre);
        }

        // GET: test/Create
        public ActionResult Create()
        {
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom");
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom");
            return View();
        }

        // POST: test/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noStatut,tag")] tblAppelOffre tblAppelOffre)
        {
            if (ModelState.IsValid)
            {
                db.tblAppelOffre.Add(tblAppelOffre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            return View(tblAppelOffre);
        }

        // GET: test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            return View(tblAppelOffre);
        }

        // POST: test/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noStatut,tag")] tblAppelOffre tblAppelOffre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblAppelOffre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            return View(tblAppelOffre);
        }

        // GET: test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return View(tblAppelOffre);
        }

        // POST: test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            db.tblAppelOffre.Remove(tblAppelOffre);
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
