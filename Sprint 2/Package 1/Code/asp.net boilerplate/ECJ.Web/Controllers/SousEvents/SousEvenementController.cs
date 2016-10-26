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
            var serviceAAjouter = Request.Form["service"] ?? Request.Form["service_delete_salle"];
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

            //supprimer la salle sélectionnée ou si le service ajouté est de trop
            if (Request.Form["salle_suppr"] != null || Request.Form["service_delete_salle"] != null)
            {
                db.DelierSalle((int)id);
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


            var SousEvenementCourrant = db.FindSousEvenement((int)id);
            if(SousEvenementCourrant.tblSalle != null)
            {
                ViewBag.ServicesOfferts = SousEvenementCourrant.tblSalle.tblService;
            }

            if (SousEvenementCourrant == null)
            {
                return HttpNotFound();
            }
            var service = db.ToutService().Except(SousEvenementCourrant.tblService).ToList();
            //sortir seulement les salles n'étant pas celle sélectionnée (peu probable, car la view ne permet pas de choisir une salle lorsqu'il y en a déjà une de sélectionnée)
            //et sortir seulement les salles offrant au minimum les services requis.
            var salle = db.ToutSalle().Except(new List<tblSalle> { SousEvenementCourrant.tblSalle })
                .Where(Salle =>
                    //Services requis par le sous-evenement sont tous (All) dans la liste des services offerts de la salle
                    SousEvenementCourrant.tblService.All(ServiceRequis =>
                        Salle.tblService.Contains(ServiceRequis)
                    )
                ).ToList();
            var forfait = db.ToutForfait().Except(SousEvenementCourrant.tblForfait).ToList();
            var engagement = db.ToutEngagement().Except(SousEvenementCourrant.tblEngagement).ToList();
            ViewBag.listTuple = new Tuple<tblSousEvenement, List<tblService>, List<tblSalle>, List<tblForfait>, List<tblEngagement>>(SousEvenementCourrant, service, salle, forfait, engagement);
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
            var elementAModifier = db.FindSousEvenement((int)id);
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