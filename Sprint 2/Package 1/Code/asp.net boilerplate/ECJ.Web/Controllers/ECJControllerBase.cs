using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.Web.Mvc.Authorization;
using System;
using System.Reflection;

namespace ECJ.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ECJControllerBase : AbpController
    {
        protected ECJControllerBase()
        {
            LocalizationSourceName = ECJConsts.LocalizationSourceName;
        }

        //Code pour lister les permissions requises pour un controlleur héritant de cette classe
        //utile pour générer la liste d'utilisateurs pouvant visionner ou non une page
        public void GetPermissions()
        {
            LayoutController.pagePermission = null;
            AbpMvcAuthorizeAttribute[] MyAttributes = (AbpMvcAuthorizeAttribute[])Attribute.GetCustomAttributes(this.GetType(), typeof(AbpMvcAuthorizeAttribute));
            if (MyAttributes.Length > 0 && MyAttributes[0].Permissions.Length > 0)
            {
                LayoutController.pagePermission = MyAttributes[0].Permissions[0];
            }
        }

        protected virtual void CheckModelState()
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException(L("FormIsNotValidMessage"));
            }
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}