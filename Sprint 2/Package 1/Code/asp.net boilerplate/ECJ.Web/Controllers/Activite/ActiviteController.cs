using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ECJ.Web.Controllers.Activite
{
    public class ActiviteController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        public ActionResult Ajout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajout([Bind(Include = "nomResponsable,etat,tache,detail,dateCreation,noEvenement,noSousEvenement")] tblActivite tblActivite)
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

                db.tblActivite.Add(tblActivite);
                db.SaveChanges();
                return RedirectToAction("../" + retour);
            }

            return View(tblActivite);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivite activite = db.tblActivite.Find(id);
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
                var elementAModifier = db.tblActivite.Find((int)id);
                elementAModifier.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction(retour);
        }

        public ActionResult ChangeEtat(int? id)
        {
            var retour = Request.QueryString["return"];

            if (id != null)
            {
                var elementAModifier = db.tblActivite.Find((int)id);
                if (elementAModifier.etat == 1)
                    elementAModifier.etat = 0;
                else
                    elementAModifier.etat = 1;

                db.SaveChanges();
            }
            return RedirectToAction("../" + retour);
        }

        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivite tblActivite = db.tblActivite.Find(id);
            if (tblActivite == null)
            {
                return HttpNotFound();
            }
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblActivite.noEvenement);
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom", tblActivite.noSousEvenement);
            return View(tblActivite);
        }

        // POST: tblActivites/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier([Bind(Include = "noActivite,nomResponsable,etat,dateCreation,tache,detail,dateSupprime,noEvenement,noSousEvenement")] tblActivite tblActivite)
        {
            var retour = Request.QueryString["return"];

            if (ModelState.IsValid)
            {
                db.Entry(tblActivite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("../"+retour);
            }

            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblActivite.noEvenement);
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom", tblActivite.noSousEvenement);

            return View(tblActivite);
        }
    }
}