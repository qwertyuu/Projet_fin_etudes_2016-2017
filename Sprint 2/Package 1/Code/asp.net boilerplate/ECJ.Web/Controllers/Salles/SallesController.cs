using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers.Salles
{
    [AbpMvcAuthorize]
    public class SallesController : ECJControllerBase
    {
        DBProvider db;
        public SallesController()
        {
            db = new DBProvider();
            GetPermissions();
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