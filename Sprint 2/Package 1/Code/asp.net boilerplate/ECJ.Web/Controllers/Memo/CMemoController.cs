using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class CMemoController : Controller
    {
        DBProvider db = new DBProvider();

        [HttpPost]
        [Route("CMemo/FirstAjax/")]
        public ActionResult FirstAjax(string expediteur, string destinataire, string message)
        {
            return Content(expediteur + destinataire + message);
        }

        [HttpPost]
        public ActionResult Send(int expediteur, int destinataire, string message, string lien)
        {
            db.CreerMemo(expediteur, destinataire, message, lien);
            return Content(expediteur + destinataire + message);
        }
    }
}