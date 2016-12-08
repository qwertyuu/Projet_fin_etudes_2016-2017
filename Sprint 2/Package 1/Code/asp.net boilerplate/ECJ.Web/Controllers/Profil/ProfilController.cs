using Abp.Authorization.Users;
using Abp.Web.Mvc.Authorization;
using ECJ.Web.Models;
using Microsoft.AspNet.Identity;
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
            ViewBag.Question = new SelectList(provider.ToutQuestion(), "IdQuestion", "Question");

            var id = (long)AbpSession.UserId;

            var abp = provider.ReturnUtilisateur(id);

            return View(abp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdQuestion,Reponse")] AbpUsers Users)
        {
            var id = (long)AbpSession.UserId;

            var abp = provider.ReturnUtilisateur(id);
            
           if(Request.Files["pic"].ContentLength > 0)
            {
                var pic = Request.Files["pic"];
                using (var reader = new System.IO.BinaryReader(pic.InputStream))
                {
                    abp.ImageProfil = reader.ReadBytes(pic.ContentLength);
                }
                provider.UpdateUser(abp);
            }

            string PasswordChange = Request.Form["PasswordChange"];
            if (!string.IsNullOrWhiteSpace(PasswordChange))
            {
                abp.Password = new PasswordHasher().HashPassword(PasswordChange);
            }

            if (Users.Reponse != null)
            {
                abp.IdQuestion = Users.IdQuestion;
                abp.Reponse = Users.Reponse;
            }

            provider.UpdateUser(abp);

            return RedirectToAction("Index", "home");
        }
        public FileContentResult GetFile(int id)
        {
            var imagedata = provider.ReturnUtilisateur(id).ImageProfil;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata, string.Format("image/{0}", contentType.ToString().ToLower()));
        }
    }
}