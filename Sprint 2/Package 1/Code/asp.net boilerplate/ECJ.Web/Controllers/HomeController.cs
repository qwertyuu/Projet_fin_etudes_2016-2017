using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ECJControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}