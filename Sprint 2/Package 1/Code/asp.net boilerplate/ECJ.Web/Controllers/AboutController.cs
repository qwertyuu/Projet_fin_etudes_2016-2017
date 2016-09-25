using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class AboutController : ECJControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}