using System;
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
                a.nomContact.ToString().ToUpper().Contains(recherche)).ToList();
                
                List<tblDon> listDon = new List<tblDon>();
                tblDon tbldon;

                for (int i = 0; i < don.Count; i++)
                {
                    tbldon = new tblDon();
                    if (listDon.Count == 0 && don[i].dateSupprime == null)
                    {
                        tbldon.montant = (int)don[i].montant;
                        tbldon.noCommanditaire = don[i].noCommanditaire;
                        listDon.Add(tbldon);
                    }
                    else
                    {
                        if(don[i].dateSupprime == null)
                        {
                            bool trouve = false;
                            foreach(var j in listDon)
                            {
                                if (j.noCommanditaire == don[i].noCommanditaire)
                                {
                                    trouve = true;
                                    j.montant += don[i].montant;
                                }
                         
                            }
                            if(trouve == false)
                            {
                                tbldon.montant = (int)don[i].montant;
                                tbldon.noCommanditaire = don[i].noCommanditaire;
                                listDon.Add(tbldon);
                            }
                        }

                    }
                }

                listDon = listDon.Where(a => a.montant.ToString().ToUpper().Contains(recherche)).ToList();

                foreach (var i in listDon)
                {
                    Commanditaire.Add(provider.returnCommanditaire((int)i.noCommanditaire));
                }
            }
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
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblCommanditaires/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

            return View(tblCommanditaire);
        }

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
            return View(elementAModifier);
        }

        // POST: tblCommanditaires/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
            return View(tblCommanditaire);
        }

        // GET: tblCommanditaires/Delete/5
        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                var elementAModifier = provider.returnCommanditaire(Convert.ToInt32(id));
                elementAModifier.dateSupprime = DateTime.Now;
                provider.Save();
            }
            return RedirectToAction("Index");
        }

        public ActionResult DetailsDon(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCommanditaire tblCommanditaire = provider.returnCommanditaire(Convert.ToInt32(id));

            if (tblCommanditaire == null)
            {
                return HttpNotFound();
            }

            return View(tblCommanditaire);
        }
    }
}