using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class CMemoController : Controller
    {
        // GET: CMemo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("CMemo/FirstAjax/")]
        public ActionResult FirstAjax(string expediteur, string destinataire, string message)
        {
            return Content(expediteur + destinataire + message);
        }
    }
}