using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var Salles = db.ToutVueSalle();
            var recherche = Request.QueryString["recherche"];
            if (recherche != null)
            {
                if (recherche.Trim() == "")
                {
                    return RedirectToAction("Index");
                }
                ViewBag.recherche = recherche;
                recherche = recherche.Trim().ToUpper();
                Salles = Salles.Where(s => 
                s.nomSalle.ToUpper().Contains(recherche) ||
                (s.prix.ToString() + "$").ToUpper().Contains(recherche.Replace('.', ','))||
                s.billet.ToString().ToUpper().Contains(recherche) ||
                s.billetVIP.ToString().ToUpper().Contains(recherche)).ToList();
            }

            ViewBag.Salle = Salles;
                return View();
        }
        public ActionResult Details(int id)
        {
            if (IsGranted(PermissionNames.GererSalle))
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
                    var SousEvenementAvecService = db.ToutSousEvenement().Where(SsE => SsE.tblService.Contains(db.ReturnService(int.Parse(serviceDeleteSalle))) &&
                    SsE.tblEvenement.dateSupprime == null && SsE.tblEvenement.datefin >= DateTime.Now).ToList();
                    foreach (var ss in SousEvenementAvecService)
                    {
                        db.DelierSalle(ss.noSousEvenement);
                    }
                }
            }
            var salle = db.ReturnSalle(id);
            ViewBag.Salle = salle;
            ViewBag.Service = salle.tblService;
            ViewBag.ServiceAjoutable = db.ToutService().Except(salle.tblService).ToList();
            ViewBag.SousEvent = salle.tblSousEvenement.Where(sse => sse.dateSupprime == null && sse.tblEvenement.dateSupprime == null && sse.tblEvenement.datefin >= DateTime.Now).ToList();
            return View();
        }
    }
}