using Volo.Abp.Modularity;

namespace TyeDemo
{
    [DependsOn(
        typeof(TyeDemoApplicationModule),
        typeof(TyeDemoDomainTestModule)
        )]
    public class TyeDemoApplicationTestModule : AbpModule
    {

    }
}