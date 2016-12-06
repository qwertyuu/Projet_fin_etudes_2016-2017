using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlTypes;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;

namespace ECJ.Web.Controllers.AppelOffre
{
    [AbpMvcAuthorize]
    public class SoumissionController : Controller
    {
        // GET: Soumission
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        private DBProvider provider = new DBProvider();


        public ActionResult Index()
        {

            return View();
       
        }

        [AbpMvcAuthorize(PermissionNames.ConsulterSoumission)]
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
            LayoutController.pagePermission = PermissionNames.ConsulterSoumission;
            return View(soumission);
        }

        [AbpMvcAuthorize(PermissionNames.ApprouverSoumission)]
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

        [AbpMvcAuthorize(PermissionNames.ApprouverSoumission)]
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