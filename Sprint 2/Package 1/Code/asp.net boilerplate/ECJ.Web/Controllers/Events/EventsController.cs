using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;
using ECJ.Web.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;


namespace ECJ.Web.Controllers
{
    //[AbpMvcAuthorize(PermissionNames.Pages_Events)]
    public class EventsController : ECJControllerBase
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementADetailler = db.tblEvenement.Find((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            return View(elementADetailler);
        }
        public ActionResult Index()
        {
            var tblEvenement = db.vueSomEvenement;
            return View(tblEvenement);
        }
        public ActionResult Ajout()
        {
            return View();
        }
        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = db.tblEvenement.Find((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }
    }
}