using System.Threading.Tasks;
using SmartME.Configuration.Dto;

namespace SmartME.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
