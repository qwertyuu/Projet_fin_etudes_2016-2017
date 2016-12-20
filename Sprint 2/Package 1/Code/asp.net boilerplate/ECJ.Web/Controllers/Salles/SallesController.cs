using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Globalization;

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
                (s.prix.ToString() + "$").ToUpper().Contains(recherche.Replace('.', ',')) ||
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
        public ActionResult Ajouter()
        {
            return View();
        }

        public ActionResult Modifier(int id)
        {
            var salle = db.ReturnSalle(id);
            ViewBag.Salle = salle;
            ViewBag.Service = salle.tblService;
            ViewBag.ServiceAjoutable = db.ToutService().Except(salle.tblService).ToList();
            ViewBag.SousEvent = salle.tblSousEvenement.Where(sse => sse.dateSupprime == null && sse.tblEvenement.dateSupprime == null && sse.tblEvenement.datefin >= DateTime.Now).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        public ActionResult Ajouter([Bind(Include = "nomSalle,billet,billetVIP")] tblSalle tblSalle, string prix)
        {
            tblSalle.photoSalle = "http://magasin.skivr.com/133-1792-thickbox/option-marque-blanche-pour-krpano.jpg";
            tblSalle.urlGoogleMap = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2648.6453269213494!2d-71.24667188474935!3d48.405753937193936!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x2dd30e450fd3bd83!2zQ8OpZ2VwIGRlIEpvbnF1acOocmU!5e0!3m2!1sfr!2sca!4v1476204181668";
            tblSalle.prix = Convert.ToDecimal(prix, CultureInfo.InvariantCulture);
            if (ModelState.IsValid)
            {
                db.AjouterSalle(tblSalle);
                return RedirectToAction("Index");
            }

            return View(tblSalle);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        public ActionResult Modifier([Bind(Include = "nosalle,nomSalle,billet,billetVIP,photoSalle,urlGoogleMap")] tblSalle tblSalle, string prix)
        {
            tblSalle.prix = Convert.ToDecimal(prix, CultureInfo.InvariantCulture);
            if (ModelState.IsValid)
            {
                db.ModifierSalle(tblSalle);
                return RedirectToAction("Index");
            }
            return View(tblSalle);
        }
        public ActionResult Supprimer(int? id)
        {

            if (id != null)
            {
                try
                {
                    foreach (var item in db.ReturnListEventWithSalle((int)id))
                    {
                        db.DelierSalle(item.noSousEvenement);
                    }
                }
                catch (Exception)
                {

                }

                db.SupprimerSalle(id.Value);
            }
            return RedirectToAction("Index");
        }

    }
}