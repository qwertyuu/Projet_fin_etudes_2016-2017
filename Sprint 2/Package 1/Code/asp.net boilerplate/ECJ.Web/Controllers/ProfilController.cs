using Abp.Web.Mvc.Authorization;
using System.Net;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfilController : ECJControllerBase
    {
        DBProvider provider;

        public ProfilController()
        {
            provider = new DBProvider();
            GetPermissions();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}