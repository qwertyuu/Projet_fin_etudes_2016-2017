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
    [AbpMvcAuthorize]
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
            ViewBag.Salle = db.FindSousEvenement((int)id).tblSalle;

            ViewBag.Calcul = db.ReturnCalculateur((int)id) ?? new tblCalculateur();

            ViewBag.Forfait = db.FindSousEvenement((int)id).tblForfait.Where(f => f.dateSupprime == null);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererSousEvenement)]
        public ActionResult Index([Bind(Include = "nbBillet,prixBillet,nbBilletVIP,prixBilletVIP,nbBilletSouper,prixSouper,JeunePourcent,RatioJeune,AdultePourcent,RatioAdulte,AinePourcent,RatioAine,nbBilletGratuit,nbBilletPreVente,NomRabaisCustom1,NbBilletRabaisCustom1,PourcentRabaisCustom1,NomRabaisCustom2,NbBilletRabaisCustom2,PourcentRabaisCustom2")] tblCalculateur tblCalculateur)
        {
            if (ModelState.IsValid)
            {
                db.UpdateCalculateur(tblCalculateur);

                return RedirectToAction("Index");
            }
            LayoutController.pagePermission = PermissionNames.GererSousEvenement;
            return View(tblCalculateur);
        }
    }
}