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
    public class CommanditaireController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: Commanditaire
        public ActionResult Index(string SearchString)
        {
            var commanditaire = from q in db.tblCommanditaire
                                select q;
            if (!String.IsNullOrEmpty(SearchString))
            {
                commanditaire = db.tblCommanditaire.Where(a => a.nomCommanditaire.Contains(SearchString.ToUpper()) || a.courrielContact.Contains(SearchString.ToUpper()) || a.nomContact.Contains(SearchString.ToUpper()) || a.numTel.Contains(SearchString.ToUpper()));
            }

            commanditaire = from q in commanditaire
                            orderby q.nomCommanditaire
                            select q;

            return View(commanditaire.ToList());
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
            return View();
        }

        // POST: tblCommanditaires/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                using (var reader = new System.IO.BinaryReader(upload.InputStream))
                {
                    tblCommanditaire.logo = reader.ReadBytes(upload.ContentLength);
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
            tblCommanditaire tblCommanditaire = db.tblCommanditaire.Find(id);
            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }
            return View(tblCommanditaire);
        }

        // POST: tblCommanditaires/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
              if (tblCommanditaire.logo == null)
                {
                    if (db.tblCommanditaire.Find(tblCommanditaire.noCommanditaire).logo != null)
                    {
                        using (var reader = new System.IO.BinaryReader(upload.InputStream))
                        {
                            tblCommanditaire.logo = reader.ReadBytes(upload.ContentLength);
                        }
                    }
                }

                db.Entry(tblCommanditaire).State = EntityState.Modified;
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

        public ActionResult DeleteImage(int id)
        {
            db.tblCommanditaire.Find(id).logo = null;
            db.SaveChanges();
            return RedirectToAction("Edit/" + id.ToString());
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