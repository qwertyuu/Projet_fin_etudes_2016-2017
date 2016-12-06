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
using System.Globalization;

namespace ECJ.Web.Controllers.Don
{
    [AbpMvcAuthorize(PermissionNames.GererDon)]
    public class DonController : ECJControllerBase
    {
        DBProvider provider;
        // GET: Don

        public DonController()
        {
            provider = new DBProvider();
            GetPermissions();
        }

        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<tblCommanditaire> comm = new List<tblCommanditaire>();
            List<tblSousEvenement> sousEvent = provider.ToutSousEvenement().Where(se => se.tblEvenement.datefin > DateTime.Now).ToList();

            foreach (var c in provider.CommanditaireList())
            {
                if (c.dateSupprime == null)
                {
                    comm.Add(c);
                }
            }
            var commandite = provider.returnCommanditaire((int)id);
            ViewBag.noCommanditaire = commandite.noCommanditaire;
            ViewBag.nomCommanditaire = commandite.nomCommanditaire;
            List<SelectListItem> sousEvenements = new List<SelectListItem>();
            foreach (var item in sousEvent)
            {
                sousEvenements.Add(new SelectListItem()
                {
                    Text = item.nom + " / " + item.tblEvenement.nom,
                    Value = item.noSousEvenement.ToString(),
                });
            }
            ViewBag.noSousEvenement = new SelectList(sousEvenements, "Value", "Text");

            return View();
        }

        // POST: tblDons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noDon,noCommanditaire,noSousEvenement,dateDon,dateSupprime")] tblDon tblDon, string montant)
        {

            if (ModelState.IsValid)
            {
                tblDon.montant = Convert.ToDecimal(montant, CultureInfo.InvariantCulture);

                provider.AjouterDon(tblDon);

                tblCommanditaire tblCommanditaire = provider.returnCommanditaire((int)tblDon.noCommanditaire);

                SendMail(tblCommanditaire.courrielContact.ToString(), tblDon.montant.ToString(), tblDon.dateDon.ToString());
            }
            var retour = Request.QueryString["return"] ?? "~/Commanditaire";
            return Redirect(retour);
        }
        
        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                provider.supprimerDon((int)id);
            }
            var retour = Request.QueryString["return"] ?? "~/Commanditaire";
            return Redirect(retour);
        }

        private void SendMail(string courrielContact, string montant, string dateDon)
        {
            string to = courrielContact;
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
            message.Body = "Merci pour votre don de " + montant + " $ effectué le " + dateDon + ".";

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                LayoutController.erreur = ex;
            }
        }
    }
}