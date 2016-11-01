using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Net.Mail;

namespace ECJ.Web.Controllers.Don
{
    public class DonController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        // GET: Don

        public ActionResult Create()
        {
            ViewBag.noCommanditaire = new SelectList(db.tblCommanditaire, "noCommanditaire", "nomCommanditaire");
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom");

            return View();
        }

        // POST: tblDons/Create
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

            CreateMessage(db.tblCommanditaire.Find(tblDon.noCommanditaire).courrielContact, tblDon.montant);

            ViewBag.noCommanditaire = new SelectList(db.tblCommanditaire, "noCommanditaire", "nomCommanditaire", tblDon.noCommanditaire);
            ViewBag.noSousEvenement = new SelectList(db.tblSousEvenement, "noSousEvenement", "nom", tblDon.noSousEvenement);
            return View(tblDon);
        }

        public static void CreateMessage(string Courriel,decimal montant)
        {
            string to = "jane@contoso.com";
            string from = "ben@contoso.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Don à ECJ";
            message.Body = @"Merci de votre don de : " + montant + ".";
            SmtpClient client = new SmtpClient(Courriel);
            // Credentials are necessary if the server requires the client 
            // to authenticate before it will send e-mail on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateMessage(): {0}",
                            ex.ToString());
            }
        }
    }
}