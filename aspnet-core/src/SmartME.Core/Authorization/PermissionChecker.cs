using Abp.Authorization;
using SmartME.Authorization.Roles;
using SmartME.Authorization.Users;

namespace SmartME.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
