using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LandWindCMS.Controllers
{
    public abstract class LandWindCMSControllerBase: AbpController
    {
        protected LandWindCMSControllerBase()
        {
            LocalizationSourceName = LandWindCMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
