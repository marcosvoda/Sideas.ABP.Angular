using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sideas.ABP.EntityFrameworkCore
{
    public static class ABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
