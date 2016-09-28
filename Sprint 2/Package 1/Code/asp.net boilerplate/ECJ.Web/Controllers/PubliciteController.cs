using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class PubliciteController : ECJControllerBase
    {
        // GET: Publicite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajout()
        {
            return View();
        }
    }
}