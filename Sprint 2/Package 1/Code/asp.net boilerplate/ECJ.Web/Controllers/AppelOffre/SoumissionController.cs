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
            tblSoumission soumission = provider.ReturnUneSoumi(id);
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
            tblSoumission soumi = provider.ReturnUneSoumi(id);

            if(soumi==null)
            {
                return HttpNotFound();
            }

            soumi.statut = 1;
            appelOffre.noStatut = provider.ReturnStatut("Complété").noStatut;

            //Les autres soumissions tombent à réfuseés
            foreach(tblSoumission s in provider.RetunSoumission(appelOffre.noAppelOffre))
            {
                if (s.noSoumission != id)
                    s.statut = 0;
            }
            provider.Save();

            return RedirectToAction("Details/"+appelOffre.noAppelOffre,"AppellOffre");


        }

        public ActionResult Refuser(int ? id)
        {
            tblSoumission soumi =provider.ReturnUneSoumi(id);
            tblAppelOffre appelOffre = provider.SelectAppelParSoumi(id);
            soumi.statut = 0;
            provider.Save();
            return RedirectToAction("Details/" + appelOffre.noAppelOffre, "AppellOffre");

        }
    }
}