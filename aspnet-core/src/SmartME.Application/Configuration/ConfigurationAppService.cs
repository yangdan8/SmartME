using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SmartME.Configuration.Dto;

namespace SmartME.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartMEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
