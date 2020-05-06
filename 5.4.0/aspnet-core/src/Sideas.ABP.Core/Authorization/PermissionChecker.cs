using Abp.Authorization;
using Sideas.ABP.Authorization.Roles;
using Sideas.ABP.Authorization.Users;

namespace Sideas.ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
