using Abp.Application.Services;
using Sideas.ABP.MultiTenancy.Dto;

namespace Sideas.ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

