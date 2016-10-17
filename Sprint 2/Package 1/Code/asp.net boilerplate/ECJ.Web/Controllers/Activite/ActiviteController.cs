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
        // GET: Activite
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Ajout(tblActivite tblActivite)
        {
            //traiter l'Ajout
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}