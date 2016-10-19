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
        // GET: Don

        public ActionResult Create(int? id)
        {
            ViewBag.noCommanditaire = new SelectList(db.tblCommanditaire, "noCommanditaire", "nomCommanditaire");
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom");
            return View();
        }

        // POST: tblDons/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noDon,noCommanditaire,noSousEvenement,montant,dateDon,dateSupprime")] tblDon tblDon)
        {
            if (ModelState.IsValid)
            {
                db.tblDon.Add(tblDon);
                db.SaveChanges();
                return RedirectToAction("../Commanditaire/Index");
            }

            ViewBag.noCommanditaire = new SelectList(db.tblCommanditaire, "noCommanditaire", "nomCommanditaire", tblDon.noCommanditaire);
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom", tblDon.noSousEvenement);
            return View(tblDon);
        }
    }
}