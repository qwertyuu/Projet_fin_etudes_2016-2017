using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;

namespace ECJ.Web.Controllers.Don
{
    public class DonController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        // GET: Don
        public ActionResult Ajout(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }            

            return View(id);
        }
    }
}