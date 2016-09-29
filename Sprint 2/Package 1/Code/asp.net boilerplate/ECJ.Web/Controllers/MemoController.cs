using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class MemoController : Controller
    {
        // GET: Memo
        public ActionResult Index()
        {
            return View();
        }
    }
}