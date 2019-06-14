using System.Threading.Tasks;
using LandWindCMS.Configuration.Dto;

namespace LandWindCMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
