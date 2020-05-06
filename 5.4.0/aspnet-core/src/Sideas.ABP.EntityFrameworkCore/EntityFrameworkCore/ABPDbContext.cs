using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sideas.ABP.Authorization.Roles;
using Sideas.ABP.Authorization.Users;
using Sideas.ABP.MultiTenancy;

namespace Sideas.ABP.EntityFrameworkCore
{
    public class ABPDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPDbContext(DbContextOptions<ABPDbContext> options)
            : base(options)
        {
        }
    }
}
