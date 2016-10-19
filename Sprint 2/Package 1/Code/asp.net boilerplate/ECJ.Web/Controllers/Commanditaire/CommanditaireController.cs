using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;

namespace ECJ.Web.Controllers.Commanditaire
{
    public class CommanditaireController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: Commanditaire
        public ActionResult Index()
        {
            return View(db.tblCommanditaire.ToList());
        }

        public FileContentResult GetFile(int id)
        {

            tblCommanditaire comm = db.tblCommanditaire.Find(id);

            return new FileContentResult(comm.logo,"");

        }

        // GET: tblCommanditaires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCommanditaire tblCommanditaire = db.tblCommanditaire.Find(id);
            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblCommanditaires/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire)
        {
            if (ModelState.IsValid)
            {
                db.tblCommanditaire.Add(tblCommanditaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCommanditaire tblCommanditaire = db.tblCommanditaire.Find(id);
            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }
            return View(tblCommanditaire);
        }

        // POST: tblCommanditaires/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCommanditaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCommanditaire tblCommanditaire = db.tblCommanditaire.Find(id);
            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }
            return View(tblCommanditaire);
        }

        // POST: tblCommanditaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblCommanditaire tblCommanditaire = db.tblCommanditaire.Find(id);
            //db.tblCommanditaire.Remove(tblCommanditaire);
            DateTime thisDay = DateTime.Today;
            tblCommanditaire.dateSupprime = thisDay;
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