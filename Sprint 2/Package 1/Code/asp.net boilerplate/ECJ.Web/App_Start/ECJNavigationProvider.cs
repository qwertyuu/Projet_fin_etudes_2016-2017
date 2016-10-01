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
                        L("Act"),
                        url: "Activite",
                        icon: "fa fa-puzzle-piece",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Events",
                        L("Events"),
                        url: "Events",
                        icon: "fa fa-calendar",
                        requiresAuthentication: true
                        )
               ).AddItem(
                    new MenuItemDefinition(
                        "AppelOffre",
                        L("pub"),
                        url: "AppelOffre",
                        icon: "fa fa-television",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Commanditaires",
                        L("Comm"),
                        url: "Commanditaire",
                        icon: "fa fa-thumbs-up",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("About"),
                        url: "About",
                        icon: "fa fa-info-circle",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Calculateur",
                        L("Cal"),
                        url: "Calculateur",
                        icon: "fa fa-money",
                        requiresAuthentication: true
                        )
                ); ;
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ECJConsts.LocalizationSourceName);
        }
    }
}
