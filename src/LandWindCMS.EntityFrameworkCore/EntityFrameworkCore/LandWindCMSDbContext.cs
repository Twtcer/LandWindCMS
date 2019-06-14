using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LandWindCMS.Authorization.Roles;
using LandWindCMS.Authorization.Users;
using LandWindCMS.MultiTenancy;

namespace LandWindCMS.EntityFrameworkCore
{
    public class LandWindCMSDbContext : AbpZeroDbContext<Tenant, Role, User, LandWindCMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LandWindCMSDbContext(DbContextOptions<LandWindCMSDbContext> options)
            : base(options)
        {
        }
    }
}
