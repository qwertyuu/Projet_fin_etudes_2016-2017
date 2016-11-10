using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers.Salles
{
    public class SallesController : ECJControllerBase
    {
        DBProvider db;
        public SallesController()
        {
            db = new DBProvider();
        }
        public ActionResult Index()
        {
            ViewBag.Salle = db.ToutSalle();

            return View();
        }
        public ActionResult Details(int id)
        {
            ViewBag.Salle = db.ReturnSalle(id);

            return View();
        }
    }
}