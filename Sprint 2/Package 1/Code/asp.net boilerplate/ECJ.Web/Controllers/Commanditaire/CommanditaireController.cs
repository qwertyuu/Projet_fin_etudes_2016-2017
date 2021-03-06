﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Drawing.Imaging;
using System.Drawing;

namespace ECJ.Web.Controllers.Commanditaire
{
    [AbpMvcAuthorize]
    public class CommanditaireController : ECJControllerBase
    {
        DBProvider provider;


        public CommanditaireController()
        {
            provider = new DBProvider();
            GetPermissions();
        }

        // GET: Commanditaire
        public ActionResult Index()
        {
            var recherche = Request.QueryString["recherche"];
            var Commanditaire = provider.CommanditaireList();
            var don = provider.DonList();
            ViewBag.AllEvent = provider.ToutEvenement();
            ViewBag.AllSousEvent = provider.ToutSousEvenement();

            if (recherche != null)
            {
                if (recherche.Trim() == "")
                {
                    return RedirectToAction("Index");
                }

                ViewBag.recherche = recherche;
                recherche = recherche.Trim().ToUpper();

                Commanditaire = Commanditaire.Where(
                a => a.nomCommanditaire.ToString().ToUpper().Contains(recherche) ||
                a.courrielContact.ToString().ToUpper().Contains(recherche) ||
                a.nomContact.ToString().ToUpper().Contains(recherche) ||
                (a.tblDon.Where(d => d.dateSupprime == null).Sum(d => d.montant).ToString() + "$").Contains(recherche.Replace('.', ','))).ToList();

            }
            LayoutController.pagePermission = null;
            return View(Commanditaire);
        }

        public FileContentResult GetFile(int id)
        {
            var imagedata = provider.returnCommanditaire(id).logo;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata, string.Format("image/{0}", contentType.ToString().ToLower()));
        }

        // GET: tblCommanditaires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCommanditaire tblCommanditaire = provider.returnCommanditaire((int)id);
            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }
            LayoutController.pagePermission = null;
            return View(tblCommanditaire);
        }

        [AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        // GET: tblCommanditaires/Create
        public ActionResult Create()
        {
            LayoutController.pagePermission = PermissionNames.GererCommanditaire;
            return View();
        }

        // POST: tblCommanditaires/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        public ActionResult Create([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblCommanditaire.logo = reader.ReadBytes(pic.ContentLength);
                    }
                }

                provider.AjouterCommanditaire(tblCommanditaire);
                return RedirectToAction("Index");
            }
            LayoutController.pagePermission = PermissionNames.GererCommanditaire;

            return View(tblCommanditaire);
        }

        [AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        // GET: tblCommanditaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = provider.returnCommanditaire((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            LayoutController.pagePermission = PermissionNames.GererCommanditaire;
            return View(elementAModifier);
        }

        // POST: tblCommanditaires/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        public ActionResult Edit([Bind(Include = "noCommanditaire,nomCommanditaire,nomContact,logo,url,textePresentation,courrielContact,numTel,extension,dateSupprime")] tblCommanditaire tblCommanditaire)
        {
            if (ModelState.IsValid)
            {
                if (Request.Form["SupprimerAffiche"] != null)
                {
                    tblCommanditaire.logo = null;
                }
                else if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        tblCommanditaire.logo = reader.ReadBytes(pic.ContentLength);
                    }
                }
                else
                {
                    tblCommanditaire.logo = provider.returnCommanditaire(tblCommanditaire.noCommanditaire).logo;
                }
                provider.UpdateCommanditaire(tblCommanditaire);

                return RedirectToAction("Index");
            }
            LayoutController.pagePermission = PermissionNames.GererCommanditaire;
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Delete/5
        [AbpMvcAuthorize(PermissionNames.GererCommanditaire)]
        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                provider.SupprimerCommanditaire(id.Value);
            }
            return RedirectToAction("Index");
        }
    }
}