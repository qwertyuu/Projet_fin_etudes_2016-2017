using Abp.Authorization;
using ECJ.Authorization.Roles;
using ECJ.MultiTenancy;
using ECJ.Users;

namespace ECJ.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
