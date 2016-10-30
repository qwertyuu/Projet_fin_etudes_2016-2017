using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlTypes;

namespace ECJ.Web.Controllers.AppelOffre
{
    public class SoumissionController : Controller
    {
        // GET: Soumission
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        private DBProvider provider = new DBProvider();
        private AppellOffreController CAppel = new AppellOffreController();


        public ActionResult Index()
        {

            return View();
       
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSoumission soumission = db.tblSoumission.Find(id);
            if (soumission == null)
            {
                return HttpNotFound();
            }
            return View(soumission);
        }

        public ActionResult Accepter(int? id)
        {
            tblAppelOffre appelOffre = provider.SelectAppelParSoumi(id);
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSoumission soumi = db.tblSoumission.Find(id);

            if(soumi==null)
            {
                return HttpNotFound();
            }

            soumi.statut = true;
            appelOffre.noStatut = db.tblStatutAppelOffre.Where(s => s.nom == "Complété").FirstOrDefault().noStatut;

            //Les autres soumissions tombent à réfuseés
            foreach(tblSoumission s in provider.RetunSoumission(appelOffre.noAppelOffre))
            {
                if (s.noSoumission != id)
                    s.statut = false;
            }
            provider.Save();

            return RedirectToAction("Details/"+appelOffre.noAppelOffre,"AppellOffre");


        }

        public ActionResult Refuser(int ? id)
        {
            tblSoumission soumi = db.tblSoumission.Find(id);
            tblAppelOffre appelOffre = provider.SelectAppelParSoumi(id);
            soumi.statut = false;
            provider.Save();
            return RedirectToAction("Details/" + appelOffre.noAppelOffre, "AppellOffre");

        }
    }
}