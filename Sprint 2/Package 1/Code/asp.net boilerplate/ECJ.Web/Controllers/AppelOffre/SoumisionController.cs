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
    public class SoumisionController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: Soumision
        public ActionResult Index()
        {
            var tblSoumission = db.tblSoumission.Include(t => t.tblAppelOffreAgence);
            return View(tblSoumission.ToList());
        }

        // GET: Soumision/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSoumission tblSoumission = db.tblSoumission.Find(id);
            if (tblSoumission == null)
            {
                return HttpNotFound();
            }
            return View(tblSoumission);
        }

        // GET: Soumision/Create
        public ActionResult Create()
        {
            ViewBag.offreNoPublicite = new SelectList(db.tblAppelOffreAgence, "offreNoPublicite", "offreNoPublicite");
            return View();
        }

        // POST: Soumision/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noSoumission,nom,prix,statut,description,dateSupprime,noAppelOffre,offreNoPublicite")] tblSoumission tblSoumission)
        {
            if (ModelState.IsValid)
            {
                db.tblSoumission.Add(tblSoumission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.offreNoPublicite = new SelectList(db.tblAppelOffreAgence, "offreNoPublicite", "offreNoPublicite", tblSoumission.offreNoPublicite);
            return View(tblSoumission);
        }

        // GET: Soumision/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSoumission tblSoumission = db.tblSoumission.Find(id);
            if (tblSoumission == null)
            {
                return HttpNotFound();
            }
            ViewBag.offreNoPublicite = new SelectList(db.tblAppelOffreAgence, "offreNoPublicite", "offreNoPublicite", tblSoumission.offreNoPublicite);
            return View(tblSoumission);
        }

        // POST: Soumision/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noSoumission,nom,prix,statut,description,dateSupprime,noAppelOffre,offreNoPublicite")] tblSoumission tblSoumission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSoumission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.offreNoPublicite = new SelectList(db.tblAppelOffreAgence, "offreNoPublicite", "offreNoPublicite", tblSoumission.offreNoPublicite);
            return View(tblSoumission);
        }

        // GET: Soumision/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSoumission tblSoumission = db.tblSoumission.Find(id);
            if (tblSoumission == null)
            {
                return HttpNotFound();
            }
            return View(tblSoumission);
        }

        // POST: Soumision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblSoumission tblSoumission = db.tblSoumission.Find(id);
            db.tblSoumission.Remove(tblSoumission);
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
