using Abp.Application.Navigation;
using Abp.Localization;
using ECJ.Authorization;

namespace ECJ.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class ECJNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "Users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Activite",
                        L("Activite"),
                        url: "Activite"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("About"),
                        url: "About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Events",
                        L("Events"),
                        url: "Events",
                        icon: "fa fa-calendar"
                        )
               ).AddItem(
                    new MenuItemDefinition(
                        "Publicite",
                        L("pub"),
                        url: "Publicite",
                        icon: "fa fa-television"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ECJConsts.LocalizationSourceName);
        }
    }
}
