using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;

namespace ECJ.Web.Controllers.Activite
{
    [AbpMvcAuthorize(PermissionNames.Pages)]
    public class ActiviteController : ECJControllerBase
    {
        //private PE2_OfficielEntities db = new PE2_OfficielEntities();
        DBProvider db;

        public ActiviteController()
        {
            db = new DBProvider();
            GetPermissions();
        }

        public ActionResult Ajout()
        {
            ViewBag.UtilisateurCourrant = (long)AbpSession.UserId;
            return View();
        }

        [HttpPost]
        public ActionResult Ajout([Bind(Include = "nomResponsable,etat,tache,detail,dateCreation,noEvenement,noSousEvenement,noUtilisateur")] tblActivite tblActivite)
        {
            var idEvent = Request.QueryString["evenement_id"];
            var idSousEvent = Request.QueryString["sousevenement_id"];
            var retour = Request.QueryString["return"];
            
            if (ModelState.IsValid)
            {
                if (retour.Contains("sousEvenements"))
                {
                    tblActivite.noSousEvenement = Convert.ToInt32(idSousEvent);
                    tblActivite.noEvenement = null;
                }
                else
                {
                    tblActivite.noEvenement = Convert.ToInt32(idEvent);
                    tblActivite.noSousEvenement = null;
                }
                db.InsertActivite(tblActivite);
                return Redirect(retour);
            }

            return View(tblActivite);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivite activite = db.ReturnActivite((int)id);
            if (activite == null)
            {
                return HttpNotFound();
            }
            return View(activite);
        }

        public ActionResult Supprimer(int? id)
        {
            var retour = Request.QueryString["return"];

            if (id != null)
            {
                db.SupprimerActivite((int)id);
            }
            return Redirect(retour);
        }

        public ActionResult ChangeEtat(int? id)
        {
            var retour = Request.QueryString["return"];

            if (id != null)
            {
                db.ToggleEtatActivite((int)id);
            }
            return Redirect(retour);
        }

        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivite elementAModifier = db.ReturnActivite((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            ViewBag.UtilisateurCourrant = (long)AbpSession.UserId;
            return View(elementAModifier);
        }

        // POST: tblActivites/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier([Bind(Include = "noActivite,nomResponsable,etat,dateCreation,tache,detail,dateSupprime,noEvenement,noSousEvenement,noUtilisateur")] tblActivite tblActivite)
        {
            var retour = Request.QueryString["return"];

            if (ModelState.IsValid)
            {
                if(db.ReturnActivite(tblActivite.noActivite).noEvenement != null)
                    tblActivite.noEvenement = db.ReturnActivite(tblActivite.noActivite).noEvenement;
                else
                    tblActivite.noSousEvenement = db.ReturnActivite(tblActivite.noActivite).noSousEvenement;
                db.UpdateActivite(tblActivite);

                return Redirect(retour);
            }

            ViewBag.noEvenement = new SelectList(db.ToutEvenement(), "noEvenement", "nom", tblActivite.noEvenement);
            ViewBag.noSousEvenement = new SelectList(db.ToutSousEvenement(), "noSousEvenement", "nom", tblActivite.noSousEvenement);

            return View(tblActivite);
        }
    }
}