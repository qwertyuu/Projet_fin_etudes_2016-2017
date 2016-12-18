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
    [AbpMvcAuthorize]
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
                e.nom.ToUpper().Contains(recherche)||
                (DateTime.Now > e.dateFin ? "TERMINÉ" :
                (DateTime.Now > e.dateDebut ? "EN COURS" : "PRÉPARATION")
                ).Contains(recherche)
                ).ToList();
            }
            GetPermissions();
            return View(tblEvenement);
        }

        [AbpMvcAuthorize(PermissionNames.GererEvenement)]
        public ActionResult Ajout(int? id)
        {
            if (id != null)
            {
                var elementADupliquer = db.ReturnEvenement((int)id);
                if (elementADupliquer == null)
                {
                    return View(new tblEvenement());
                }
                return View(elementADupliquer);
            }
            LayoutController.pagePermission = PermissionNames.GererEvenement;
            return View(new tblEvenement());
        }

        public FileContentResult GetFile(int id)
        {
            var imagedata = db.ReturnEvenement(id).affiche;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata, string.Format("image/{0}", contentType.ToString().ToLower()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererEvenement)]
        public ActionResult Ajout([Bind(Include = "noEvenement,nom,dateDebut,datefin,affiche,url,description,dateSupprime")] tblEvenement tblEvenement)
        {

            if (ModelState.IsValid)
            {
                if (Request.Form["SupprimerAffiche"] != null)
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
                    var evenement = db.ReturnEvenement(tblEvenement.noEvenement);
                    if(evenement != null)
                    {
                        tblEvenement.affiche = evenement.affiche;
                    }
                }
                db.InsertEvenement(tblEvenement);

                return RedirectToAction("Index");
            }
            LayoutController.pagePermission = PermissionNames.GererEvenement;
            return View();
        }

        [AbpMvcAuthorize(PermissionNames.GererEvenement)]
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
            LayoutController.pagePermission = PermissionNames.GererEvenement;
            return View(elementAModifier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererEvenement)]
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
            LayoutController.pagePermission = PermissionNames.GererEvenement;
            return View(tblEvenement);
        }


        [AbpMvcAuthorize(PermissionNames.GererEvenement)]
        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                db.SupprimerEvenement((int)id);
            }
            LayoutController.pagePermission = PermissionNames.GererEvenement;
            return RedirectToAction("Index");
        }
    }
}