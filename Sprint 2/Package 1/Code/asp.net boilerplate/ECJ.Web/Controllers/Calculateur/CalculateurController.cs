using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ECJ.Web.Models;
using Abp.Web.Mvc.Authorization;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize]
    public class CalculateurController : ECJControllerBase
    {
        DBProvider db;
        public CalculateurController()
        {
            db = new DBProvider();
            GetPermissions();
        }
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Salle = db.FindSousEvenement((int)id).tblSalle;

            ViewBag.Calcul = db.ReturnCalculateur((int)id);

            ViewBag.Forfait = db.FindSousEvenement((int)id).tblForfait;

            return View();
        }
    }
}