using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LandWindCMS.EntityFrameworkCore
{
    public static class LandWindCMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LandWindCMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LandWindCMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
