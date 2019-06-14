using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LandWindCMS.Configuration;

namespace LandWindCMS.Web.Host.Startup
{
    [DependsOn(
       typeof(LandWindCMSWebCoreModule))]
    public class LandWindCMSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LandWindCMSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LandWindCMSWebHostModule).GetAssembly());
        }
    }
}
