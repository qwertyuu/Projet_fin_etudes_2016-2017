using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;
using System.Net;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ECJControllerBase
    {
        private readonly IUserAppService _userAppService;
        DBProvider db;

        public UsersController()
        {
        }

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
            db = new DBProvider();
            GetPermissions();
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementADetailler = db.ReturnUtilisateur((int)id);

            if (elementADetailler == null)
            {
                return HttpNotFound();
            }
            return View(elementADetailler);
        }

        public ActionResult Modifier(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var elementAModifier = db.ReturnUtilisateur((int)id);
            if (elementAModifier == null)
            {
                return HttpNotFound();
            }
            return View(elementAModifier);
        }

        public ActionResult Ajout()
        {
            return View();
        }
    }
}