using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ECJ.Web.Controllers.Salles
{
    [AbpMvcAuthorize]
    public class SallesController : ECJControllerBase
    {
        DBProvider db;
        public SallesController()
        {
            db = new DBProvider();
            GetPermissions();
        }
        public ActionResult Index()
        {
            ViewBag.Salle = db.ToutVueSalle();

            return View();
        }
        public ActionResult Details(int id)
        {
            var serviceAAjouter = Request.Form["service"];
            //ajouter le service offert
            if (serviceAAjouter != null)
            {
                db.InsertServiceOffert((int)id, int.Parse(serviceAAjouter));
            }
            //supprimer un service offert
            var serviceASupprimer = Request.Form["service_suppr"] ?? Request.Form["service_delete_salle"];
            if (serviceASupprimer != null)
            {
                db.SupprimerServiceOffert((int)id, int.Parse(serviceASupprimer));
            }
            var serviceDeleteSalle = Request.Form["service_delete_salle"];
            if (serviceDeleteSalle != null)
            {
                var SousEvenementAvecService = db.ToutSousEvenement().Where(SsE => SsE.tblService.Contains(db.ReturnService(int.Parse(serviceDeleteSalle)))).ToList();
                foreach (var ss in SousEvenementAvecService)
                {
                    db.DelierSalle(ss.noSousEvenement);
                }
            }

            ViewBag.Salle = db.ReturnSalle(id);
            ViewBag.Service = db.ReturnSalle(id).tblService;
            ViewBag.ServiceAjoutable = db.ToutService().Except(db.ReturnSalle(id).tblService).ToList();
            ViewBag.SousEvent = db.ToutSousEvenement();
            return View();
        }
    }
}