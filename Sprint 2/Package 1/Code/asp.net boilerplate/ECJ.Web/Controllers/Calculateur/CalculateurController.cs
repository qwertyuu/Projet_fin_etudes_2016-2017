using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ECJ.Web.Models;



namespace ECJ.Web.Controllers
{
    public class CalculateurController : Controller
    {
        DBProvider db;
        public CalculateurController()
        {
            db = new DBProvider();
        }
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Salle = db.FindSousEvenement((int)id).tblSalle;

            ViewBag.Forfait = db.FindSousEvenement((int)id).tblForfait;
            return View();
        }
    }
}