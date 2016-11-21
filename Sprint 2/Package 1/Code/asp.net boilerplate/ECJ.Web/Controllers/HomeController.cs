using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ECJControllerBase
    {
        DBProvider db;
        public HomeController()
        {
            db = new DBProvider();
            GetPermissions();
        }
        public ActionResult Index()
        {
            var memoASupprimer = Request.Form["memo_suppr"];
            if (memoASupprimer != null)
            {
                db.SupprimerMemo(int.Parse(memoASupprimer));
            }
            ViewBag.memos = db.MemosUtilisateur((long)AbpSession.UserId);
            return View();
        }

        public ActionResult Reset()
        {
            db.ResetDB();
            return RedirectToAction("Index");
        }
	}
}