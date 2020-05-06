using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Sideas.ABP.Authorization.Users;
using Sideas.ABP.Editions;

namespace Sideas.ABP.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
