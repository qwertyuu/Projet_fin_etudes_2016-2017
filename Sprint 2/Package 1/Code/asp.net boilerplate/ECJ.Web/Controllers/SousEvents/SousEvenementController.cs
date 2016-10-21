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

            var elementADetailler = db.FindSousEvenement((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            var service = db.ToutService().Except(elementADetailler.tblService).ToList();
            var salle = new List<tblSalle>();
            //var salle = db.ToutSalle().Except(elementADetailler.tblSalle).ToList();
            var forfait = db.ToutForfait().Except(elementADetailler.tblForfait).ToList();
            var engagement = new List<tblEngagement>();
            //var engagement = db.ToutEngagement().Except(elementADetailler.tblEngagement).ToList();
            ViewBag.listTuple = new Tuple<tblSousEvenement, List<tblService>, List<tblSalle>, List<tblForfait>, List<tblEngagement>>(elementADetailler, service, salle, forfait, engagement);
            //Service, Salle, Forfait, Engagement
            return View();
        }

        public ActionResult Ajout()
        {
            return View();
        }
    }
}