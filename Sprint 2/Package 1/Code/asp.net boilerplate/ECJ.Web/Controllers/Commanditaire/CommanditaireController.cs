using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Drawing.Imaging;
using System.Drawing;

namespace ECJ.Web.Controllers.Commanditaire
{
    public class CommanditaireController : ECJControllerBase
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: Commanditaire
        public ActionResult Index()
        {
            var recherche = Request.QueryString["recherche"];
            var Commanditaire = db.tblCommanditaire.ToList();

            if (recherche != null)
            {
                if (recherche.Trim() == "")
                {
                    return RedirectToAction("Index");
                }

                ViewBag.recherche = recherche;
                recherche = recherche.Trim().ToUpper();

                Commanditaire = Commanditaire.Where(
                a => a.nomCommanditaire.ToString().ToUpper().Contains(recherche) ||
                a.courrielContact.ToString().ToUpper().Contains(recherche) ||
                a.nomContact.ToString().ToUpper().Contains(recherche) ||
                a.numTel.ToString().ToUpper().Contains(recherche)).ToList();
            }

            return View(Commanditaire);
        }

        public FileContentResult GetFile(int id)
        {
            var comm = db.tblCommanditaire.Find(id);
            var imagedata = comm.logo;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata,string.Format("image/{0}", contentType.ToString().ToLower()));

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
            ViewBag.noCommanditaire = new SelectList(db.tblCommanditaire, "noCommanditaire", "nomCommanditaire");
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom");

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
                if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblCommanditaire.logo = reader.ReadBytes(pic.ContentLength);
                    }
                }

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
            var elementAModifier = db.tblCommanditaire.Find((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }

        // POST: tblCommanditaires/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire)
        {
            var modif = false;

            if (ModelState.IsValid)
            {
                if (Request.Form["SupprimerAffiche"] != null)
                {
                    tblCommanditaire.logo = null;
                }
                else if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblCommanditaire.logo = reader.ReadBytes(pic.ContentLength);
                    }
                }
                else
                {
                    tblCommanditaire.logo = db.tblCommanditaire.Find(tblCommanditaire.noCommanditaire).logo;
                    modif = true;
                }
                if (modif)
                {
                    db.Entry(db.tblCommanditaire.Find(tblCommanditaire.noCommanditaire)).CurrentValues.SetValues(tblCommanditaire);
                }
                else
                {
                    db.Entry(tblCommanditaire).State = EntityState.Modified;
                }
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Delete/5
        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                var elementAModifier = db.tblCommanditaire.Find((int)id);
                elementAModifier.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
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

        public ActionResult DetailsDon(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<tblDon> don = new List<Models.tblDon>();
            var tblDon = db.tblDon.ToList();

            foreach (var d in tblDon)
            {
                if (d.noCommanditaire == id)
                {
                    don.Add(d);
                }
            }

            if (tblDon == null)
            {
                return HttpNotFound();
            }

            return View(don);
        }
    }
}