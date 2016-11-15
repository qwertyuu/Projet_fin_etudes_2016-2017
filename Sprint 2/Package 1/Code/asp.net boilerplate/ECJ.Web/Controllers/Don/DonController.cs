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
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;

namespace ECJ.Web.Controllers.Don
{
    [AbpMvcAuthorize]
    public class DonController : ECJControllerBase
    {
        DBProvider provider;
        // GET: Don

        public DonController()
        {
            provider = new DBProvider();
            GetPermissions();
        }

        public ActionResult Create()
        {
            List<tblCommanditaire> comm = new List<tblCommanditaire>();
            List<tblSousEvenement> sousEvent = new List<tblSousEvenement>();

            var id = Request.QueryString["id"];

            foreach (var c in provider.CommanditaireList())
            {
                if (c.dateSupprime == null)
                {
                    comm.Add(c);
                }
            }

            foreach (var sE in provider.returnSousEvenement())
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
            }
            tblDon.montant = Convert.ToDecimal(tblDon.montant + ",00");

            provider.AjouterDon(tblDon);

            tblCommanditaire tblCommanditaire = provider.returnCommanditaire((int)tblDon.noCommanditaire);

            // CREATION DE MAIL NON-FONCTIONNEL
            string to = tblCommanditaire.courrielContact.ToString();
            string from = "PagPi1433443@etu.cegepjonquiere.ca";
            MailMessage message = new MailMessage(from, to);
            SmtpClient client = new SmtpClient("smtp.office365.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            NetworkCredential cred = new System.Net.NetworkCredential(from, "PAPageau04");
            client.Credentials = cred;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            message.Subject = "Merci de votre Commandite";
            message.Body = "Merci pour votre don de " + tblDon.montant + " $ effectué le " + tblDon.dateDon + ".";

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateMessage(): {0}",
                            ex.ToString());
            }

            return RedirectToAction("../Commanditaire/Index");
        }

        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                provider.supprimerDon((int)id);
            }
            return RedirectToAction("../Commanditaire/Index");
        }
    }
}