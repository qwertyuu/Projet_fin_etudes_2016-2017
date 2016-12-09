using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ECJ.Web.Controllers
{

    [AbpMvcAuthorize]
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
        public ActionResult Send(int expediteur, string destinataire, string message, string lien)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string[] destinataires = js.Deserialize<string[]>(destinataire);
            foreach (var dest in destinataires)
            {
                db.CreerMemo(expediteur, int.Parse(dest), message, lien);
            }
            return Content(expediteur + destinataire + message);
        }
    }
}