using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;
using System.Net;
using System;
using ECJ.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages)]
    public class SousEvenementsController : ECJControllerBase
    {
        DBProvider db;

        public SousEvenementsController()
        {
            db = new DBProvider();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var serviceAAjouter = Request.Form["service"];
            //ajouter le service requis
            if (serviceAAjouter != null)
            {
                db.InsertServiceRequis((int)id, int.Parse(serviceAAjouter));
            }
            //supprimer un service requis
            var serviceASupprimer = Request.Form["service_suppr"];
            if (serviceASupprimer != null)
            {
                db.SupprimerServiceRequis((int)id, int.Parse(serviceASupprimer));
            }

            //ajouter le forfait sélectionné
            var forfaitAAjouter = Request.Form["forfait"];
            if (forfaitAAjouter != null)
            {
                db.LierForfait((int)id, int.Parse(forfaitAAjouter));
            }
            //supprimer le forfait sélectionné
            var forfaitASupprimer = Request.Form["forfait_suppr"];
            if (forfaitASupprimer != null)
            {
                db.DelierForfait((int)id, int.Parse(forfaitASupprimer));
            }

            //ajouter la salle sélectionnée
            var salleAAjouter = Request.Form["salle"];
            if (salleAAjouter != null)
            {
                db.LierSalle((int)id, int.Parse(salleAAjouter));
            }
            //supprimer la salle sélectionnée
            var salleASupprimer = Request.Form["salle_suppr"];
            if (salleASupprimer != null)
            {
                db.DelierSalle((int)id, int.Parse(salleASupprimer));
            }

            //ajouter l'engagement sélectionné
            var engagementAAjouter = Request.Form["engagement"];
            if (engagementAAjouter != null)
            {
                db.LierEngagement((int)id, int.Parse(engagementAAjouter));
            }
            //supprimer l'engagement sélectionné
            var engagementASupprimer = Request.Form["engagement_suppr"];
            if (engagementASupprimer != null)
            {
                db.DelierEngagement((int)id, int.Parse(engagementASupprimer));
            }


            var elementADetailler = db.FindSousEvenement((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            var service = db.ToutService().Except(elementADetailler.tblService).ToList();
            var salle = db.ToutSalle().Except(new List<tblSalle> { elementADetailler.tblSalle }).ToList();
            var forfait = db.ToutForfait().Except(elementADetailler.tblForfait).ToList();
            var engagement = db.ToutEngagement().Except(elementADetailler.tblEngagement).ToList();
            ViewBag.listTuple = new Tuple<tblSousEvenement, List<tblService>, List<tblSalle>, List<tblForfait>, List<tblEngagement>>(elementADetailler, service, salle, forfait, engagement);
            //Service, Salle, Forfait, Engagement
            return View();
        }

        public ActionResult Ajout()
        {
            ViewBag.noEvenement = Request.QueryString["evenement_id"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ajout([Bind(Include = "noSousEvenement,nom,description,noEvenement,noSalle,dateSupprime")] tblSousEvenement tblSousEvenement)
        {

            if (ModelState.IsValid)
            {
                db.InsertSousEvenement(tblSousEvenement);

                return Redirect(Request.QueryString["return"]);
            }
            return View();
        }

        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = db.ReturnSousEvenement((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier([Bind(Include = "noSousEvenement,nom,description,noEvenement,noSalle,dateSupprime")] tblSousEvenement tblSousEvenement)
        {
            if (ModelState.IsValid)
            {
                db.UpdateSousEvenement(tblSousEvenement);

                return Redirect(Request.QueryString["return"]);
            }
            return View(tblSousEvenement);
        }


        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                db.SupprimerSousEvenement((int)id);
            }
            return Redirect(Request.QueryString["return"]);
        }
    }
}