using Abp.Authorization;
using LandWindCMS.Authorization.Roles;
using LandWindCMS.Authorization.Users;

namespace LandWindCMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
