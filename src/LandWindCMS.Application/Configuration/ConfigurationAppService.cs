using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LandWindCMS.Configuration.Dto;

namespace LandWindCMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LandWindCMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
