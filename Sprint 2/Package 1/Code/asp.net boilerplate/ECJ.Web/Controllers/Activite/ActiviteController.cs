using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers.Activite
{
    public class ActiviteController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();

        // GET: Activite
        public ActionResult Index(string SearchString)
        {
            var activite = from q in db.tblActivite
                                select q;
            if (!String.IsNullOrEmpty(SearchString))
            {
                activite = db.tblActivite.Where(a => a.nomResponsable.Contains(SearchString.ToUpper()) || a.tache.Contains(SearchString.ToUpper()));
            }

            activite = from q in activite
                            orderby q.etat descending, q.dateCreation
                            select q;

            return View(activite.ToList());
        }

        public ActionResult Ajout(int? evenement_id, int? sousevenement_id)
        {
            if (evenement_id == null && sousevenement_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(new Tuple<int?, int?>(evenement_id, sousevenement_id));
        }
        [HttpPost]
        public ActionResult Ajout([Bind(Include = "nomResponsable,etat,tache,detail,dateCreation,noEvenement,noSousEvenement")] tblActivite tblActivite)
        {
            if (ModelState.IsValid)
            {
                db.tblActivite.Add(tblActivite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblActivite);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivite activite = db.tblActivite.Find(id);
            if (activite == null)
            {
                return HttpNotFound();
            }
            return View(activite);
        }

        public ActionResult Supprimer(int? id)
        {
            if (id != null)
            {
                var elementAModifier = db.tblActivite.Find((int)id);
                elementAModifier.dateSupprime = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Modifier(int? id)
        {
            if (id != null)
            {
                var elementAModifier = db.tblActivite.Find((int)id);
                if (elementAModifier.etat == 1)
                    elementAModifier.etat = 0;
                else
                    elementAModifier.etat = 1;

                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}