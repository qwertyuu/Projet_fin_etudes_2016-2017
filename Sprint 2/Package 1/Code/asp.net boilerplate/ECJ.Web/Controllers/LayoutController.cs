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

namespace ECJ.Web.Controllers
{
    public class LayoutController : ECJControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        DBProvider provider;
        public static Exception erreur;
        public static AbpMvcAuthorizeAttribute pagePermission;

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
            var vue = PartialView("_Erreur", erreur);
            erreur = null;
            return vue;
        }

        [ChildActionOnly]
        public PartialViewResult BottomMenu()
        {
            if (pagePermission != null)
            {
                ViewBag.users = provider.ToutUtilisateurs().Where(u => u.AbpUserRoles.Any(r => provider.SelectRole(r.RoleId).AbpPermissions.Where(p => p.Name == pagePermission.Permissions[0]).Any()));
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
                            CurrentLanguage = _localizationManager.CurrentLanguage,
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