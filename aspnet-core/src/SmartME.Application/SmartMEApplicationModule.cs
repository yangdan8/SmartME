using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartME.Authorization;

namespace SmartME
{
    [DependsOn(
        typeof(SmartMECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartMEApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartMEAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartMEApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
