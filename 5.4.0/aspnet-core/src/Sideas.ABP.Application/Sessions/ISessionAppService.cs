using System.Threading.Tasks;
using Abp.Application.Services;
using Sideas.ABP.Sessions.Dto;

namespace Sideas.ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
