using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;
using ECJ.Web.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;


namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages)]
    public class EventsController : ECJControllerBase
    {
        private PE2_OfficielEntities db;
        public EventsController()
        {
            db = new PE2_OfficielEntities();
            GetPermissions();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementADetailler = db.tblEvenement.Find((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            return View(elementADetailler);
        }

        public ActionResult Index()
        {
            var tblEvenement = db.vueSomEvenement.ToList();
            var recherche = Request.QueryString["recherche"];

            if (recherche != null)
            {
                if (recherche.Trim() == "")
                {
                    return RedirectToAction("Index");
                }
                ViewBag.recherche = recherche;
                recherche = recherche.Trim().ToUpper();
                tblEvenement = tblEvenement.Where(e => 
                e.dateDebut.ToString().ToUpper().Contains(recherche) ||
                e.dateFin.ToString().ToUpper().Contains(recherche) ||
                (e.description ?? "").ToUpper().Contains(recherche) || 
                e.nom.ToUpper().Contains(recherche)).ToList();
            }
            return View(tblEvenement);
        }
        public ActionResult Ajout()
        {
            return View();
        }

        public FileContentResult GetFile(int id)
        {
            var imagedata = db.tblEvenement.Find(id).affiche;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata, string.Format("image/{0}", contentType.ToString().ToLower()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ajout([Bind(Include = "noEvenement,nom,dateDebut,datefin,affiche,url,description,dateSupprime")] tblEvenement tblEvenement)
        {

            if (ModelState.IsValid)
            {
                if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblEvenement.affiche = reader.ReadBytes(pic.ContentLength);
                    }
                }
                db.tblEvenement.Add(tblEvenement);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = db.tblEvenement.Find((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier([Bind(Include = "noEvenement,nom,dateDebut,datefin,affiche,url,description,dateSupprime")] tblEvenement tblEvenement)
        {
            //var a = db.tblEvenement.Find(tblEvenement.noEvenement) == tblEvenement;
            var modif = false;
            if (ModelState.IsValid)
            {
                if(Request.Form["SupprimerAffiche"] != null)
                {
                    tblEvenement.affiche = null;
                }
                else if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblEvenement.affiche = reader.ReadBytes(pic.ContentLength);
                    }
                }
                else
                {
                    tblEvenement.affiche = db.tblEvenement.Find(tblEvenement.noEvenement).affiche;
                    modif = true;
                }
                if (modif)
                {
                    db.Entry(db.tblEvenement.Find(tblEvenement.noEvenement)).CurrentValues.SetValues(tblEvenement);
                }
                else
                {
                    db.Entry(tblEvenement).State = EntityState.Modified;
                }
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(tblEvenement);
        }


        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                var elementAModifier = db.tblEvenement.Find((int)id);
                elementAModifier.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}