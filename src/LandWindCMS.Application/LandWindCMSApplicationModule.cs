using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LandWindCMS.Authorization;

namespace LandWindCMS
{
    [DependsOn(
        typeof(LandWindCMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LandWindCMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LandWindCMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LandWindCMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
