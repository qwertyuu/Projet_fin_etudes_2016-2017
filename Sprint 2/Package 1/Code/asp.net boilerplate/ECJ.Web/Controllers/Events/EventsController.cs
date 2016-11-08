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
        private DBProvider db;
        public EventsController()
        {
            db = new DBProvider();
            GetPermissions();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementADetailler = db.ReturnEvenement((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            ViewBag.UtilisateurCourrant = (long)AbpSession.UserId;
            return View(elementADetailler);
        }

        public ActionResult Index()
        {
            var tblEvenement = db.ToutSomEvenement();
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
                String.Format("{0:yyyy/MM/dd}", e.dateDebut).Contains(recherche) ||
                String.Format("{0:yyyy/MM/dd}", e.dateFin).Contains(recherche) ||
                (e.description ?? "").ToUpper().Contains(recherche) || 
                e.nom.ToUpper().Contains(recherche)).ToList();
            }
            ViewBag.PeutAjouterEvenement = PermissionChecker.IsGrantedAsync("Pages").Result;
            return View(tblEvenement);
        }
        public ActionResult Ajout()
        {
            return View();
        }

        public FileContentResult GetFile(int id)
        {
            var imagedata = db.ReturnEvenement(id).affiche;
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
                db.InsertEvenement(tblEvenement);

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
            var elementAModifier = db.ReturnEvenement((int)id);
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
                    tblEvenement.affiche = db.ReturnEvenement(tblEvenement.noEvenement).affiche;
                }
                db.UpdateEvenement(tblEvenement);

                return RedirectToAction("Index");
            }
            return View(tblEvenement);
        }


        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                db.SupprimerEvenement((int)id);
            }
            return RedirectToAction("Index");
        }
    }
}