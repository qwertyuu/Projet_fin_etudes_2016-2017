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
            context.Manager.Menus.Add("Footer", new MenuDefinition(
                "Footer", L("Footer"))
                .AddItem(
                    new MenuItemDefinition(
                        "Memo",
                        L("Memo"),
                        icon: "fa fa-plus",
                        requiresAuthentication: true,
                        url: ""
            )));
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                )/*.AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "Users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                )*/.AddItem(
                    new MenuItemDefinition(
                        "Events",
                        L("Events"),
                        url: "Events",
                        icon: "fa fa-calendar",
                        requiresAuthentication: true
                        )
               ).AddItem(
                    new MenuItemDefinition(
                        "AppellOffre",
                        L("pub"),
                        url: "AppellOffre",
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
                        "Salles",
                        L("Salles"),
                        url: "Salles",
                        icon: "fa fa-bed",
                        requiresAuthentication: true
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ECJConsts.LocalizationSourceName);
        }
    }
}
