using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LandWindCMS.Configuration;
using LandWindCMS.Web;

namespace LandWindCMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LandWindCMSDbContextFactory : IDesignTimeDbContextFactory<LandWindCMSDbContext>
    {
        public LandWindCMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LandWindCMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LandWindCMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LandWindCMSConsts.ConnectionStringName));

            return new LandWindCMSDbContext(builder.Options);
        }
    }
}
