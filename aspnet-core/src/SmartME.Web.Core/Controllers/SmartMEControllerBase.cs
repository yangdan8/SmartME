using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SmartME.Controllers
{
    public abstract class SmartMEControllerBase: AbpController
    {
        protected SmartMEControllerBase()
        {
            LocalizationSourceName = SmartMEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
