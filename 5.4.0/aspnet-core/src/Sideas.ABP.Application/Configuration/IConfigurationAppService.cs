using System.Threading.Tasks;
using Sideas.ABP.Configuration.Dto;

namespace Sideas.ABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
