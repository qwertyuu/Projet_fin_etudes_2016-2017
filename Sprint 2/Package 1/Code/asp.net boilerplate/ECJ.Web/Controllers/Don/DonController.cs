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
    [AbpMvcAuthorize(PermissionNames.Pages)]
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
            provider.AjouterDon(tblDon);

            /* CREATION DE MAIL NON-FONCTIONNEL
            string to = "PagPi1433443@etu.cegepJonquiere.ca";
            //string to = Courriel.ToString();
            string from = "PagPi1433443@etu.cegepJonquiere.ca";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Don à Évènement Cegep Jonquière";
            message.Body = @"Bonjours, /n Merci de votre don de : " + tblDon.montant + ". /n De la part de l'équipe d'ECJ";
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("PagPi1433443@etu.cegepjonquiere.ca", "PAPageau04");
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
            
             */

            return RedirectToAction("../Commanditaire/Index");
        }
    }
}