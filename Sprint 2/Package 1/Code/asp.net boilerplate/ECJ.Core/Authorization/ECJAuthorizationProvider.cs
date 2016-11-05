using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ECJ.Authorization
{
    public class ECJAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            var users = pages.CreateChildPermission(PermissionNames.Pages_Users, L("Users"));

            //Host permissions
            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            
            var creer_appel_offre = context.CreatePermission(PermissionNames.CreerAppelOffre, isGrantedByDefault: false);

            var creer_soumission = context.CreatePermission(PermissionNames.CreerSoumission, isGrantedByDefault: false);

            var creer_memo = context.CreatePermission(PermissionNames.CreerMemo, isGrantedByDefault: false);

            var consulter_appel_offre = context.CreatePermission(PermissionNames.ConsulterAppelOffre, isGrantedByDefault: false);

            var consulter_soumission = context.CreatePermission(PermissionNames.ConsulterSoumission, isGrantedByDefault: false); 

            var gerer_commanditaire = context.CreatePermission(PermissionNames.GererCommanditaire, isGrantedByDefault: false);

            var gerer_don = context.CreatePermission(PermissionNames.GererDon, isGrantedByDefault: false);

            var gerer_evenement = context.CreatePermission(PermissionNames.GererEvenement, isGrantedByDefault: false);

            var gerer_salle = context.CreatePermission(PermissionNames.GererSalle, isGrantedByDefault: false);

            var gerer_sousevenement = context.CreatePermission(PermissionNames.GererSousEvenement, isGrantedByDefault: false);

            var approuver_soumission = context.CreatePermission(PermissionNames.ApprouverSoumission, isGrantedByDefault: false);

            
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ECJConsts.LocalizationSourceName);
        }
    }
}
