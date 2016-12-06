using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ECJ.Web.Models;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.GererSousEvenement)]
    public class CalculateurController : ECJControllerBase
    {
        DBProvider db;
        public CalculateurController()
        {
            db = new DBProvider();
            GetPermissions();
        }
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var SousEvent = db.FindSousEvenement((int)id);

            ViewBag.SousEvent = SousEvent;

            if (SousEvent.tblSalle != null)
            {
               ViewBag.Salle = SousEvent.tblSalle;
            }
            else
            {
                ViewBag.Salle = new tblSalle(); //Envoie d'une salle vide pour empêcher l'envoie d'une erreur
            }

            ViewBag.Forfait = SousEvent.tblForfait.Where(f => f.dateSupprime == null);

            ViewBag.Calcul = db.ReturnCalculateur((int)id) ?? new tblCalculateur();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererSousEvenement)]
        public ActionResult Index([Bind(Include = "noSousEvenement,billet,prixBillet,billetVIP,prixBilletVIP,souperSpectacle,prixSouper,jeunePourcent,jeuneRatio,adultePourcent,adulteRatio,ainePourcent,aineRatio,promo,prevente,customNom1,customBillet1,customPrix1,customNom2,customBillet2,customPrix2")] tblCalculateur tblCalculateur)
        {
            if (tblCalculateur.customNom1 == null)
            {
                tblCalculateur.customNom1 = "";
            }
            if (tblCalculateur.customNom2 == null)
            {
                tblCalculateur.customNom2 = "";
            }

            tblCalculateur.tblSousEvenement = db.ReturnSousEvent(tblCalculateur.noSousEvenement);

            if (ModelState.IsValid)
            {
                db.UpdateCalculateur(tblCalculateur);

                return RedirectToAction("Index");
            }
            return View(tblCalculateur);
        }
    }
}