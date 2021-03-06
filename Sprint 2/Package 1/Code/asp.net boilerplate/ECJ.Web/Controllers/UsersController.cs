﻿using System.Threading.Tasks;
using System.Linq;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ECJ.Authorization;
using ECJ.Users;
using System.Net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using Nito.AsyncEx.Synchronous;

namespace ECJ.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ECJControllerBase
    {
        DBProvider db;
        public UsersController()
        {
            //us = new UserStore();
            db = new DBProvider();
            GetPermissions();
        }

        public ActionResult CheckUser(string uname, string email)
        {
            if (db.UtilisateurExiste(uname, Request.Form["exclu_id"]))
            {
                Response.Write("Un utilisateur utilisant ce nom d'utilisateur existe déjà.\nVeuillez choisir un autre nom d'utilisateur.");
            }
            else if (db.CourrielExiste(email, Request.Form["exclu_id"]))
            {
                Response.Write("Un utilisateur utilisant ce courriel existe déjà.\nVeuillez choisir un autre courriel ou essayez de retrouver le compte utilisant déjà ce courriel.");
            }
            else
            {
                Response.Write("1");
            }
            return new EmptyResult();
        }

        public ActionResult Index()
        {
            var model = new Abp.Application.Services.Dto.ListResultOutput<ECJ.Web.Models.AbpUsers>(db.ToutUtilisateurs());
            var recherche = Request.QueryString["recherche"];
            Dictionary<long, string> nomRoles = new Dictionary<long, string>()
                {
                    {0, "Employe" },
                    {2, "Administrateur"},
                    {3, "Agent" },
                    {4, "Agent senior" },
                    {5, "Représentant" }
                };
            if (recherche != null)
            {
                if (recherche.Trim() == "")
                {
                    return RedirectToAction("Index");
                }

                ViewBag.recherche = recherche;
                recherche = recherche.Trim().ToUpper();
                model = new Abp.Application.Services.Dto.ListResultOutput<Models.AbpUsers>(
                    model.Items.Where(e =>
                e.UserName.ToUpper().Contains(recherche) ||
                e.Name.ToUpper().Contains(recherche) ||
                e.Surname.ToUpper().Contains(recherche) ||
                e.EmailAddress.ToUpper().Contains(recherche) ||
                nomRoles[(e.AbpUserRoles.FirstOrDefault() ?? new Models.AbpUserRoles() { RoleId = 0 }).RoleId].ToUpper().Contains(recherche) ||
                (e.IsActive ? "OUI" : "NON").Contains(recherche)).ToList()
                );
            }
            return View(model);
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
            ViewBag.Question = new SelectList(db.ToutQuestion(), "NoQuestion", "Question");
            if (AbpSession.UserId == null)
            {
                ViewBag.UtilisateurCourrant = null;
            }
            else
            {
                ViewBag.UtilisateurCourrant = (long)AbpSession.UserId;
            }

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
            ViewBag.Question = new SelectList(db.ToutQuestion(), "NoQuestion", "Question");
            if (AbpSession.UserId == null)
            {
                ViewBag.UtilisateurCourrant = null;
            }
            else
            {
                ViewBag.UtilisateurCourrant = (long)AbpSession.UserId;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ajout([Bind(Include = "Id,UserName,Name,Surname,EmailAddress,IsActive,NoQuestion, Reponse")] ECJ.Web.Models.AbpUsers AbpUser, string PasswordChange, int Role)
        {
            if (ModelState.IsValid)
            {
                AbpUser.TenantId = 1;
                AbpUser.IsDeleted = false;
                AbpUser.IsEmailConfirmed = false;
                AbpUser.CreationTime = DateTime.Now;

                AbpUser.Password = new PasswordHasher().HashPassword(PasswordChange);


                db.InsertUser(AbpUser);

                if (Role > 0 && AbpUser.Id > 1)
                {
                    AbpUser.AbpUserRoles.Add(new Models.AbpUserRoles()
                    {
                        RoleId = Role,
                        UserId = AbpUser.Id,
                        CreationTime = DateTime.Now,
                        TenantId = 1
                    });
                    db.Save();
                }

                if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        AbpUser.ImageProfil = reader.ReadBytes(pic.ContentLength);
                    }
                    db.UpdateUser(AbpUser);
                }


            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier([Bind(Include = "Id,UserName,Name,Surname,EmailAddress,IsActive,NoQuestion, Reponse")] ECJ.Web.Models.AbpUsers AbpUser, int Role)
        {
            if (ModelState.IsValid)
            {
                var u = db.ReturnUtilisateur(AbpUser.Id);
                string PasswordChange = Request.Form["PasswordChange"];
                if (!string.IsNullOrWhiteSpace(PasswordChange))
                {
                    AbpUser.Password = new PasswordHasher().HashPassword(PasswordChange);
                }
                else
                {
                    AbpUser.Password = u.Password;
                }

                if(AbpUser.Reponse == null)
                {
                    AbpUser.Reponse = u.Reponse;
                    AbpUser.NoQuestion = u.NoQuestion;
                }

                AbpUser.TenantId = 1;
                AbpUser.IsDeleted = false;
                AbpUser.IsEmailConfirmed = false;
                AbpUser.CreationTime = u.CreationTime;
                db.UpdateUser(AbpUser);
                db.UpdateRole(AbpUser, Role);

                if (Request.Files["pic"].ContentLength > 0)
                {
                    var pic = Request.Files["pic"];
                    using (var reader = new System.IO.BinaryReader(pic.InputStream))
                    {
                        AbpUser.ImageProfil = reader.ReadBytes(pic.ContentLength);
                    }
                    db.UpdateUser(AbpUser);
                }

            }
            return RedirectToAction("Index");
        }

        public FileContentResult GetFile(int id)
        {
            var imagedata = db.ReturnUtilisateur(id).ImageProfil;
            var contentType = DBProvider.GetContentType(imagedata);
            return new FileContentResult(imagedata, string.Format("image/{0}", contentType.ToString().ToLower()));
        }

    }
}