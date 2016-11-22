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

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = provider.ReturnUtilisateur((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }
    }
}