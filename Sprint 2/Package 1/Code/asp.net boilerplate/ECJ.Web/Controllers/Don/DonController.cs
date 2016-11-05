using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;

namespace ECJ.Web.Controllers.Don
{
    public class DonController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        DBProvider provider = new DBProvider();
        // GET: Don

        public ActionResult Create()
        {
            List<tblCommanditaire> comm = new List<tblCommanditaire>();
            List<tblSousEvenement> sousEvent = new List<tblSousEvenement>();

            var id = Request.QueryString["id"];

            foreach (var c in db.tblCommanditaire)
            {
                if (c.dateSupprime == null)
                {
                    comm.Add(c);
                }
            }

            foreach (var sE in db.tblSousEvenement)
            {
                if (sE.dateSupprime == null)
                {
                    sousEvent.Add(sE);
                }
            }

            ViewBag.nomCommanditaire = provider.nomCommanditaire(Convert.ToInt32(id)).nomCommanditaire;
            ViewBag.noSousEvenement = new SelectList(sousEvent, "noSousEvenement", "nom");

            return View();
        }

        // POST: tblDons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noDon,noCommanditaire,noSousEvenement,montant,dateDon,dateSupprime")] tblDon tblDon)
        {
            var id = Request.QueryString["id"];

            if (ModelState.IsValid)
            {
                tblDon.noCommanditaire = Convert.ToInt32(id);
                db.tblDon.Add(tblDon);
                db.SaveChanges();
            }

            provider.CreateEmail(db.tblCommanditaire.Find(tblDon.noCommanditaire).courrielContact, tblDon.montant);

            return RedirectToAction("../Commanditaire/Index");
        }
    }
}