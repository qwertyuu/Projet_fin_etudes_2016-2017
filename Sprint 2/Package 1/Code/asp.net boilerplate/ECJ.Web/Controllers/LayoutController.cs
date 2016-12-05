using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.Threading;
using ECJ.Sessions;
using ECJ.Web.Models.Layout;
using System.Linq;
using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;

namespace ECJ.Web.Controllers
{
    public class LayoutController : ECJControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        DBProvider provider;
        public static string pagePermission;
        private static List<Exception> erreurs;
        public static Exception erreur { set {

                if (erreurs == null)
                {
                    erreurs = new List<Exception>();
                }
                erreurs.Add(value);
            } }

        public LayoutController(
            IUserNavigationManager userNavigationManager, 
            ILocalizationManager localizationManager,
            ISessionAppService sessionAppService, 
            IMultiTenancyConfig multiTenancyConfig)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
            provider = new DBProvider();
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu(string activeMenu = "")
        {
            var model = new TopMenuViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                ActiveMenuItemName = activeMenu
            };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult Erreur()
        {
            if (erreurs == null)
            {
                erreurs = new List<Exception>();
            }
            Exception[] erreurs_model = new Exception[erreurs.Count];
            erreurs.CopyTo(erreurs_model);
            var vue = PartialView("_Erreur", erreurs_model.ToList());
            erreurs.Clear();
            return vue;
        }

        [ChildActionOnly]
        public PartialViewResult BottomMenu()
        {
            if (pagePermission != null)
            {
                ViewBag.users = provider.ToutUtilisateurs().Where(u => u.AbpUserRoles.Any(r => provider.SelectRole(r.RoleId).AbpPermissions.Where(p => p.Name == pagePermission).Any()));
            }
            else
            {
                ViewBag.users = provider.ToutUtilisateurs();
            }
            ViewBag.uId = AbpSession.UserId;
            return PartialView("_BottomMenu", AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("Footer", AbpSession.ToUserIdentifier())));
        }

        public ActionResult ResetPerm()
        {
            pagePermission = null;
            return new EmptyResult();
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = new LanguageInfo("fr", "Français", isDefault:true),
                            Languages = _localizationManager.GetAllLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }


        [ChildActionOnly]
        public PartialViewResult UserMenuOrLoginLink()
        {
            UserMenuOrLoginLinkViewModel model;

            if (AbpSession.UserId.HasValue)
            {
                model = new UserMenuOrLoginLinkViewModel
                {
                    LoginInformations = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations()),
                    IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
                };
            }
            else
            {
                model = new UserMenuOrLoginLinkViewModel
                {
                    IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled                    
                };
            }

            return PartialView("_UserMenuOrLoginLink", model);
        }
    }
}