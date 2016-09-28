using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Events)]
    public class EventsController : ECJControllerBase
    {
        private readonly IUserAppService _userAppService;

        public EventsController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

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