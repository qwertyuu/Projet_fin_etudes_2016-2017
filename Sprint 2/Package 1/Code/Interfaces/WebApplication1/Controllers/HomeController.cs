using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Évènements()
        {
            return View();
        }

        public ActionResult Publicités()
        {
            return View();
        }

        public ActionResult Forfaits()
        {
            return View();
        }
        public ActionResult Activite()
        {
            return View();
        }
    }
}