﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECJ.Web.Controllers
{
    public class LireController : Controller
    {
        DBProvider db = new DBProvider();
        public ActionResult Index()
        {
            var MemoALire = Request.Form["id"];
            if (MemoALire != null)
            {
                db.LireMemo(int.Parse(MemoALire));
                return Content("Done :)", "text/plain");
            }
            return new HttpStatusCodeResult(500);
        }
    }
}